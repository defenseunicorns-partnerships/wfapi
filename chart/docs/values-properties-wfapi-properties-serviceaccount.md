# serviceAccount Schema

```txt
values.yaml#/properties/wfapi/properties/serviceAccount
```

Service account settings

| Abstract            | Extensible | Status         | Identifiable | Custom Properties | Additional Properties | Access Restrictions | Defined In                                                           |
| :------------------ | :--------- | :------------- | :----------- | :---------------- | :-------------------- | :------------------ | :------------------------------------------------------------------- |
| Can be instantiated | No         | Unknown status | No           | Forbidden         | Forbidden             | none                | [values.schema.json\*](../values.schema.json "open original schema") |

## serviceAccount Type

`object` ([serviceAccount](values-properties-wfapi-properties-serviceaccount.md))

# serviceAccount Properties

| Property                    | Type      | Required | Nullable       | Defined by                                                                                                                                                                  |
| :-------------------------- | :-------- | :------- | :------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [annotations](#annotations) | `object`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-annotations.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/annotations") |
| [automount](#automount)     | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-automount.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/automount")     |
| [create](#create)           | `boolean` | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-create.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/create")           |
| [name](#name)               | `string`  | Required | cannot be null | [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-name.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/name")               |

## annotations

Annotations to add to the service account. Ref: <https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/>

`annotations`

* is required

* Type: `object` ([annotations](values-properties-wfapi-properties-serviceaccount-properties-annotations.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-annotations.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/annotations")

### annotations Type

`object` ([annotations](values-properties-wfapi-properties-serviceaccount-properties-annotations.md))

### annotations Default Value

The default value is:

```json
{}
```

## automount

Specifies whether a service account token should be mounted

`automount`

* is required

* Type: `boolean` ([automount](values-properties-wfapi-properties-serviceaccount-properties-automount.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-automount.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/automount")

### automount Type

`boolean` ([automount](values-properties-wfapi-properties-serviceaccount-properties-automount.md))

### automount Default Value

The default value is:

```json
true
```

## create

Specifies whether a service account should be created

`create`

* is required

* Type: `boolean` ([create](values-properties-wfapi-properties-serviceaccount-properties-create.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-create.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/create")

### create Type

`boolean` ([create](values-properties-wfapi-properties-serviceaccount-properties-create.md))

### create Default Value

The default value is:

```json
true
```

## name

The name of the service account to use. If not set and create is true, a name is generated using the fullname template. Default is "".

`name`

* is required

* Type: `string` ([name](values-properties-wfapi-properties-serviceaccount-properties-name.md))

* cannot be null

* defined in: [values.yaml](values-properties-wfapi-properties-serviceaccount-properties-name.md "values.yaml#/properties/wfapi/properties/serviceAccount/properties/name")

### name Type

`string` ([name](values-properties-wfapi-properties-serviceaccount-properties-name.md))
