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
| [Argo\_\_ApiUrl](#argo__apiurl)                                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__apiurl.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__ApiUrl")                                       |
| [Argo\_\_Namespace](#argo__namespace)                                   | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__namespace.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Namespace")                                 |
| [Argo\_\_Token](#argo__token)                                           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-argo__token.md "values.yaml#/properties/wfapi/properties/env/properties/Argo__Token")                                         |
| [Auth\_\_Jwt\_\_Audience](#auth__jwt__audience)                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__audience.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Audience")                         |
| [Auth\_\_Jwt\_\_Authority](#auth__jwt__authority)                       | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__authority.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__Authority")                       |
| [Auth\_\_Jwt\_\_RequireHttpsMetadata](#auth__jwt__requirehttpsmetadata) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__requirehttpsmetadata.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__RequireHttpsMetadata") |
| [Auth\_\_Jwt\_\_ValidateIssuer](#auth__jwt__validateissuer)             | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__validateissuer.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__ValidateIssuer")             |
| [Auth\_\_Jwt\_\_WellKnownConfig](#auth__jwt__wellknownconfig)           | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-env-properties-auth__jwt__wellknownconfig.md "values.yaml#/properties/wfapi/properties/env/properties/Auth__Jwt__WellKnownConfig")           |
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

### ASPNETCORE\_ENVIRONMENT Default Value

The default value is:

```json
"Production"
```

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
