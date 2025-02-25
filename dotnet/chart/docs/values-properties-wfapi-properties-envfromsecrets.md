# envFromSecrets Schema

```txt
values.yaml#/properties/wfapi/properties/envFromSecrets
```

Environment variabels to mount from secrets form secretName: key. Ref: <https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#environment-variables>

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## envFromSecrets Type

`object` ([envFromSecrets](values-properties-wfapi-properties-envfromsecrets.md))

# envFromSecrets Properties

| Property                  | Type     | Required | Nullable       | Defined by                                                                                                                                                                |
| :------------------------ | :------- | :------- | :------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [argoClient](#argoclient) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-envfromsecrets-properties-argoclient.md "values.yaml#/properties/wfapi/properties/envFromSecrets/properties/argoClient") |

## argoClient

SecretName to mount for client secret, needs clientId and secret fields

`argoClient`

* is required

* Type: `string` ([argoClient](values-properties-wfapi-properties-envfromsecrets-properties-argoclient.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-envfromsecrets-properties-argoclient.md "values.yaml#/properties/wfapi/properties/envFromSecrets/properties/argoClient")

### argoClient Type

`string` ([argoClient](values-properties-wfapi-properties-envfromsecrets-properties-argoclient.md))
