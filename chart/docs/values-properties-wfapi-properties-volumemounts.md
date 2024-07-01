# volumeMounts Schema

```txt
values.yaml#/properties/wfapi/properties/volumeMounts
```

Additional volumeMounts on the output Deployment definition. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#volumes-1>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## volumeMounts Type

`array` ([volumeMounts](values-properties-wfapi-properties-volumemounts.md))

## volumeMounts Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## volumeMounts Default Value

The default value is:

```json
[]
```
