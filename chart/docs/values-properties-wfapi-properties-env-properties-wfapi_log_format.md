# WFAPI\_LOG\_FORMAT Schema

```txt
values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_FORMAT
```

Log format.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## WFAPI\_LOG\_FORMAT Type

`string` ([WFAPI\_LOG\_FORMAT](values-properties-wfapi-properties-env-properties-wfapi_log_format.md))

## WFAPI\_LOG\_FORMAT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value       | Explanation |
| :---------- | :---------- |
| `"console"` |             |
| `"json"`    |             |
| `"dev"`     |             |
| `"none"`    |             |

## WFAPI\_LOG\_FORMAT Default Value

The default value is:

```json
"console"
```
