#!/usr/bin/env sh

set -e

# Function to get the system architecture
get_architecture() {
  arch=$(uname -m)

  case "$arch" in
    x86_64)
      echo "amd64"
      ;;
    arm64 | aarch64)
      echo "arm64"
      ;;
    *)
      echo "Unknown architecture: $arch"
      ;;
  esac
}

# Call the function and store the result in a variable
ARCHITECTURE=$(get_architecture)

# Print the architecture
echo "$ARCHITECTURE"
