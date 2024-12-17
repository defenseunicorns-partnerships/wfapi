# WFAPI
WIP Golang implementation of https://github.com/defenseunicorns-partnerships/wfapi

This is an API-FIRST project, meaning that the [OpenAPI specification file](openapi-spec.yaml) is the source of truth. The codebase is generated/written based on the OpenAPI specification file.

## Development

### Prerequisites
- Docker
- Docker Compose (probably already installed with Docker)
- [UDS CLI](https://github.com/defenseunicorns/uds-cli)

### OpenAPI Studio
Since this is an API-FIRST project, we edit the OpenAPI specification file before we make code changes. You can edit the OpenAPI Specification file however you want, as long as it stays compatible with the OpenAPI 3.0.2 specification and is editable in the OpenAPI Studio:

#### OpenAPI Studio Workflow
1. Run `uds run studio:up`
2. Open the OpenAPI Studio in your browser by navigating to [http://localhost:8888](http://localhost:8888)
3. Drag `openapi-spec.yaml` into the browser window
4. Edit the OpenAPI Specification file
5. Click Save As -> YAML
6. Save the file as `openapi-spec.yaml` in the root of the project. Overwrite the existing file.
7. Commit the changes
8. When you're done, run `uds run studio:down` to clean up
test
