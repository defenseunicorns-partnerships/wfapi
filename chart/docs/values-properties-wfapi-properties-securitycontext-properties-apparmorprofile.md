# appArmorProfile Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile
```

AppArmor profile. NOTE: This only works if on K8s v1.30.0 or later. If on an earlier version you have to set the profile using an annotation. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#apparmorprofile-v1-core>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## appArmorProfile Type

`object` ([appArmorProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md))

# appArmorProfile Properties

| Property              | Type | Required | Nullable    | Defined by |
| :-------------------- | :--- | :------- | :---------- | :--------- |
| Additional Properties | Any  | Optional | can be null |            |

## Additional Properties

Additional properties are allowed and do not have to follow a specific schema
