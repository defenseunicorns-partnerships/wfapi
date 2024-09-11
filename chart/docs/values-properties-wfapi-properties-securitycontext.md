# securityContext Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext
```

SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext. When both are set, the values in SecurityContext take precedence. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#security-context-1>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## securityContext Type

`object` ([securityContext](values-properties-wfapi-properties-securitycontext.md))

# securityContext Properties

| Property                                              | Type      | Required | Nullable       | Defined by                                                                                                                                                                                              |
| :---------------------------------------------------- | :-------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [allowPrivilegeEscalation](#allowprivilegeescalation) | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-allowprivilegeescalation.md "values.yaml#/properties/wfapi/properties/securityContext/properties/allowPrivilegeEscalation") |
| [appArmorProfile](#apparmorprofile)                   | `object`  | Optional | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile")                   |
| [capabilities](#capabilities)                         | `object`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities")                         |
| [privileged](#privileged)                             | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-privileged.md "values.yaml#/properties/wfapi/properties/securityContext/properties/privileged")                             |
| [readOnlyRootFilesystem](#readonlyrootfilesystem)     | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-readonlyrootfilesystem.md "values.yaml#/properties/wfapi/properties/securityContext/properties/readOnlyRootFilesystem")     |
| [runAsGroup](#runasgroup)                             | `number`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasgroup.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsGroup")                             |
| [runAsNonRoot](#runasnonroot)                         | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasnonroot.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsNonRoot")                         |
| [runAsUser](#runasuser)                               | `number`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasuser.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsUser")                               |
| [seLinuxOptions](#selinuxoptions)                     | `object`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-selinuxoptions.md "values.yaml#/properties/wfapi/properties/securityContext/properties/seLinuxOptions")                     |
| [seccompProfile](#seccompprofile)                     | `object`  | Optional | can be null    | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-seccompprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/seccompProfile")                     |

## allowPrivilegeEscalation

AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no\_new\_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP\_SYS\_ADMIN

`allowPrivilegeEscalation`

* is required

* Type: `boolean` ([allowPrivilegeEscalation](values-properties-wfapi-properties-securitycontext-properties-allowprivilegeescalation.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-allowprivilegeescalation.md "values.yaml#/properties/wfapi/properties/securityContext/properties/allowPrivilegeEscalation")

### allowPrivilegeEscalation Type

`boolean` ([allowPrivilegeEscalation](values-properties-wfapi-properties-securitycontext-properties-allowprivilegeescalation.md))

## appArmorProfile

AppArmor profile. NOTE: This only works if on K8s v1.30.0 or later. If on an earlier version you have to set the profile using an annotation. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#apparmorprofile-v1-core>

`appArmorProfile`

* is optional

* Type: `object` ([appArmorProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/appArmorProfile")

### appArmorProfile Type

`object` ([appArmorProfile](values-properties-wfapi-properties-securitycontext-properties-apparmorprofile.md))

### appArmorProfile Default Value

The default value is:

```json
{}
```

## capabilities

The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.

`capabilities`

* is required

* Type: `object` ([capabilities](values-properties-wfapi-properties-securitycontext-properties-capabilities.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities")

### capabilities Type

`object` ([capabilities](values-properties-wfapi-properties-securitycontext-properties-capabilities.md))

## privileged

Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.

`privileged`

* is required

* Type: `boolean` ([privileged](values-properties-wfapi-properties-securitycontext-properties-privileged.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-privileged.md "values.yaml#/properties/wfapi/properties/securityContext/properties/privileged")

### privileged Type

`boolean` ([privileged](values-properties-wfapi-properties-securitycontext-properties-privileged.md))

## readOnlyRootFilesystem

Whether this container has a read-only root filesystem.

`readOnlyRootFilesystem`

* is required

* Type: `boolean` ([readOnlyRootFilesystem](values-properties-wfapi-properties-securitycontext-properties-readonlyrootfilesystem.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-readonlyrootfilesystem.md "values.yaml#/properties/wfapi/properties/securityContext/properties/readOnlyRootFilesystem")

### readOnlyRootFilesystem Type

`boolean` ([readOnlyRootFilesystem](values-properties-wfapi-properties-securitycontext-properties-readonlyrootfilesystem.md))

### readOnlyRootFilesystem Default Value

The default value is:

```json
true
```

## runAsGroup

The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

`runAsGroup`

* is required

* Type: `number` ([runAsGroup](values-properties-wfapi-properties-securitycontext-properties-runasgroup.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasgroup.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsGroup")

### runAsGroup Type

`number` ([runAsGroup](values-properties-wfapi-properties-securitycontext-properties-runasgroup.md))

### runAsGroup Default Value

The default value is:

```json
1654
```

## runAsNonRoot

Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

`runAsNonRoot`

* is required

* Type: `boolean` ([runAsNonRoot](values-properties-wfapi-properties-securitycontext-properties-runasnonroot.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasnonroot.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsNonRoot")

### runAsNonRoot Type

`boolean` ([runAsNonRoot](values-properties-wfapi-properties-securitycontext-properties-runasnonroot.md))

### runAsNonRoot Default Value

The default value is:

```json
true
```

## runAsUser

The UID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.

`runAsUser`

* is required

* Type: `number` ([runAsUser](values-properties-wfapi-properties-securitycontext-properties-runasuser.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-runasuser.md "values.yaml#/properties/wfapi/properties/securityContext/properties/runAsUser")

### runAsUser Type

`number` ([runAsUser](values-properties-wfapi-properties-securitycontext-properties-runasuser.md))

### runAsUser Default Value

The default value is:

```json
1654
```

## seLinuxOptions

The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#:~:text=Must%20NOT%20be%20set%20for%20any%20other%20type.-,securityContext.seLinuxOptions%20(SELinuxOptions),-The%20SELinux%20context%20to%20be%20applied%20to%20all>

`seLinuxOptions`

* is required

* Type: `object` ([seLinuxOptions](values-properties-wfapi-properties-securitycontext-properties-selinuxoptions.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-selinuxoptions.md "values.yaml#/properties/wfapi/properties/securityContext/properties/seLinuxOptions")

### seLinuxOptions Type

`object` ([seLinuxOptions](values-properties-wfapi-properties-securitycontext-properties-selinuxoptions.md))

### seLinuxOptions Default Value

The default value is:

```json
{}
```

## seccompProfile

The seccomp options to use by the containers in this pod. Ref: <https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.30/#seccompprofile-v1-core>

`seccompProfile`

* is optional

* Type: `object` ([seccompProfile](values-properties-wfapi-properties-securitycontext-properties-seccompprofile.md))

* can be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-seccompprofile.md "values.yaml#/properties/wfapi/properties/securityContext/properties/seccompProfile")

### seccompProfile Type

`object` ([seccompProfile](values-properties-wfapi-properties-securitycontext-properties-seccompprofile.md))

### seccompProfile Default Value

The default value is:

```json
"null"
```
