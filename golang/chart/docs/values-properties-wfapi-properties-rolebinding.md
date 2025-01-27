# roleBinding Schema

```txt
values.yaml#/properties/wfapi/properties/roleBinding
```

Role binding settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## roleBinding Type

`object` ([roleBinding](values-properties-wfapi-properties-rolebinding.md))

# roleBinding Properties

| Property              | Type      | Required | Nullable       | Defined by                                                                                                                                                      |
| :-------------------- | :-------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [create](#create)     | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-rolebinding-properties-create.md "values.yaml#/properties/wfapi/properties/roleBinding/properties/create")     |
| [roleName](#rolename) | `string`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-rolebinding-properties-rolename.md "values.yaml#/properties/wfapi/properties/roleBinding/properties/roleName") |

## create

Specifies whether a role binding should be created

`create`

* is required

* Type: `boolean` ([create](values-properties-wfapi-properties-rolebinding-properties-create.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-rolebinding-properties-create.md "values.yaml#/properties/wfapi/properties/roleBinding/properties/create")

### create Type

`boolean` ([create](values-properties-wfapi-properties-rolebinding-properties-create.md))

### create Default Value

The default value is:

```json
true
```

## roleName

The name of the role to bind to the service account

`roleName`

* is required

* Type: `string` ([roleName](values-properties-wfapi-properties-rolebinding-properties-rolename.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-rolebinding-properties-rolename.md "values.yaml#/properties/wfapi/properties/roleBinding/properties/roleName")

### roleName Type

`string` ([roleName](values-properties-wfapi-properties-rolebinding-properties-rolename.md))

### roleName Default Value

The default value is:

```json
"server-role"
```
