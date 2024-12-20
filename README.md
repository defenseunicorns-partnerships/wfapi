# WFAPI
WIP Golang implementation of https://github.com/defenseunicorns-partnerships/wfapi

This is an API-FIRST project, meaning that the [OpenAPI specification file](openapi-spec.yaml) is the source of truth. The codebase is generated/written based on the OpenAPI specification file.

## Development

### Prerequisites
- Docker
- Docker Compose (probably already installed with Docker)
- [UDS CLI](https://github.com/defenseunicorns/uds-cli)
- Golang

### oapi-codegen Usage
This project uses the [oapi-codegen](https://github.com/oapi-codegen/oapi-codegen) tool to generate server code based on the OpenAPI specification file. The generated code has the extension `.gen.go` and should not be modified manually.

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

### Dev Workflow

```shell
# Update the dependencies as needed
go mod tidy

# Update the generated code whenever the openapi-spec.yaml file changes
go generate ./...

# Start the server. It will be available at http://localhost:8080
go run main.go serve

# See the available commands and flags
go run main.go serve --help
```

### Known Issues

#### The OpenAPI Studio (Apicurio) does not show "default" responses
The Apicurio studio does not show "default" responses in the UI. This is a known issue and is not a problem with the OpenAPI specification file. The "default" responses are still present in the OpenAPI specification file and will be used by the code generator. You'll need to add the "default" responses manually in the [openapi-spec.yaml](openapi-spec.yaml) file.

```yaml
default:
    description: unexpected error
    content:
        application/json:
            schema:
                $ref: '#/components/schemas/Error'
```
