# sysctls Schema

```txt
values.yaml#/properties/wfapi/properties/podSecurityContext/properties/sysctls
```

Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls (by the container runtime) might fail to launch.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## sysctls Type

`array` ([sysctls](values-properties-wfapi-properties-podsecuritycontext-properties-sysctls.md))

## sysctls Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## sysctls Default Value

The default value is:

```json
[]
```
