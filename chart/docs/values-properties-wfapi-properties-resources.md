# resources Schema

```txt
values.yaml#/properties/wfapi/properties/resources
```

Resource requests and limits

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## resources Type

`object` ([resources](values-properties-wfapi-properties-resources.md))

# resources Properties

| Property              | Type     | Required | Nullable       | Defined by                                                                                                                                                  |
| :-------------------- | :------- | :------- | :------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [limits](#limits)     | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-limits.md "values.yaml#/properties/wfapi/properties/resources/properties/limits")     |
| [requests](#requests) | `object` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-resources-properties-requests.md "values.yaml#/properties/wfapi/properties/resources/properties/requests") |

## limits

Resource limits

`limits`

* is required

* Type: `object` ([limits](values-properties-wfapi-properties-resources-properties-limits.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-limits.md "values.yaml#/properties/wfapi/properties/resources/properties/limits")

### limits Type

`object` ([limits](values-properties-wfapi-properties-resources-properties-limits.md))

## requests

Resource requests

`requests`

* is required

* Type: `object` ([requests](values-properties-wfapi-properties-resources-properties-requests.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-resources-properties-requests.md "values.yaml#/properties/wfapi/properties/resources/properties/requests")

### requests Type

`object` ([requests](values-properties-wfapi-properties-resources-properties-requests.md))
