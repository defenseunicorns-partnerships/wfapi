# env Schema

```txt
values.yaml#/properties/wfapi/properties/env
```

Environment variables to set in the container. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#environment-variables>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## env Type

`object` ([env](values-properties-wfapi-properties-env.md))

# env Properties

| Property                                                                     | Type     | Required | Nullable       | Defined by                                                                                                                                                                                        |
| :--------------------------------------------------------------------------- | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [AWS\_ACCESS\_KEY\_ID](#aws_access_key_id)                                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-aws_access_key_id.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_ACCESS_KEY_ID")                                 |
| [AWS\_SECRET\_ACCESS\_KEY](#aws_secret_access_key)                           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-aws_secret_access_key.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_SECRET_ACCESS_KEY")                         |
| [Argo\_\_ApiUrl](#argo__apiurl)                                              | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__apiurl.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__ApiUrl")                                           |
| [Argo\_\_Namespace](#argo__namespace)                                        | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__namespace.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Namespace")                                     |
| [Argo\_\_Token](#argo__token)                                                | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__token.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Token")                                             |
| [Auth\_\_Jwt\_\_Audience](#auth__jwt__audience)                              | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Audience")                             |
| [Auth\_\_Jwt\_\_Authority](#auth__jwt__authority)                            | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Authority")                           |
| [Auth\_\_Jwt\_\_RequireHttpsMetadata](#auth__jwt__requirehttpsmetadata)      | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__RequireHttpsMetadata")     |
| [Auth\_\_Jwt\_\_ValidateIssuer](#auth__jwt__validateissuer)                  | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__ValidateIssuer")                 |
| [Swagger\_\_Enable](#swagger__enable)                                        | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-swagger__enable.md "values.yaml#/properties/wfapi/properties/env/properties/Swagger__Enable")                                     |
| [WFAPI\_ENVIRONMENT](#wfapi_environment)                                     | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_environment.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_ENVIRONMENT")                                 |
| [WFAPI\_LOG\_FORMAT](#wfapi_log_format)                                      | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_log_format.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_FORMAT")                                   |
| [WFAPI\_LOG\_LEVEL](#wfapi_log_level)                                        | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_log_level.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_LEVEL")                                     |
| [WFAPI\_SERVE\_BUCKET\_NAME](#wfapi_serve_bucket_name)                       | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_name.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_NAME")                     |
| [WFAPI\_SERVE\_BUCKET\_REGION](#wfapi_serve_bucket_region)                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_region.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_REGION")                 |
| [WFAPI\_SERVE\_BUCKET\_SERVICE\_URL](#wfapi_serve_bucket_service_url)        | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_service_url.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_SERVICE_URL")       |
| [WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL](#wfapi_serve_well_known_config_url) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_well_known_config_url.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_WELL_KNOWN_CONFIG_URL") |

## AWS\_ACCESS\_KEY\_ID

AWS access key ID. Leave as empty string if using IRSA

`AWS_ACCESS_KEY_ID`

* is required

* Type: `string` ([AWS\_ACCESS\_KEY\_ID](values-properties-wfapi-properties-env-properties-aws_access_key_id.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-aws_access_key_id.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_ACCESS_KEY_ID")

### AWS\_ACCESS\_KEY\_ID Type

`string` ([AWS\_ACCESS\_KEY\_ID](values-properties-wfapi-properties-env-properties-aws_access_key_id.md))

## AWS\_SECRET\_ACCESS\_KEY

AWS secret access key. Leave as empty string if using IRSA

`AWS_SECRET_ACCESS_KEY`

* is required

* Type: `string` ([AWS\_SECRET\_ACCESS\_KEY](values-properties-wfapi-properties-env-properties-aws_secret_access_key.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-aws_secret_access_key.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_SECRET_ACCESS_KEY")

### AWS\_SECRET\_ACCESS\_KEY Type

`string` ([AWS\_SECRET\_ACCESS\_KEY](values-properties-wfapi-properties-env-properties-aws_secret_access_key.md))

## Argo\_\_ApiUrl

Argo API URL

`Argo__ApiUrl`

* is required

* Type: `string` ([Argo\_\_ApiUrl](values-properties-wfapi-properties-env-properties-argo__apiurl.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-argo__apiurl.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__ApiUrl")

### Argo\_\_ApiUrl Type

`string` ([Argo\_\_ApiUrl](values-properties-wfapi-properties-env-properties-argo__apiurl.md))

### Argo\_\_ApiUrl Default Value

The default value is:

```json
"http://argo-workflows-server:2746"
```

## Argo\_\_Namespace

Namespace where workflows should be created

`Argo__Namespace`

* is required

* Type: `string` ([Argo\_\_Namespace](values-properties-wfapi-properties-env-properties-argo__namespace.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-argo__namespace.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Namespace")

### Argo\_\_Namespace Type

`string` ([Argo\_\_Namespace](values-properties-wfapi-properties-env-properties-argo__namespace.md))

### Argo\_\_Namespace Default Value

The default value is:

```json
"argo"
```

## Argo\_\_Token

Optional Argo API token. Not necessary in most cases as the app will fetch the token that is mounted to the filesystem. Leave as an empty string.

`Argo__Token`

* is required

* Type: `string` ([Argo\_\_Token](values-properties-wfapi-properties-env-properties-argo__token.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-argo__token.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Token")

### Argo\_\_Token Type

`string` ([Argo\_\_Token](values-properties-wfapi-properties-env-properties-argo__token.md))

## Auth\_\_Jwt\_\_Audience

JWT audience. Corresponds to the Keycloak client associated with this app.

`Auth__Jwt__Audience`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_Audience](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Audience")

### Auth\_\_Jwt\_\_Audience Type

`string` ([Auth\_\_Jwt\_\_Audience](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md))

### Auth\_\_Jwt\_\_Audience Default Value

The default value is:

```json
"wfapi"
```

## Auth\_\_Jwt\_\_Authority

JWT authority

`Auth__Jwt__Authority`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_Authority](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Authority")

### Auth\_\_Jwt\_\_Authority Type

`string` ([Auth\_\_Jwt\_\_Authority](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md))

### Auth\_\_Jwt\_\_Authority Default Value

The default value is:

```json
"https://sso.uds.dev/realms/uds"
```

## Auth\_\_Jwt\_\_RequireHttpsMetadata

Require HTTPS when interfacing with the IDP

`Auth__Jwt__RequireHttpsMetadata`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_RequireHttpsMetadata](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__RequireHttpsMetadata")

### Auth\_\_Jwt\_\_RequireHttpsMetadata Type

`string` ([Auth\_\_Jwt\_\_RequireHttpsMetadata](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md))

### Auth\_\_Jwt\_\_RequireHttpsMetadata Default Value

The default value is:

```json
"true"
```

## Auth\_\_Jwt\_\_ValidateIssuer

Whether to validate the JWT issuer

`Auth__Jwt__ValidateIssuer`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_ValidateIssuer](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__ValidateIssuer")

### Auth\_\_Jwt\_\_ValidateIssuer Type

`string` ([Auth\_\_Jwt\_\_ValidateIssuer](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md))

### Auth\_\_Jwt\_\_ValidateIssuer Default Value

The default value is:

```json
"true"
```

## Swagger\_\_Enable

Whether to enable Swagger. If true, the SwaggerUI can be reached at <url>/swagger

`Swagger__Enable`

* is required

* Type: `string` ([Swagger\_\_Enable](values-properties-wfapi-properties-env-properties-swagger__enable.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-swagger__enable.md "values.yaml#/properties/wfapi/properties/env/properties/Swagger__Enable")

### Swagger\_\_Enable Type

`string` ([Swagger\_\_Enable](values-properties-wfapi-properties-env-properties-swagger__enable.md))

### Swagger\_\_Enable Default Value

The default value is:

```json
"false"
```

## WFAPI\_ENVIRONMENT

Deploy environment. If "Development", all JWT auth will be disabled. If "test", a keycloak service account named "wfapi-api" will be created for testing purposes.

`WFAPI_ENVIRONMENT`

* is required

* Type: `string` ([WFAPI\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-wfapi_environment.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_environment.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_ENVIRONMENT")

### WFAPI\_ENVIRONMENT Type

`string` ([WFAPI\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-wfapi_environment.md))

### WFAPI\_ENVIRONMENT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value           | Explanation |
| :-------------- | :---------- |
| `"development"` |             |
| `"test"`        |             |
| `"production"`  |             |

### WFAPI\_ENVIRONMENT Default Value

The default value is:

```json
"production"
```

## WFAPI\_LOG\_FORMAT

Log format.

`WFAPI_LOG_FORMAT`

* is required

* Type: `string` ([WFAPI\_LOG\_FORMAT](values-properties-wfapi-properties-env-properties-wfapi_log_format.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_log_format.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_FORMAT")

### WFAPI\_LOG\_FORMAT Type

`string` ([WFAPI\_LOG\_FORMAT](values-properties-wfapi-properties-env-properties-wfapi_log_format.md))

### WFAPI\_LOG\_FORMAT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value       | Explanation |
| :---------- | :---------- |
| `"console"` |             |
| `"json"`    |             |
| `"dev"`     |             |
| `"none"`    |             |

### WFAPI\_LOG\_FORMAT Default Value

The default value is:

```json
"console"
```

## WFAPI\_LOG\_LEVEL

Log level for the application.

`WFAPI_LOG_LEVEL`

* is required

* Type: `string` ([WFAPI\_LOG\_LEVEL](values-properties-wfapi-properties-env-properties-wfapi_log_level.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_log_level.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_LEVEL")

### WFAPI\_LOG\_LEVEL Type

`string` ([WFAPI\_LOG\_LEVEL](values-properties-wfapi-properties-env-properties-wfapi_log_level.md))

### WFAPI\_LOG\_LEVEL Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value     | Explanation |
| :-------- | :---------- |
| `"debug"` |             |
| `"info"`  |             |
| `"warn"`  |             |
| `"error"` |             |

### WFAPI\_LOG\_LEVEL Default Value

The default value is:

```json
"info"
```

## WFAPI\_SERVE\_BUCKET\_NAME

Bucket name

`WFAPI_SERVE_BUCKET_NAME`

* is required

* Type: `string` ([WFAPI\_SERVE\_BUCKET\_NAME](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_name.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_name.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_NAME")

### WFAPI\_SERVE\_BUCKET\_NAME Type

`string` ([WFAPI\_SERVE\_BUCKET\_NAME](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_name.md))

### WFAPI\_SERVE\_BUCKET\_NAME Default Value

The default value is:

```json
"argo"
```

## WFAPI\_SERVE\_BUCKET\_REGION

Bucket region

`WFAPI_SERVE_BUCKET_REGION`

* is required

* Type: `string` ([WFAPI\_SERVE\_BUCKET\_REGION](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_region.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_region.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_REGION")

### WFAPI\_SERVE\_BUCKET\_REGION Type

`string` ([WFAPI\_SERVE\_BUCKET\_REGION](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_region.md))

### WFAPI\_SERVE\_BUCKET\_REGION Default Value

The default value is:

```json
"minio"
```

## WFAPI\_SERVE\_BUCKET\_SERVICE\_URL

Bucket service URL

`WFAPI_SERVE_BUCKET_SERVICE_URL`

* is required

* Type: `string` ([WFAPI\_SERVE\_BUCKET\_SERVICE\_URL](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_service_url.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_service_url.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_BUCKET_SERVICE_URL")

### WFAPI\_SERVE\_BUCKET\_SERVICE\_URL Type

`string` ([WFAPI\_SERVE\_BUCKET\_SERVICE\_URL](values-properties-wfapi-properties-env-properties-wfapi_serve_bucket_service_url.md))

### WFAPI\_SERVE\_BUCKET\_SERVICE\_URL Default Value

The default value is:

```json
"http://minio.uds-dev-stack.svc.cluster.local:9000"
```

## WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL

Well-known configuration URL for the JWT issuer

`WFAPI_SERVE_WELL_KNOWN_CONFIG_URL`

* is required

* Type: `string` ([WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL](values-properties-wfapi-properties-env-properties-wfapi_serve_well_known_config_url.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-wfapi_serve_well_known_config_url.md "values.yaml#/properties/wfapi/properties/env/properties/WFAPI_SERVE_WELL_KNOWN_CONFIG_URL")

### WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL Type

`string` ([WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL](values-properties-wfapi-properties-env-properties-wfapi_serve_well_known_config_url.md))

### WFAPI\_SERVE\_WELL\_KNOWN\_CONFIG\_URL Default Value

The default value is:

```json
"https://sso.uds.dev/realms/uds/.well-known/openid-configuration"
```
