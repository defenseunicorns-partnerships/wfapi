# service Schema

```txt
values.yaml#/properties/wfapi/properties/service
```

Service settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## service Type

`object` ([service](values-properties-wfapi-properties-service.md))

# service Properties

| Property                  | Type     | Required | Nullable       | Defined by                                                                                                                                                  |
| :------------------------ | :------- | :------- | :------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [port](#port)             | `number` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-service-properties-port.md "values.yaml#/properties/wfapi/properties/service/properties/port")             |
| [targetPort](#targetport) | `number` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-service-properties-targetport.md "values.yaml#/properties/wfapi/properties/service/properties/targetPort") |
| [type](#type)             | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-service-properties-type.md "values.yaml#/properties/wfapi/properties/service/properties/type")             |

## port

Service port

`port`

* is required

* Type: `number` ([port](values-properties-wfapi-properties-service-properties-port.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-service-properties-port.md "values.yaml#/properties/wfapi/properties/service/properties/port")

### port Type

`number` ([port](values-properties-wfapi-properties-service-properties-port.md))

### port Default Value

The default value is:

```json
80
```

## targetPort

Target port

`targetPort`

* is required

* Type: `number` ([targetPort](values-properties-wfapi-properties-service-properties-targetport.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-service-properties-targetport.md "values.yaml#/properties/wfapi/properties/service/properties/targetPort")

### targetPort Type

`number` ([targetPort](values-properties-wfapi-properties-service-properties-targetport.md))

### targetPort Default Value

The default value is:

```json
8080
```

## type

Kubernetes service type

`type`

* is required

* Type: `string` ([type](values-properties-wfapi-properties-service-properties-type.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-service-properties-type.md "values.yaml#/properties/wfapi/properties/service/properties/type")

### type Type

`string` ([type](values-properties-wfapi-properties-service-properties-type.md))

### type Constraints

**enum**: the value of this property must be equal to one of the following values:

| Value            | Explanation |
| :--------------- | :---------- |
| `"ClusterIP"`    |             |
| `"NodePort"`     |             |
| `"LoadBalancer"` |             |
| `"ExternalName"` |             |

### type Default Value

The default value is:

```json
"ClusterIP"
```
