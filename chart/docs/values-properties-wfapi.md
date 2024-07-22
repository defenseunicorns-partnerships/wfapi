# wfapi Schema

```txt
values.yaml#/properties/wfapi
```

wfapi chart settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## wfapi Type

`object` ([wfapi](values-properties-wfapi.md))

# wfapi Properties

| Property                                  | Type     | Required | Nullable       | Defined by                                                                                                                            |
| :---------------------------------------- | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------ |
| [affinity](#affinity)                     | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-affinity.md "values.yaml#/properties/wfapi/properties/affinity")                     |
| [env](#env)                               | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env.md "values.yaml#/properties/wfapi/properties/env")                               |
| [fullnameOverride](#fullnameoverride)     | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-fullnameoverride.md "values.yaml#/properties/wfapi/properties/fullnameOverride")     |
| [image](#image)                           | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-image.md "values.yaml#/properties/wfapi/properties/image")                           |
| [imagePullSecrets](#imagepullsecrets)     | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-imagepullsecrets.md "values.yaml#/properties/wfapi/properties/imagePullSecrets")     |
| [livenessProbe](#livenessprobe)           | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-livenessprobe.md "values.yaml#/properties/wfapi/properties/livenessProbe")           |
| [nameOverride](#nameoverride)             | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-nameoverride.md "values.yaml#/properties/wfapi/properties/nameOverride")             |
| [nodeSelector](#nodeselector)             | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-nodeselector.md "values.yaml#/properties/wfapi/properties/nodeSelector")             |
| [podAnnotations](#podannotations)         | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podannotations.md "values.yaml#/properties/wfapi/properties/podAnnotations")         |
| [podLabels](#podlabels)                   | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podlabels.md "values.yaml#/properties/wfapi/properties/podLabels")                   |
| [podSecurityContext](#podsecuritycontext) | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podsecuritycontext.md "values.yaml#/properties/wfapi/properties/podSecurityContext") |
| [readinessProbe](#readinessprobe)         | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-readinessprobe.md "values.yaml#/properties/wfapi/properties/readinessProbe")         |
| [replicaCount](#replicacount)             | `number` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-replicacount.md "values.yaml#/properties/wfapi/properties/replicaCount")             |
| [resources](#resources)                   | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources.md "values.yaml#/properties/wfapi/properties/resources")                   |
| [roleBinding](#rolebinding)               | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-rolebinding.md "values.yaml#/properties/wfapi/properties/roleBinding")               |
| [securityContext](#securitycontext)       | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext.md "values.yaml#/properties/wfapi/properties/securityContext")       |
| [service](#service)                       | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-service.md "values.yaml#/properties/wfapi/properties/service")                       |
| [serviceAccount](#serviceaccount)         | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-serviceaccount.md "values.yaml#/properties/wfapi/properties/serviceAccount")         |
| [startupProbe](#startupprobe)             | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-startupprobe.md "values.yaml#/properties/wfapi/properties/startupProbe")             |
| [tolerations](#tolerations)               | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-tolerations.md "values.yaml#/properties/wfapi/properties/tolerations")               |
| [volumeMounts](#volumemounts)             | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-volumemounts.md "values.yaml#/properties/wfapi/properties/volumeMounts")             |
| [volumes](#volumes)                       | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-volumes.md "values.yaml#/properties/wfapi/properties/volumes")                       |

## affinity

Affinity for pod assignment. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#scheduling>

`affinity`

* is required

* Type: `object` ([affinity](values-properties-wfapi-properties-affinity.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-affinity.md "values.yaml#/properties/wfapi/properties/affinity")

### affinity Type

`object` ([affinity](values-properties-wfapi-properties-affinity.md))

### affinity Default Value

The default value is:

```json
{}
```

## env

Environment variables to set in the container. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#environment-variables>

`env`

* is required

* Type: `object` ([env](values-properties-wfapi-properties-env.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env.md "values.yaml#/properties/wfapi/properties/env")

### env Type

`object` ([env](values-properties-wfapi-properties-env.md))

## fullnameOverride

String to fully override wfapi.fullname template with a string. Default is ""

`fullnameOverride`

* is required

* Type: `string` ([fullnameOverride](values-properties-wfapi-properties-fullnameoverride.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-fullnameoverride.md "values.yaml#/properties/wfapi/properties/fullnameOverride")

### fullnameOverride Type

`string` ([fullnameOverride](values-properties-wfapi-properties-fullnameoverride.md))

## image

Container image settings

`image`

* is required

* Type: `object` ([image](values-properties-wfapi-properties-image.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-image.md "values.yaml#/properties/wfapi/properties/image")

### image Type

`object` ([image](values-properties-wfapi-properties-image.md))

## imagePullSecrets

Image pull secrets. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#PodSpec:~:text=pod%27s%20ephemeralcontainers%20subresource.-,imagePullSecrets,-(%5B%5DLocalObjectReference)>

`imagePullSecrets`

* is required

* Type: `array` ([imagePullSecrets](values-properties-wfapi-properties-imagepullsecrets.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-imagepullsecrets.md "values.yaml#/properties/wfapi/properties/imagePullSecrets")

### imagePullSecrets Type

`array` ([imagePullSecrets](values-properties-wfapi-properties-imagepullsecrets.md))

### imagePullSecrets Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### imagePullSecrets Default Value

The default value is:

```json
[]
```

## livenessProbe

Liveness probe settings

`livenessProbe`

* is required

* Type: `object` ([livenessProbe](values-properties-wfapi-properties-livenessprobe.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-livenessprobe.md "values.yaml#/properties/wfapi/properties/livenessProbe")

### livenessProbe Type

`object` ([livenessProbe](values-properties-wfapi-properties-livenessprobe.md))

## nameOverride

String to partially override wfapi.fullname template with a string (will prepend the release name). Default is ""

`nameOverride`

* is required

* Type: `string` ([nameOverride](values-properties-wfapi-properties-nameoverride.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-nameoverride.md "values.yaml#/properties/wfapi/properties/nameOverride")

### nameOverride Type

`string` ([nameOverride](values-properties-wfapi-properties-nameoverride.md))

## nodeSelector

Node labels for pod assignment. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#scheduling>

`nodeSelector`

* is required

* Type: `object` ([nodeSelector](values-properties-wfapi-properties-nodeselector.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-nodeselector.md "values.yaml#/properties/wfapi/properties/nodeSelector")

### nodeSelector Type

`object` ([nodeSelector](values-properties-wfapi-properties-nodeselector.md))

### nodeSelector Default Value

The default value is:

```json
{}
```

## podAnnotations

Annotations to add to the pod. Ref: <https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/>

`podAnnotations`

* is required

* Type: `object` ([podAnnotations](values-properties-wfapi-properties-podannotations.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podannotations.md "values.yaml#/properties/wfapi/properties/podAnnotations")

### podAnnotations Type

`object` ([podAnnotations](values-properties-wfapi-properties-podannotations.md))

### podAnnotations Default Value

The default value is:

```json
{}
```

## podLabels

Labels to add to the pod. Ref: <https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/>

`podLabels`

* is required

* Type: `object` ([podLabels](values-properties-wfapi-properties-podlabels.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podlabels.md "values.yaml#/properties/wfapi/properties/podLabels")

### podLabels Type

`object` ([podLabels](values-properties-wfapi-properties-podlabels.md))

### podLabels Default Value

The default value is:

```json
{}
```

## podSecurityContext

Security context for the pod. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#security-context>

`podSecurityContext`

* is required

* Type: `object` ([podSecurityContext](values-properties-wfapi-properties-podsecuritycontext.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podsecuritycontext.md "values.yaml#/properties/wfapi/properties/podSecurityContext")

### podSecurityContext Type

`object` ([podSecurityContext](values-properties-wfapi-properties-podsecuritycontext.md))

## readinessProbe

Readiness probe settings

`readinessProbe`

* is required

* Type: `object` ([readinessProbe](values-properties-wfapi-properties-readinessprobe.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-readinessprobe.md "values.yaml#/properties/wfapi/properties/readinessProbe")

### readinessProbe Type

`object` ([readinessProbe](values-properties-wfapi-properties-readinessprobe.md))

## replicaCount

Number of replicas to deploy. Currently, '1' is the only supported value.

`replicaCount`

* is required

* Type: `number` ([replicaCount](values-properties-wfapi-properties-replicacount.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-replicacount.md "values.yaml#/properties/wfapi/properties/replicaCount")

### replicaCount Type

`number` ([replicaCount](values-properties-wfapi-properties-replicacount.md))

### replicaCount Constraints

**maximum**: the value of this number must smaller than or equal to: `1`

**minimum**: the value of this number must greater than or equal to: `1`

### replicaCount Default Value

The default value is:

```json
1
```

## resources

Resource requests and limits

`resources`

* is required

* Type: `object` ([resources](values-properties-wfapi-properties-resources.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources.md "values.yaml#/properties/wfapi/properties/resources")

### resources Type

`object` ([resources](values-properties-wfapi-properties-resources.md))

## roleBinding

Role binding settings

`roleBinding`

* is required

* Type: `object` ([roleBinding](values-properties-wfapi-properties-rolebinding.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-rolebinding.md "values.yaml#/properties/wfapi/properties/roleBinding")

### roleBinding Type

`object` ([roleBinding](values-properties-wfapi-properties-rolebinding.md))

## securityContext

SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext. When both are set, the values in SecurityContext take precedence. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#security-context-1>

`securityContext`

* is required

* Type: `object` ([securityContext](values-properties-wfapi-properties-securitycontext.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext.md "values.yaml#/properties/wfapi/properties/securityContext")

### securityContext Type

`object` ([securityContext](values-properties-wfapi-properties-securitycontext.md))

## service

Service settings

`service`

* is required

* Type: `object` ([service](values-properties-wfapi-properties-service.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-service.md "values.yaml#/properties/wfapi/properties/service")

### service Type

`object` ([service](values-properties-wfapi-properties-service.md))

## serviceAccount

Service account settings

`serviceAccount`

* is required

* Type: `object` ([serviceAccount](values-properties-wfapi-properties-serviceaccount.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-serviceaccount.md "values.yaml#/properties/wfapi/properties/serviceAccount")

### serviceAccount Type

`object` ([serviceAccount](values-properties-wfapi-properties-serviceaccount.md))

## startupProbe

Startup probe settings

`startupProbe`

* is required

* Type: `object` ([startupProbe](values-properties-wfapi-properties-startupprobe.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-startupprobe.md "values.yaml#/properties/wfapi/properties/startupProbe")

### startupProbe Type

`object` ([startupProbe](values-properties-wfapi-properties-startupprobe.md))

## tolerations

Tolerations for pod assignment. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#scheduling>

`tolerations`

* is required

* Type: `array` ([tolerations](values-properties-wfapi-properties-tolerations.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-tolerations.md "values.yaml#/properties/wfapi/properties/tolerations")

### tolerations Type

`array` ([tolerations](values-properties-wfapi-properties-tolerations.md))

### tolerations Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### tolerations Default Value

The default value is:

```json
[]
```

## volumeMounts

Additional volumeMounts on the output Deployment definition. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#volumes-1>

`volumeMounts`

* is required

* Type: `array` ([volumeMounts](values-properties-wfapi-properties-volumemounts.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-volumemounts.md "values.yaml#/properties/wfapi/properties/volumeMounts")

### volumeMounts Type

`array` ([volumeMounts](values-properties-wfapi-properties-volumemounts.md))

### volumeMounts Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### volumeMounts Default Value

The default value is:

```json
[]
```

## volumes

Additional volumes on the output Deployment definition. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#volumes>

`volumes`

* is required

* Type: `array` ([volumes](values-properties-wfapi-properties-volumes.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-volumes.md "values.yaml#/properties/wfapi/properties/volumes")

### volumes Type

`array` ([volumes](values-properties-wfapi-properties-volumes.md))

### volumes Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### volumes Default Value

The default value is:

```json
[]
```
