#!/usr/bin/env sh

set -e

rm -rf chart/docs
npx --yes @adobe/jsonschema2md -d chart -o chart/docs -x - --example-format yaml --header true
