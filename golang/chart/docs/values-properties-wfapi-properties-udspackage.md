# udsPackage Schema

```txt
values.yaml#/properties/wfapi/properties/udsPackage
```

UDS package settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## udsPackage Type

`object` ([udsPackage](values-properties-wfapi-properties-udspackage.md))

# udsPackage Properties

| Property                    | Type      | Required | Nullable       | Defined by                                                                                                                                                          |
| :-------------------------- | :-------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [enabled](#enabled)         | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-udspackage-properties-enabled.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/enabled")         |
| [expose](#expose)           | `object`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-udspackage-properties-expose.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/expose")           |
| [redirectURI](#redirecturi) | `string`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-udspackage-properties-redirecturi.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/redirectURI") |

## enabled

Specifies whether the UDS package should be enabled

`enabled`

* is required

* Type: `boolean` ([enabled](values-properties-wfapi-properties-udspackage-properties-enabled.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-udspackage-properties-enabled.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/enabled")

### enabled Type

`boolean` ([enabled](values-properties-wfapi-properties-udspackage-properties-enabled.md))

### enabled Default Value

The default value is:

```json
true
```

## expose

Expose settings

`expose`

* is required

* Type: `object` ([expose](values-properties-wfapi-properties-udspackage-properties-expose.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-udspackage-properties-expose.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/expose")

### expose Type

`object` ([expose](values-properties-wfapi-properties-udspackage-properties-expose.md))

## redirectURI

Redirect URI for Keycloak client

`redirectURI`

* is required

* Type: `string` ([redirectURI](values-properties-wfapi-properties-udspackage-properties-redirecturi.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-udspackage-properties-redirecturi.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/redirectURI")

### redirectURI Type

`string` ([redirectURI](values-properties-wfapi-properties-udspackage-properties-redirecturi.md))

### redirectURI Default Value

The default value is:

```json
"https://wfapi.uds.dev/auth"
```
