# localhostProfile Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile/properties/localhostProfile
```

localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost"

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## localhostProfile Type

`string` ([localhostProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile-properties-localhostprofile.md))

## localhostProfile Default Value

The default value is:

```json
"null"
```
