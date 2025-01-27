# volumes Schema

```txt
values.yaml#/properties/wfapi/properties/volumes
```

Additional volumes on the output Deployment definition. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#volumes>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## volumes Type

`array` ([volumes](values-properties-wfapi-properties-volumes.md))

## volumes Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## volumes Default Value

The default value is:

```json
[]
```
