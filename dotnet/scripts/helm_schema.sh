#!/usr/bin/env sh

# This script contains relative paths. It should only be run from the root of the repo.
# Correct:
# cd <rootDirectory> && ./dotnet/scripts/helm_schema.sh
# Incorrect:
# cd <rootDirectory>/dotnet/scripts && helm_schema.sh

set -e

if ! helm plugin list | grep -q "schema"; then
  echo "Error: Helm plugin 'schema' is not installed. Please install helm-values-schema-json plugin! https://github.com/losisin/helm-values-schema-json#install" >&2
  exit 1
fi

helm schema -input dotnet/chart/values.yaml -output dotnet/chart/values.schema.json -draft 7 -indent 2 -schemaRoot.id "values.yaml" -schemaRoot.title "values.yaml" -schemaRoot.description "Helm chart values." -schemaRoot.additionalProperties "false"
