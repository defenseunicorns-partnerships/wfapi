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

| Property                                                                | Type     | Required | Nullable       | Defined by                                                                                                                                                                                    |
| :---------------------------------------------------------------------- | :------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [ASPNETCORE\_ENVIRONMENT](#aspnetcore_environment)                      | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-aspnetcore_environment.md "values.yaml#/properties/wfapi/properties/env/properties/ASPNETCORE_ENVIRONMENT")                   |
| [AWS\_ACCESS\_KEY\_ID](#aws_access_key_id)                              | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-aws_access_key_id.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_ACCESS_KEY_ID")                             |
| [AWS\_SECRET\_ACCESS\_KEY](#aws_secret_access_key)                      | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-aws_secret_access_key.md "values.yaml#/properties/wfapi/properties/env/properties/AWS_SECRET_ACCESS_KEY")                     |
| [Argo\_\_ApiUrl](#argo__apiurl)                                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__apiurl.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__ApiUrl")                                       |
| [Argo\_\_Namespace](#argo__namespace)                                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__namespace.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Namespace")                                 |
| [Argo\_\_Token](#argo__token)                                           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__token.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Token")                                         |
| [Auth\_\_Jwt\_\_Audience](#auth__jwt__audience)                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Audience")                         |
| [Auth\_\_Jwt\_\_Authority](#auth__jwt__authority)                       | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Authority")                       |
| [Auth\_\_Jwt\_\_RequireHttpsMetadata](#auth__jwt__requirehttpsmetadata) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__RequireHttpsMetadata") |
| [Auth\_\_Jwt\_\_Token](#auth__jwt__token)                               | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__token.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Token")                               |
| [Auth\_\_Jwt\_\_ValidateIssuer](#auth__jwt__validateissuer)             | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__ValidateIssuer")             |
| [Auth\_\_Jwt\_\_WellKnownConfig](#auth__jwt__wellknownconfig)           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__wellknownconfig.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__WellKnownConfig")           |
| [Auth\_\_Server\_\_ClientId](#auth__server__clientid)                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__server__clientid.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Server__ClientId")                   |
| [Auth\_\_Server\_\_ClientSecret](#auth__server__clientsecret)           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__server__clientsecret.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Server__ClientSecret")           |
| [Bucket\_\_Name](#bucket__name)                                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-bucket__name.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__Name")                                       |
| [Bucket\_\_Region](#bucket__region)                                     | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-bucket__region.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__Region")                                   |
| [Bucket\_\_ServiceUrl](#bucket__serviceurl)                             | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-bucket__serviceurl.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__ServiceUrl")                           |
| [Serilog\_\_MinimumLevel\_\_Default](#serilog__minimumlevel__default)   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-serilog__minimumlevel__default.md "values.yaml#/properties/wfapi/properties/env/properties/Serilog__MinimumLevel__Default")   |
| [Swagger\_\_Enable](#swagger__enable)                                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-swagger__enable.md "values.yaml#/properties/wfapi/properties/env/properties/Swagger__Enable")                                 |

## ASPNETCORE\_ENVIRONMENT

ASP.NET Core environment. If "Development", all JWT auth will be disabled

`ASPNETCORE_ENVIRONMENT`

* is required

* Type: `string` ([ASPNETCORE\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-aspnetcore_environment.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-aspnetcore_environment.md "values.yaml#/properties/wfapi/properties/env/properties/ASPNETCORE_ENVIRONMENT")

### ASPNETCORE\_ENVIRONMENT Type

`string` ([ASPNETCORE\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-aspnetcore_environment.md))

### ASPNETCORE\_ENVIRONMENT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value           | Explanation |
| :-------------- | :---------- |
| `"Development"` |             |
| `"Production"`  |             |
| `"Test"`        |             |

### ASPNETCORE\_ENVIRONMENT Default Value

The default value is:

```json
"Production"
```

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
"http://argo-workflows-server.argo.svc.cluster.local:2746"
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

## Auth\_\_Jwt\_\_Token

Token endpoint to get client credentials

`Auth__Jwt__Token`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_Token](values-properties-wfapi-properties-env-properties-auth__jwt__token.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__token.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Token")

### Auth\_\_Jwt\_\_Token Type

`string` ([Auth\_\_Jwt\_\_Token](values-properties-wfapi-properties-env-properties-auth__jwt__token.md))

### Auth\_\_Jwt\_\_Token Default Value

The default value is:

```json
"https://sso.uds.dev/realms/uds/protocol/openid-connect/token"
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

## Auth\_\_Jwt\_\_WellKnownConfig

Well-known configuration URL for the JWT issuer

`Auth__Jwt__WellKnownConfig`

* is required

* Type: `string` ([Auth\_\_Jwt\_\_WellKnownConfig](values-properties-wfapi-properties-env-properties-auth__jwt__wellknownconfig.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__wellknownconfig.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__WellKnownConfig")

### Auth\_\_Jwt\_\_WellKnownConfig Type

`string` ([Auth\_\_Jwt\_\_WellKnownConfig](values-properties-wfapi-properties-env-properties-auth__jwt__wellknownconfig.md))

### Auth\_\_Jwt\_\_WellKnownConfig Default Value

The default value is:

```json
"https://sso.uds.dev/realms/uds/.well-known/openid-configuration"
```

## Auth\_\_Server\_\_ClientId

ClientId for the argo server api serviceaccount

`Auth__Server__ClientId`

* is required

* Type: `string`

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__server__clientid.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Server__ClientId")

### Auth\_\_Server\_\_ClientId Type

`string`

### Auth\_\_Server\_\_ClientId Default Value

The default value is:

```json
"argo-client"
```

## Auth\_\_Server\_\_ClientSecret

ClientSecret for the argo server api serviceaccount

`Auth__Server__ClientSecret`

* is required

* Type: `string`

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-auth__server__clientsecret.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Server__ClientSecret")

### Auth\_\_Server\_\_ClientSecret Type

`string`

### Auth\_\_Server\_\_ClientSecret Default Value

The default value is:

```json
"secret"
```

## Bucket\_\_Name

Bucket name

`Bucket__Name`

* is required

* Type: `string` ([Bucket\_\_Name](values-properties-wfapi-properties-env-properties-bucket__name.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-bucket__name.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__Name")

### Bucket\_\_Name Type

`string` ([Bucket\_\_Name](values-properties-wfapi-properties-env-properties-bucket__name.md))

### Bucket\_\_Name Default Value

The default value is:

```json
"argo"
```

## Bucket\_\_Region

Bucket region

`Bucket__Region`

* is required

* Type: `string` ([Bucket\_\_Region](values-properties-wfapi-properties-env-properties-bucket__region.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-bucket__region.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__Region")

### Bucket\_\_Region Type

`string` ([Bucket\_\_Region](values-properties-wfapi-properties-env-properties-bucket__region.md))

### Bucket\_\_Region Default Value

The default value is:

```json
"minio"
```

## Bucket\_\_ServiceUrl

Bucket service URL

`Bucket__ServiceUrl`

* is required

* Type: `string` ([Bucket\_\_ServiceUrl](values-properties-wfapi-properties-env-properties-bucket__serviceurl.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-bucket__serviceurl.md "values.yaml#/properties/wfapi/properties/env/properties/Bucket__ServiceUrl")

### Bucket\_\_ServiceUrl Type

`string` ([Bucket\_\_ServiceUrl](values-properties-wfapi-properties-env-properties-bucket__serviceurl.md))

### Bucket\_\_ServiceUrl Default Value

The default value is:

```json
"http://minio.uds-dev-stack.svc.cluster.local:9000"
```

## Serilog\_\_MinimumLevel\_\_Default

Serilog minimum log level

`Serilog__MinimumLevel__Default`

* is required

* Type: `string` ([Serilog\_\_MinimumLevel\_\_Default](values-properties-wfapi-properties-env-properties-serilog__minimumlevel__default.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-env-properties-serilog__minimumlevel__default.md "values.yaml#/properties/wfapi/properties/env/properties/Serilog__MinimumLevel__Default")

### Serilog\_\_MinimumLevel\_\_Default Type

`string` ([Serilog\_\_MinimumLevel\_\_Default](values-properties-wfapi-properties-env-properties-serilog__minimumlevel__default.md))

### Serilog\_\_MinimumLevel\_\_Default Default Value

The default value is:

```json
"Information"
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
