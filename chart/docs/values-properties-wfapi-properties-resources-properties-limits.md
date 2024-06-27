# limits Schema

```txt
values.yaml#/properties/wfapi/properties/resources/properties/limits
```

Resource limits

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## limits Type

`object` ([limits](values-properties-wfapi-properties-resources-properties-limits.md))

# limits Properties

| Property          | Type     | Required | Nullable       | Defined by                                                                                                                                                                                  |
| :---------------- | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [cpu](#cpu)       | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-limits-properties-cpu.md "values.yaml#/properties/wfapi/properties/resources/properties/limits/properties/cpu")       |
| [memory](#memory) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-limits-properties-memory.md "values.yaml#/properties/wfapi/properties/resources/properties/limits/properties/memory") |

## cpu

CPU limit. See <https://home.robusta.dev/blog/stop-using-cpu-limits>. The default is some arbitrarily high number that should be impossible to hit.

`cpu`

* is required

* Type: `string` ([cpu](values-properties-wfapi-properties-resources-properties-limits-properties-cpu.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-limits-properties-cpu.md "values.yaml#/properties/wfapi/properties/resources/properties/limits/properties/cpu")

### cpu Type

`string` ([cpu](values-properties-wfapi-properties-resources-properties-limits-properties-cpu.md))

### cpu Default Value

The default value is:

```json
"100"
```

## memory

Memory limit

`memory`

* is required

* Type: `string` ([memory](values-properties-wfapi-properties-resources-properties-limits-properties-memory.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-limits-properties-memory.md "values.yaml#/properties/wfapi/properties/resources/properties/limits/properties/memory")

### memory Type

`string` ([memory](values-properties-wfapi-properties-resources-properties-limits-properties-memory.md))

### memory Default Value

The default value is:

```json
"128Mi"
```
