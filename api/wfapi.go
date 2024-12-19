package api

import (
	"encoding/json"
	"net/http"
)

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

func (s Server) SubmitWorkflow(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

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
