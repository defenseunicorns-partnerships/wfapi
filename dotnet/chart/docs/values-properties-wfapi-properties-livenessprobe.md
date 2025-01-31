# livenessProbe Schema

```txt
values.yaml#/properties/wfapi/properties/livenessProbe
```

Liveness probe settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## livenessProbe Type

`object` ([livenessProbe](values-properties-wfapi-properties-livenessprobe.md))

# livenessProbe Properties

| Property            | Type     | Required | Nullable       | Defined by                                                                                                                                                        |
| :------------------ | :------- | :------- | :------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [httpGet](#httpget) | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet") |

## httpGet

HTTP Get probe settings

`httpGet`

* is required

* Type: `object` ([httpGet](values-properties-wfapi-properties-livenessprobe-properties-httpget.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-livenessprobe-properties-httpget.md "values.yaml#/properties/wfapi/properties/livenessProbe/properties/httpGet")

### httpGet Type

`object` ([httpGet](values-properties-wfapi-properties-livenessprobe-properties-httpget.md))
