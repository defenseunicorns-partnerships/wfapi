# WFAPI\_LOG\_LEVEL Schema

```txt
values.yaml#/properties/wfapi/properties/env/properties/WFAPI_LOG_LEVEL
```

Log level for the application.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## WFAPI\_LOG\_LEVEL Type

`string` ([WFAPI\_LOG\_LEVEL](values-properties-wfapi-properties-env-properties-wfapi_log_level.md))

## WFAPI\_LOG\_LEVEL Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value     | Explanation |
| :-------- | :---------- |
| `"debug"` |             |
| `"info"`  |             |
| `"warn"`  |             |
| `"error"` |             |

## WFAPI\_LOG\_LEVEL Default Value

The default value is:

```json
"info"
```
