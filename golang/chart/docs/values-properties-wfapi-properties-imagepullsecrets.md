# imagePullSecrets Schema

```txt
values.yaml#/properties/wfapi/properties/imagePullSecrets
```

Image pull secrets. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#PodSpec:~:text=pod%27s%20ephemeralcontainers%20subresource.-,imagePullSecrets,-(%5B%5DLocalObjectReference)>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## imagePullSecrets Type

`array` ([imagePullSecrets](values-properties-wfapi-properties-imagepullsecrets.md))

## imagePullSecrets Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## imagePullSecrets Default Value

The default value is:

```json
[]
```
