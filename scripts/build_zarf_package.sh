#!/bin/bash

# Function to display usage instructions
usage() {
    echo "Usage: $0 [-s|--skip-sbom]"
    exit 1
}

# Initialize variable
SKIP_SBOM=false

# Parse input arguments
while [[ "$1" != "" ]]; do
    case $1 in
        -s | --skip-sbom )
            SKIP_SBOM=true
            ;;
        -h | --help )
            usage
            ;;
        * )
            usage
            ;;
    esac
    shift
done

# Function to clean up Docker registry
cleanup() {
  echo "Stopping and removing Docker registry..."
  docker stop registry || true
  docker rm registry || true
}

# Set up trap to call cleanup function on script exit
trap cleanup EXIT

# Function to find a random unused port
find_unused_port() {
  local port
  while : ; do
    port=$(shuf -i 40000-65535 -n 1)
    (echo "" > /dev/tcp/127.0.0.1/$port) >/dev/null 2>&1
    if [ $? -ne 0 ]; then
      echo $port
      return
    fi
  done
}

# Find an unused port
unused_port=$(find_unused_port)
echo "Using port $unused_port for Docker registry."

# Run Docker registry
docker run -d -p ${unused_port}:5000 --restart=always --name registry registry:2

# Check if docker run succeeded
if [ $? -ne 0 ]; then
  echo "Failed to start Docker registry."
  exit 1
fi

# Tagging the image
docker tag ghcr.io/defenseunicorns/wfapi/wfapi:$(yq e '.metadata.version' zarf/zarf.yaml) localhost:${unused_port}/defenseunicorns/wfapi/wfapi:$(yq e '.metadata.version' zarf/zarf.yaml)
if [ $? -ne 0 ]; then
  echo "Failed to tag the image."
  exit 1
fi

# Pushing the image
docker push localhost:${unused_port}/defenseunicorns/wfapi/wfapi:$(yq e '.metadata.version' zarf/zarf.yaml)
if [ $? -ne 0 ]; then
  echo "Failed to push the image."
  exit 1
fi

# Build the Zarf package creation command
ZARF_COMMAND="uds zarf package create zarf -o zarf --registry-override=ghcr.io=localhost:${unused_port} --insecure --no-progress --confirm"

if $SKIP_SBOM; then
    ZARF_COMMAND="$ZARF_COMMAND --skip-sbom"
fi

# Creating the Zarf package
echo "Executing: $ZARF_COMMAND"
$ZARF_COMMAND

if [ $? -ne 0 ]; then
  echo "Failed to create the Zarf package."
  exit 1
fi

# The cleanup function will be called automatically at this point
