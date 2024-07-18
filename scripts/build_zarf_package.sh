#!/bin/bash

# Due to relative paths this script is intended to be run from the root of the repository.

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

# Function to find an unused port
find_UNUSED_PORT() {
  local port=40000
  while [ $port -le 50000 ]; do
    if ! (echo "" > /dev/tcp/127.0.0.1/$port) >/dev/null 2>&1; then
      echo $port
      return
    fi
    port=$((port + 1))
  done
  echo "No unused port found in the range 40000-50000" >&2
  return 1
}

# Find an unused port
UNUSED_PORT=$(find_UNUSED_PORT)
echo "Using port $UNUSED_PORT for Docker registry."

# set the registry, image name and tag
REMOTE_DOCKER_REGISTRY="ghcr.io"
LOCAL_DOCKER_REGISTRY="localhost:${UNUSED_PORT}"
IMAGE_NAME="defenseunicorns/wfapi/containers/wfapi"
IMAGE_TAG=$(yq e '.metadata.version' zarf/zarf.yaml)

# Run Docker registry
if ! docker run -d -p "${UNUSED_PORT}:5000" --restart=always --name registry registry:2; then
  echo "Failed to start Docker registry."
  exit 1
fi

# Sleep for a couple of seconds to allow the registry to start
sleep 3

# Build and push the image
if ! docker buildx build -f wfapi/Dockerfile -t "${LOCAL_DOCKER_REGISTRY}/${IMAGE_NAME}:${IMAGE_TAG}" --push .; then
  echo "Failed to build and push the image."
  exit 1
fi

# Build the Zarf package creation command
ZARF_COMMAND="uds zarf package create zarf -o zarf --registry-override=${REMOTE_DOCKER_REGISTRY}=${LOCAL_DOCKER_REGISTRY} --insecure --no-progress --confirm"

if $SKIP_SBOM; then
  ZARF_COMMAND="$ZARF_COMMAND --skip-sbom"
fi

# Creating the Zarf package
echo "Executing: $ZARF_COMMAND"
if ! $ZARF_COMMAND; then
  echo "Failed to create the Zarf package."
  exit 1
fi

# The cleanup function will be called automatically at this point
