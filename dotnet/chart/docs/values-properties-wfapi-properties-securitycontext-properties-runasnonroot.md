# runAsNonRoot Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/runAsNonRoot
```

Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## runAsNonRoot Type

`boolean` ([runAsNonRoot](values-properties-wfapi-properties-securitycontext-properties-runasnonroot.md))

## runAsNonRoot Default Value

The default value is:

```json
true
```
