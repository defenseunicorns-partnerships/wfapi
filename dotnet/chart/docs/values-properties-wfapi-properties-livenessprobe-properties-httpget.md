# httpGet Schema

```txt
values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet
```

HTTP Get probe settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## httpGet Type

`object` ([httpGet](values-properties-wfapi-properties-livenessprobe-properties-httpget.md))

# httpGet Properties

| Property      | Type     | Required | Nullable       | Defined by                                                                                                                                                                                        |
| :------------ | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [path](#path) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-path.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet/properties/path") |
| [port](#port) | `number` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-port.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet/properties/port") |

## path

Path to probe

`path`

* is required

* Type: `string` ([path](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-path.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-path.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet/properties/path")

### path Type

`string` ([path](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-path.md))

### path Default Value

The default value is:

```json
"/healthz"
```

## port

Port to probe

`port`

* is required

* Type: `number` ([port](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-port.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-port.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet/properties/port")

### port Type

`number` ([port](values-properties-wfapi-properties-livenessprobe-properties-httpget-properties-port.md))

### port Default Value

The default value is:

```json
8080
```
