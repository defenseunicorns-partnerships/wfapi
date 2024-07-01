# type Schema

```txt
values.yaml#/properties/wfapi/properties/service/properties/type
```

Kubernetes service type

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## type Type

`string` ([type](values-properties-wfapi-properties-service-properties-type.md))

## type Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value            | Explanation |
| :--------------- | :---------- |
| `"ClusterIP"`    |             |
| `"NodePort"`     |             |
| `"LoadBalancer"` |             |
| `"ExternalName"` |             |

## type Default Value

The default value is:

```json
"ClusterIP"
```
