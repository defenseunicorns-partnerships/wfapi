# podSecurityContext Schema

```txt
values.yaml#/properties/wfapi/properties/podSecurityContext
```

Security context for the pod. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#security-context>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## podSecurityContext Type

`object` ([podSecurityContext](values-properties-wfapi-properties-podsecuritycontext.md))

# podSecurityContext Properties

| Property                                    | Type     | Required | Nullable       | Defined by                                                                                                                                                                                          |
| :------------------------------------------ | :------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [fsGroup](#fsgroup)                         | `number` | Required | can be null    | [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroup.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/fsGroup")                         |
| [fsGroupChangePolicy](#fsgroupchangepolicy) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroupchangepolicy.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/fsGroupChangePolicy") |
| [supplementalGroups](#supplementalgroups)   | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-supplementalgroups.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/supplementalGroups")   |
| [sysctls](#sysctls)                         | `array`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-sysctls.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/sysctls")                         |

## fsGroup

A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod: 1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw---- If unset, the Kubelet will not modify the ownership and permissions of any volume.

`fsGroup`

* is required

* Type: `number` ([fsGroup](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroup.md))

* can be null

* defined in: [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroup.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/fsGroup")

### fsGroup Type

`number` ([fsGroup](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroup.md))

### fsGroup Default Value

The default value is:

```json
1654
```

## fsGroupChangePolicy

fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod. This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used.

`fsGroupChangePolicy`

* is required

* Type: `string` ([fsGroupChangePolicy](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroupchangepolicy.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroupchangepolicy.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/fsGroupChangePolicy")

### fsGroupChangePolicy Type

`string` ([fsGroupChangePolicy](values-properties-wfapi-properties-podsecuritycontext-properties-fsgroupchangepolicy.md))

### fsGroupChangePolicy Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value              | Explanation |
| :----------------- | :---------- |
| `"Always"`         |             |
| `"OnRootMismatch"` |             |

### fsGroupChangePolicy Default Value

The default value is:

```json
"Always"
```

## supplementalGroups

A list of groups applied to the first process run in each container, in addition to the container's primary GID, the fsGroup (if specified), and group memberships defined in the container image for the uid of the container process. If unspecified, no additional groups are added to any container. Note that group memberships defined in the container image for the uid of the container process are still effective, even if they are not included in this list.

`supplementalGroups`

* is required

* Type: `array` ([supplementalGroups](values-properties-wfapi-properties-podsecuritycontext-properties-supplementalgroups.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-supplementalgroups.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/supplementalGroups")

### supplementalGroups Type

`array` ([supplementalGroups](values-properties-wfapi-properties-podsecuritycontext-properties-supplementalgroups.md))

### supplementalGroups Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### supplementalGroups Default Value

The default value is:

```json
[]
```

## sysctls

Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls (by the container runtime) might fail to launch.

`sysctls`

* is required

* Type: `array` ([sysctls](values-properties-wfapi-properties-podsecuritycontext-properties-sysctls.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-podsecuritycontext-properties-sysctls.md "values.yaml#/properties/wfapi/properties/podSecurityContext/properties/sysctls")

### sysctls Type

`array` ([sysctls](values-properties-wfapi-properties-podsecuritycontext-properties-sysctls.md))

### sysctls Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### sysctls Default Value

The default value is:

```json
[]
```
