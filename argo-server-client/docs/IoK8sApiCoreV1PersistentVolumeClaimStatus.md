# Org.OpenAPITools.Model.IoK8sApiCoreV1PersistentVolumeClaimStatus
PersistentVolumeClaimStatus is the current status of a persistent volume claim.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessModes** | **List&lt;string&gt;** | AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1 | [optional]
**AllocatedResources** | **Dictionary&lt;string, string&gt;** | The storage resource within AllocatedResources tracks the capacity allocated to a PVC. It may be larger than the actual capacity when a volume expansion operation is requested. For storage quota, the larger value from allocatedResources and PVC.spec.resources is used. If allocatedResources is not set, PVC.spec.resources alone is used for quota calculation. If a volume expansion capacity request is lowered, allocatedResources is only lowered if there are no expansion operations in progress and if the actual volume capacity is equal or lower than the requested capacity. This is an alpha field and requires enabling RecoverVolumeExpansionFailure feature. | [optional]
**Capacity** | **Dictionary&lt;string, string&gt;** | Represents the actual resources of the underlying volume. | [optional]
**Conditions** | [**List&lt;IoK8sApiCoreV1PersistentVolumeClaimCondition&gt;**](IoK8sApiCoreV1PersistentVolumeClaimCondition.md) | Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to &#39;ResizeStarted&#39;. | [optional]
**Phase** | **string** | Phase represents the current phase of PersistentVolumeClaim.  Possible enum values:  - &#x60;\&quot;Bound\&quot;&#x60; used for PersistentVolumeClaims that are bound  - &#x60;\&quot;Lost\&quot;&#x60; used for PersistentVolumeClaims that lost their underlying PersistentVolume. The claim was bound to a PersistentVolume and this volume does not exist any longer and all data on it was lost.  - &#x60;\&quot;Pending\&quot;&#x60; used for PersistentVolumeClaims that are not yet bound | [optional]
**ResizeStatus** | **string** | ResizeStatus stores status of resize operation. ResizeStatus is not set by default but when expansion is complete resizeStatus is set to empty string by resize controller or kubelet. This is an alpha field and requires enabling RecoverVolumeExpansionFailure feature. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
