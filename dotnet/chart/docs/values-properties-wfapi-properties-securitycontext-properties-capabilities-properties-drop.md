# drop Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities/properties/drop
```

Dropped capabilities

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## drop Type

`string[]`

## drop Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## drop Default Value

The default value is:

```json
[
  "ALL"
]
```
