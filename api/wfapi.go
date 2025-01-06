//go:generate go run github.com/oapi-codegen/oapi-codegen/v2/cmd/oapi-codegen --config=oapi-codegen-config.yaml openapi-spec.yaml

package api

import (
	_ "embed"
	"encoding/json"
	"fmt"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/logger"
	"net/http"
	"sigs.k8s.io/yaml"
)

//go:embed openapi-spec.yaml
var openApiSpec string

type Server struct {
}

// Make sure we conform to ServerInterface
var _ ServerInterface = (*Server)(nil)

func NewServer() *Server {
	return &Server{}
}

// sendServerError wraps sending of an error in the Error format, and handling the failure to marshal that.
func sendServerError(w http.ResponseWriter, code int, message string) {
	wfapiErr := Error{
		Code:    int32(code),
		Message: message,
	}
	w.WriteHeader(code)
	_ = json.NewEncoder(w).Encode(wfapiErr)
}

func (s Server) GetSwaggerUi(w http.ResponseWriter, r *http.Request) {
	openApiSpecYaml, err := yaml.Marshal(openApiSpec)
	if err != nil {
		sendServerError(w, http.StatusInternalServerError, "failed to marshal openapi spec")
		return
	}
	openApiSpecJson, err := yaml.YAMLToJSON(openApiSpecYaml)
	if err != nil {
		sendServerError(w, http.StatusInternalServerError, "failed to convert yaml to json")
		return
	}
	html := `<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Elements in HTML</title>
  
    <script src="https://unpkg.com/@stoplight/elements/web-components.min.js"></script>
    <link rel="stylesheet" href="https://unpkg.com/@stoplight/elements/styles.min.css">
  </head>
  <body>

    <elements-api
      id="docs"
      router="memory"
      layout="responsive"
    />
   	<script>
	  (async () => {
		const docs = document.getElementById('docs');
		const spec = %s
		docs.apiDescriptionDocument = spec;
	  })();
	</script>

  </body>
</html>`

	// Write the HTML response, injecting the OpenAPI spec
	logger.Default().Debug("serving swagger-ui")
	w.Header().Set("Content-Type", "text/html")
	w.WriteHeader(http.StatusOK)
	_, _ = w.Write([]byte(fmt.Sprintf(html, openApiSpecJson)))
}

// SubmitWorkflow implements POST /api/v1/workflows - Submit Workflow
func (s Server) SubmitWorkflow(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

// GetWorkflowFiles implements GET /api/v1/workflows/files - List Files
func (s Server) GetWorkflowFiles(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

func (s Server) UploadWorkflowFile(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

func (s Server) DeleteWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

func (s Server) DownloadWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

func (s Server) GetApiV1WorkflowsWorkflowName(w http.ResponseWriter, r *http.Request, workflowName string) {
	//TODO implement me
	panic("implement me")
}

func (s Server) GetApiV1WorkflowsWorkflowNamePodsPodNameLogstream(w http.ResponseWriter, r *http.Request, workflowName string, podName string) {
	//TODO implement me
	panic("implement me")
}
