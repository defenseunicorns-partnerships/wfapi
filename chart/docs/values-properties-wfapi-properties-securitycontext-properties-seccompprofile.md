# seccompProfile Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/seccompProfile
```

The seccomp options to use by the containers in this pod. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#seccompprofile-v1-core>

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## seccompProfile Type

`object` ([seccompProfile](values-properties-wfapi-properties-securitycontext-properties-seccompprofile.md))

## seccompProfile Default Value

The default value is:

```json
"null"
```

# seccompProfile Properties

| Property              | Type | Required | Nullable    | Defined by |
| :-------------------- | :--- | :------- | :---------- | :--------- |
| Additional Properties | Any  | Optional | can be null |            |

## Additional Properties

Additional properties are allowed and do not have to follow a specific schema
