# runAsGroup Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/runAsGroup
```

The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## runAsGroup Type

`number` ([runAsGroup](values-properties-wfapi-properties-securitycontext-properties-runasgroup.md))

## runAsGroup Default Value

The default value is:

```json
1654
```
