package api

import (
	"encoding/json"
	"net/http"
)

type WorkflowApi struct {
}

// Make sure we conform to ServerInterface
var _ ServerInterface = (*WorkflowApi)(nil)

func NewWorkflowApi() *WorkflowApi {
	return &WorkflowApi{}
}

// sendWorkflowApiError wraps sending of an error in the Error format, and handling the failure to marshal that.
func sendWorkflowApiError(w http.ResponseWriter, code int, message string) {
	wfapiErr := Error{
		Code:    int32(code),
		Message: message,
	}
	w.WriteHeader(code)
	_ = json.NewEncoder(w).Encode(wfapiErr)
}

func (w2 WorkflowApi) SubmitWorkflow(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) GetWorkflowFiles(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) UploadWorkflowFile(w http.ResponseWriter, r *http.Request) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) DeleteWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) DownloadWorkflowFile(w http.ResponseWriter, r *http.Request, fullFileName string) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) GetApiV1WorkflowsWorkflowName(w http.ResponseWriter, r *http.Request, workflowName string) {
	//TODO implement me
	panic("implement me")
}

func (w2 WorkflowApi) GetApiV1WorkflowsWorkflowNamePodsPodNameLogstream(w http.ResponseWriter, r *http.Request, workflowName string, podName string) {
	//TODO implement me
	panic("implement me")
}
