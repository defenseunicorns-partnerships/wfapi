{{/*
Expand the name of the chart.
*/}}
{{- define "wfapi.name" -}}
{{- default .Chart.Name .Values.wfapi.nameOverride | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Create a default fully qualified app name.
We truncate at 63 chars because some Kubernetes name fields are limited to this (by the DNS naming spec).
If release name contains chart name it will be used as a full name.
*/}}
{{- define "wfapi.fullname" -}}
{{- if .Values.wfapi.fullnameOverride }}
{{- .Values.wfapi.fullnameOverride | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- $name := default .Chart.Name .Values.wfapi.nameOverride }}
{{- if contains $name .Release.Name }}
{{- .Release.Name | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- printf "%s-%s" .Release.Name $name | trunc 63 | trimSuffix "-" }}
{{- end }}
{{- end }}
{{- end }}

{{/*
Create chart name and version as used by the chart label.
*/}}
{{- define "wfapi.chart" -}}
{{- printf "%s-%s" .Chart.Name .Chart.Version | replace "+" "_" | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Common labels
*/}}
{{- define "wfapi.labels" -}}
helm.sh/chart: {{ include "wfapi.chart" . }}
{{ include "wfapi.selectorLabels" . }}
{{- if .Chart.AppVersion }}
app.kubernetes.io/version: {{ .Chart.AppVersion | quote }}
{{- end }}
app.kubernetes.io/managed-by: {{ .Release.Service }}
{{- end }}

{{/*
Selector labels
*/}}
{{- define "wfapi.selectorLabels" -}}
app.kubernetes.io/name: {{ include "wfapi.name" . }}
app.kubernetes.io/instance: {{ .Release.Name }}
{{- end }}

{{/*
Create the name of the service account to use
*/}}
{{- define "wfapi.serviceAccountName" -}}
{{- if .Values.wfapi.serviceAccount.create }}
{{- default (include "wfapi.fullname" .) .Values.wfapi.serviceAccount.name }}
{{- else }}
{{- default "default" .Values.wfapi.serviceAccount.name }}
{{- end }}
{{- end }}
