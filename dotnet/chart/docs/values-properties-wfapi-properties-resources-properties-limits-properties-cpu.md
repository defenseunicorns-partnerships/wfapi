# cpu Schema

```txt
values.yaml#/properties/wfapi/properties/resources/properties/limits/properties/cpu
```

CPU limit. See <https://home.robusta.dev/blog/stop-using-cpu-limits>. The default is some arbitrarily high number that should be impossible to hit.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## cpu Type

`string` ([cpu](values-properties-wfapi-properties-resources-properties-limits-properties-cpu.md))

## cpu Default Value

The default value is:

```json
"100"
```
