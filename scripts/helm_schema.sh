#!/usr/bin/env sh

set -e

if ! helm plugin list | grep -q "schema"; then
  echo "Error: Helm plugin 'schema' is not installed. Please install helm-values-schema-json plugin! https://github.com/losisin/helm-values-schema-json#install" >&2
  exit 1
fi

helm schema -input chart/values.yaml -output chart/values.schema.json -draft 7 -indent 2 -schemaRoot.id "values.yaml" -schemaRoot.title "values.yaml" -schemaRoot.description "Helm chart values." -schemaRoot.additionalProperties "false"
