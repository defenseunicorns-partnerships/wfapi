# image Schema

```txt
values.yaml#/properties/wfapi/properties/image
```

Container image settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## image Type

`object` ([image](values-properties-wfapi-properties-image.md))

# image Properties

| Property                  | Type     | Required | Nullable       | Defined by                                                                                                                                              |
| :------------------------ | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [pullPolicy](#pullpolicy) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-image-properties-pullpolicy.md "values.yaml#/properties/wfapi/properties/image/properties/pullPolicy") |
| [repository](#repository) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-image-properties-repository.md "values.yaml#/properties/wfapi/properties/image/properties/repository") |
| [tag](#tag)               | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-image-properties-tag.md "values.yaml#/properties/wfapi/properties/image/properties/tag")               |

## pullPolicy

Container image pull policy.

`pullPolicy`

* is required

* Type: `string` ([pullPolicy](values-properties-wfapi-properties-image-properties-pullpolicy.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-image-properties-pullpolicy.md "values.yaml#/properties/wfapi/properties/image/properties/pullPolicy")

### pullPolicy Type

`string` ([pullPolicy](values-properties-wfapi-properties-image-properties-pullpolicy.md))

### pullPolicy Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value            | Explanation |
| :--------------- | :---------- |
| `"Always"`       |             |
| `"IfNotPresent"` |             |
| `"Never"`        |             |

### pullPolicy Default Value

The default value is:

```json
"Always"
```

## repository

Container image repository.

`repository`

* is required

* Type: `string` ([repository](values-properties-wfapi-properties-image-properties-repository.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-image-properties-repository.md "values.yaml#/properties/wfapi/properties/image/properties/repository")

### repository Type

`string` ([repository](values-properties-wfapi-properties-image-properties-repository.md))

### repository Default Value

The default value is:

```json
"ghcr.io/defenseunicorns/wfapi/wfapi"
```

## tag

Container image tag. If the value is "" it will use the chart's appVersion. Default is "".

`tag`

* is required

* Type: `string` ([tag](values-properties-wfapi-properties-image-properties-tag.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-image-properties-tag.md "values.yaml#/properties/wfapi/properties/image/properties/tag")

### tag Type

`string` ([tag](values-properties-wfapi-properties-image-properties-tag.md))
