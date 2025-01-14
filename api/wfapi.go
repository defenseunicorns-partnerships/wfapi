//go:generate go run github.com/oapi-codegen/oapi-codegen/v2/cmd/oapi-codegen --config=oapi-codegen-config.yaml openapi-spec.yaml

package api

import (
	"context"
	_ "embed"
	"encoding/json"
	"fmt"
	"github.com/MicahParks/keyfunc/v3"
	"github.com/aws/aws-sdk-go-v2/aws"
	"github.com/aws/aws-sdk-go-v2/service/s3"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/environment"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/logger"
	"github.com/golang-jwt/jwt/v5"
	"io"
	"net/http"
	"sigs.k8s.io/yaml"
	"strings"
	"time"
)

//region Boilerplate

//go:embed openapi-spec.yaml
var openApiSpec string

type Server struct {
	// S3Client is a Pointer to an S3 client
	S3Client *s3.Client

	// BucketName is the name of the bucket to use
	BucketName string

	// Environment specifies the deployment environment such as Development, Test, or Production.
	Environment environment.Enum

	// WellKnownConfigUrl is the URL of the OpenID WellKnownConfig
	WellKnownConfigUrl string
}

// Make sure we conform to ServerInterface
var _ ServerInterface = (*Server)(nil)

// NewServer creates a new instance of the Server
func NewServer(s3Client *s3.Client, bucketName string, env environment.Enum, wellKnownConfigUrl string) *Server {
	return &Server{
		S3Client:           s3Client,
		BucketName:         bucketName,
		Environment:        env,
		WellKnownConfigUrl: wellKnownConfigUrl,
	}
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

//endregion

//region Workflows/Files

// GetWorkflowFiles implements GET /api/v1/workflows/files - List Files
func (s Server) GetWorkflowFiles(w http.ResponseWriter, r *http.Request) {
	objectPrefix := "files/"
	if s.Environment != environment.Development {
		// Extract the client_id claim out of the JWT and change objectPrefix to "<client_id>/files/". If there's no JWT or the client_id claim is missing, error out.
		// Extract the client_id from the JWT
		authHeader := r.Header.Get("Authorization")
		if authHeader == "" {
			sendServerError(w, http.StatusUnauthorized, "missing Authorization header")
			return
		}

		tokenString := strings.TrimPrefix(authHeader, "Bearer ")
		if tokenString == authHeader {
			sendServerError(w, http.StatusBadRequest, "invalid Authorization header format")
			return
		}

		// Parse the JWT
		//openIDConfigURL := "https://sso.uds.dev/realms/uds/.well-known/openid-configuration"

		// Fetch the OpenID configuration
		resp, err := http.Get(s.WellKnownConfigUrl)
		if err != nil || resp.StatusCode != http.StatusOK {
			sendServerError(w, http.StatusInternalServerError, fmt.Sprintf("failed to fetch OpenID configuration: %v", err))
			return
		}
		defer func(Body io.ReadCloser) {
			_ = Body.Close()
		}(resp.Body)

		var openIDConfig struct {
			JwksURI string `json:"jwks_uri"`
		}

		// Decode the OpenID configuration
		if err := json.NewDecoder(resp.Body).Decode(&openIDConfig); err != nil {
			sendServerError(w, http.StatusInternalServerError, fmt.Sprintf("failed to decode OpenID configuration: %v", err))
			return
		}

		jwks, err := keyfunc.NewDefault([]string{openIDConfig.JwksURI})
		if err != nil {
			sendServerError(w, http.StatusInternalServerError, fmt.Sprintf("Failed to create JWK Set from resource at the given URL.\nError: %s", err))
			return
		}

		token, err := jwt.Parse(tokenString, jwks.Keyfunc)
		//token, err := jwt.Parse(tokenString, jwks.Keyfunc, jwt.WithIssuedAt(), jwt.WithAudience(audience), jwt.WithIssuer())
		if err != nil || !token.Valid {
			sendServerError(w, http.StatusUnauthorized, "invalid token")
			return
		}

		// Extract claims
		claims, ok := token.Claims.(jwt.MapClaims)
		if !ok {
			sendServerError(w, http.StatusUnauthorized, "unable to parse token claims")
			return
		}

		clientID, ok := claims["client_id"].(string)
		if !ok || clientID == "" {
			sendServerError(w, http.StatusBadRequest, "client_id claim is missing in token")
			return
		}

		// Set objectPrefix based on client_id
		objectPrefix = fmt.Sprintf("%s/files/", clientID)
	}

	// List objects in the bucket with the specified prefix
	input := &s3.ListObjectsV2Input{
		Bucket: aws.String(s.BucketName),
		Prefix: aws.String(objectPrefix),
	}
	output, err := s.S3Client.ListObjectsV2(context.TODO(), input)
	if err != nil {
		sendServerError(w, http.StatusInternalServerError, fmt.Sprintf("failed to list files: %v", err))
		return
	}

	// Transform S3 objects to WfapiFileMetadata
	var files []WfapiFileMetadata
	for _, obj := range output.Contents {
		files = append(files, WfapiFileMetadata{
			FileName: *obj.Key,
			Size:     *obj.Size,
			LastModified: func() time.Time {
				if obj.LastModified != nil {
					return *obj.LastModified
				}
				return time.Time{}
			}(),
		})
	}

	// Write JSON response
	w.Header().Set("Content-Type", "application/json")
	w.WriteHeader(http.StatusOK)
	if err := json.NewEncoder(w).Encode(files); err != nil {
		sendServerError(w, http.StatusInternalServerError, fmt.Sprintf("failed to encode files response: %v", err))
		return
	}
}

// DownloadWorkflowFile implements GET /api/v1/workflows/files/{fullFileName} - Download File
func (s Server) DownloadWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

// DeleteWorkflowFile implements DELETE /api/v1/workflows/files/{fullFileName} - Delete File
func (s Server) DeleteWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

//endregion

// region Workflows

// UploadWorkflowFile implements POST /api/v1/workflows/files - Upload File
func (s Server) UploadWorkflowFile(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

// SubmitWorkflow implements POST /api/v1/workflows - Submit Workflow
func (s Server) SubmitWorkflow(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

// GetWorkflowInfo implements GET /api/v1/workflows/{workflowName} - Get Workflow Info
func (s Server) GetWorkflowInfo(w http.ResponseWriter, r *http.Request, workflowName string) {
	//TODO implement me
	panic("implement me")
}

// GetWorkflowLogStreamAsSse implements GET /api/v1/workflows/{workflowName}/pods/{podName}/logstream - Get Workflow Log Stream
func (s Server) GetWorkflowLogStreamAsSse(w http.ResponseWriter, r *http.Request, workflowName string, podName string) {
	//TODO implement me
	panic("implement me")
}

//endregion

//region Docs

// GetSwaggerUi implements GET /swagger - Swagger UI
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
    		router="hash"
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

//endregion
