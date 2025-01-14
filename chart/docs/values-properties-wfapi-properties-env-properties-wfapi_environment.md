# WFAPI\_ENVIRONMENT Schema

```txt
values.yaml#/properties/wfapi/properties/env/properties/WFAPI_ENVIRONMENT
```

Deploy environment. If "Development", all JWT auth will be disabled. If "test", a keycloak service account named "wfapi-api" will be created for testing purposes.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## WFAPI\_ENVIRONMENT Type

`string` ([WFAPI\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-wfapi_environment.md))

## WFAPI\_ENVIRONMENT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value           | Explanation |
| :-------------- | :---------- |
| `"development"` |             |
| `"test"`        |             |
| `"production"`  |             |

## WFAPI\_ENVIRONMENT Default Value

The default value is:

```json
"production"
```
