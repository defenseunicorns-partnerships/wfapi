# seLinuxOptions Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/seLinuxOptions
```

The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container. May also be set in SecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#:~:text=Must%20NOT%20be%20set%20for%20any%20other%20type.-,securityContext.seLinuxOptions%20(SELinuxOptions),-The%20SELinux%20context%20to%20be%20applied%20to%20all>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Allowed               | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## seLinuxOptions Type

`object` ([seLinuxOptions](values-properties-wfapi-properties-securitycontext-properties-selinuxoptions.md))

## seLinuxOptions Default Value

The default value is:

```json
{}
```

# seLinuxOptions Properties

| Property              | Type | Required | Nullable    | Defined by |
| :-------------------- | :--- | :------- | :---------- | :--------- |
| Additional Properties | Any  | Optional | can be null |            |

## Additional Properties

Additional properties are allowed and do not have to follow a specific schema
