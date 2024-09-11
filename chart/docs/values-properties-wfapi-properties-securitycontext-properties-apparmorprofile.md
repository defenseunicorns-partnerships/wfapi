# appArmorProfile Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile
```

AppArmor profile. NOTE: This only works if on K8s v1.30.0 or later. If on an earlier version you have to set the profile using an annotation. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#apparmorprofile-v1-core>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## appArmorProfile Type

`object` ([appArmorProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md))

## appArmorProfile Default Value

The default value is:

```json
{}
```

# appArmorProfile Properties

| Property              | Type     | Required | Nullable       | Defined by                                                                                                                                                                                                            |
| :-------------------- | :------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [type](#type)         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/type") |
| Additional Properties | Any      | Optional | can be null    |                                                                                                                                                                                                                       |

## type

The type for the AppArmor profile, valid values are RuntimeDefault, Localhost(requires localhostProfile), Unconfined (no AppArmor)

`type`

* is required

* Type: `string` ([type](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/type")

### type Type

`string` ([type](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md))

## Additional Properties

Additional properties are allowed and do not have to follow a specific schema
