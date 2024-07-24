# runAsUser Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/runAsUser
```

The UID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## runAsUser Type

`number` ([runAsUser](values-properties-wfapi-properties-securitycontext-properties-runasuser.md))

## runAsUser Default Value

The default value is:

```json
1654
```
