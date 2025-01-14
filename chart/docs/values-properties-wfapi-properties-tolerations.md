# tolerations Schema

```txt
values.yaml#/properties/wfapi/properties/tolerations
```

Tolerations for pod assignment. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#scheduling>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## tolerations Type

`array` ([tolerations](values-properties-wfapi-properties-tolerations.md))

## tolerations Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## tolerations Default Value

The default value is:

```json
[]
```
