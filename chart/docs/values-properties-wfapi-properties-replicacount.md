# replicaCount Schema

```txt
values.yaml#/properties/wfapi/properties/replicaCount
```

Number of replicas to deploy. Currently, '1' is the only supported value.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## replicaCount Type

`number` ([replicaCount](values-properties-wfapi-properties-replicacount.md))

## replicaCount Constraints

**maximum**: the value of this number must smaller than or equal to: `1`

**minimum**: the value of this number must greater than or equal to: `1`

## replicaCount Default Value

The default value is:

```json
1
```
