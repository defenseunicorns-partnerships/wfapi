# ASPNETCORE\_ENVIRONMENT Schema

```txt
values.yaml#/properties/wfapi/properties/env/properties/ASPNETCORE_ENVIRONMENT
```

ASP.NET Core environment. If "Development", all JWT auth will be disabled

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## ASPNETCORE\_ENVIRONMENT Type

`string` ([ASPNETCORE\_ENVIRONMENT](values-properties-wfapi-properties-env-properties-aspnetcore_environment.md))

## ASPNETCORE\_ENVIRONMENT Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value           | Explanation |
| :-------------- | :---------- |
| `"Development"` |             |
| `"Production"`  |             |
| `"Test"`        |             |

## ASPNETCORE\_ENVIRONMENT Default Value

The default value is:

```json
"Production"
```
