#!/usr/bin/env sh

# This script contains relative paths. It should only be run from the root of the repo.
# Correct:
# cd <rootDirectory> && ./dotnet/scripts/jsonschema2md.sh
# Incorrect:
# cd <rootDirectory>/dotnet/scripts && jsonschema2md.sh

set -e

rm -rf dotnet/chart/docs
npx --yes @adobe/jsonschema2md -d dotnet/chart -o dotnet/chart/docs -x - --example-format yaml --header true
