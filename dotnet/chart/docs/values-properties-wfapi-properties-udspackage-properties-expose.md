# expose Schema

```txt
values.yaml#/properties/wfapi/properties/udsPackage/properties/expose
```

Expose settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## expose Type

`object` ([expose](values-properties-wfapi-properties-udspackage-properties-expose.md))

# expose Properties

| Property      | Type     | Required | Nullable       | Defined by                                                                                                                                                                                |
| :------------ | :------- | :------- | :------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [host](#host) | `string` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-udspackage-properties-expose-properties-host.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/expose/properties/host") |

## host

Hostname to expose the app on

`host`

* is required

* Type: `string` ([host](values-properties-wfapi-properties-udspackage-properties-expose-properties-host.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-udspackage-properties-expose-properties-host.md "values.yaml#/properties/wfapi/properties/udsPackage/properties/expose/properties/host")

### host Type

`string` ([host](values-properties-wfapi-properties-udspackage-properties-expose-properties-host.md))

### host Default Value

The default value is:

```json
"wfapi"
```
