# requests Schema

```txt
values.yaml#/properties/wfapi/properties/resources/properties/requests
```

Resource requests

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## requests Type

`object` ([requests](values-properties-wfapi-properties-resources-properties-requests.md))

# requests Properties

| Property          | Type     | Required | Nullable       | Defined by                                                                                                                                                                                      |
| :---------------- | :------- | :------- | :------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [cpu](#cpu)       | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-requests-properties-cpu.md "values.yaml#/properties/wfapi/properties/resources/properties/requests/properties/cpu")       |
| [memory](#memory) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-requests-properties-memory.md "values.yaml#/properties/wfapi/properties/resources/properties/requests/properties/memory") |

## cpu

CPU request

`cpu`

* is required

* Type: `string` ([cpu](values-properties-wfapi-properties-resources-properties-requests-properties-cpu.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-requests-properties-cpu.md "values.yaml#/properties/wfapi/properties/resources/properties/requests/properties/cpu")

### cpu Type

`string` ([cpu](values-properties-wfapi-properties-resources-properties-requests-properties-cpu.md))

### cpu Default Value

The default value is:

```json
"100m"
```

## memory

Memory request

`memory`

* is required

* Type: `string` ([memory](values-properties-wfapi-properties-resources-properties-requests-properties-memory.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-requests-properties-memory.md "values.yaml#/properties/wfapi/properties/resources/properties/requests/properties/memory")

### memory Type

`string` ([memory](values-properties-wfapi-properties-resources-properties-requests-properties-memory.md))

### memory Default Value

The default value is:

```json
"128Mi"
```
