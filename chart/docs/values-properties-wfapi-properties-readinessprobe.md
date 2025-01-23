# readinessProbe Schema

```txt
values.yaml#/properties/wfapi/properties/readinessProbe
```

Readiness probe settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## readinessProbe Type

`object` ([readinessProbe](values-properties-wfapi-properties-readinessprobe.md))

# readinessProbe Properties

| Property            | Type     | Required | Nullable       | Defined by                                                                                                                                                          |
| :------------------ | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [httpGet](#httpget) | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-readinessprobe-properties-httpget.md "values.yaml#/properties/wfapi/properties/readinessProbe/properties/httpGet") |

## httpGet

HTTP Get probe settings

`httpGet`

* is required

* Type: `object` ([httpGet](values-properties-wfapi-properties-readinessprobe-properties-httpget.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-readinessprobe-properties-httpget.md "values.yaml#/properties/wfapi/properties/readinessProbe/properties/httpGet")

### httpGet Type

`object` ([httpGet](values-properties-wfapi-properties-readinessprobe-properties-httpget.md))
