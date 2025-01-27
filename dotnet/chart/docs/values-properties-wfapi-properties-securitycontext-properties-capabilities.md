# capabilities Schema

```txt
values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities
```

The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## capabilities Type

`object` ([capabilities](values-properties-wfapi-properties-securitycontext-properties-capabilities.md))

# capabilities Properties

| Property      | Type    | Required | Nullable       | Defined by                                                                                                                                                                                                      |
| :------------ | :------ | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [add](#add)   | `array` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-add.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities/properties/add")   |
| [drop](#drop) | `array` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-drop.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities/properties/drop") |

## add

Added capabilities

`add`

* is required

* Type: `array` ([add](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-add.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-add.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities/properties/add")

### add Type

`array` ([add](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-add.md))

### add Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### add Default Value

The default value is:

```json
[]
```

## drop

Dropped capabilities

`drop`

* is required

* Type: `string[]`

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-securitycontext-properties-capabilities-properties-drop.md "values.yaml#/properties/wfapi/properties/securityContext/properties/capabilities/properties/drop")

### drop Type

`string[]`

### drop Constraints

**unique items**: all items in this array must be unique. Duplicates are not allowed.

### drop Default Value

The default value is:

```json
[
  "ALL"
]
```
