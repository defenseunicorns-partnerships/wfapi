# appArmorProfile Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile
```

AppArmor profile. NOTE: This only works if on K8s v1.30.0 or later. If on an earlier version you have to set the profile using an annotation. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#apparmorprofile-v1-core>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## appArmorProfile Type

`object` ([appArmorProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md))

# appArmorProfile Properties

| Property                              | Type     | Required | Nullable       | Defined by                                                                                                                                                                                                                                    |
| :------------------------------------ | :------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [localhostProfile](#localhostprofile) | `string` | Optional | can be null    | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-localhostprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/localhostProfile") |
| [type](#type)                         | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/type")                         |

## localhostProfile

localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost"

`localhostProfile`

* is optional

* Type: `string` ([localhostProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-localhostprofile.md))

* can be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-localhostprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/localhostProfile")

### localhostProfile Type

`string` ([localhostProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-localhostprofile.md))

### localhostProfile Default Value

The default value is:

```json
"null"
```

## type

The type for the AppArmor profile, valid values are RuntimeDefault, Localhost(requires localhostProfile), Unconfined (no AppArmor)

`type`

* is required

* Type: `string` ([type](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/type")

### type Type

`string` ([type](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-type.md))
