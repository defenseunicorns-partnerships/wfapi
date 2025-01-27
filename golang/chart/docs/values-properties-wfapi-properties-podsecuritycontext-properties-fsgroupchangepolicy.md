# fsGroupChangePolicy Schema

```txt
values.yaml#/properties/wfapi/properties/podSecurityContext/properties/fsGroupChangePolicy
```

fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod. This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## fsGroupChangePolicy Type

`string` ([fsGroupChangePolicy](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroupchangepolicy.md))

## fsGroupChangePolicy Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value              | Explanation |
| :----------------- | :---------- |
| `"Always"`         |             |
| `"OnRootMismatch"` |             |

## fsGroupChangePolicy Default Value

The default value is:

```json
"Always"
```
