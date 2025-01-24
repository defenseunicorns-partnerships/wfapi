# allowPrivilegeEscalation Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/allowPrivilegeEscalation
```

AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no\_new\_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP\_SYS\_ADMIN

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## allowPrivilegeEscalation Type

`boolean` ([allowPrivilegeEscalation](values-properties-wfapi-properties-securitycontext-properties-allowprivilegeescalation.md))
