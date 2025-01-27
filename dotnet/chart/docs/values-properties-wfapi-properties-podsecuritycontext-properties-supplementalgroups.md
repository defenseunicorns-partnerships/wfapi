# supplementalGroups Schema

```txt
values.yaml#/properties/wfapi/properties/podSecurityContext/properties/supplementalGroups
```

A list of groups applied to the first process run in each container, in addition to the container's primary GID, the fsGroup (if specified), and group memberships defined in the container image for the uid of the container process. If unspecified, no additional groups are added to any container. Note that group memberships defined in the container image for the uid of the container process are still effective, even if they are not included in this list.

| Abstract            | Extensible | Status         | Identifiable            | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :---------------------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | Unknown identifiability | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## supplementalGroups Type

`array` ([supplementalGroups](values-properties-wfapi-properties-podsecuritycontext-properties-supplementalgroups.md))

## supplementalGroups Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

## supplementalGroups Default Value

The default value is:

```json
[]
```
