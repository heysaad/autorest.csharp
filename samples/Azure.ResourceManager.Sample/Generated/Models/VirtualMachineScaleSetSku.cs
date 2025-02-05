// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes an available virtual machine scale set sku.
    /// Serialized Name: VirtualMachineScaleSetSku
    /// </summary>
    public partial class VirtualMachineScaleSetSku
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetSku. </summary>
        internal VirtualMachineScaleSetSku()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetSku. </summary>
        /// <param name="resourceType">
        /// The type of resource the sku applies to.
        /// Serialized Name: VirtualMachineScaleSetSku.resourceType
        /// </param>
        /// <param name="sku">
        /// The Sku.
        /// Serialized Name: VirtualMachineScaleSetSku.sku
        /// </param>
        /// <param name="capacity">
        /// Specifies the number of virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetSku.capacity
        /// </param>
        internal VirtualMachineScaleSetSku(ResourceType? resourceType, SampleSku sku, VirtualMachineScaleSetSkuCapacity capacity)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary>
        /// The type of resource the sku applies to.
        /// Serialized Name: VirtualMachineScaleSetSku.resourceType
        /// </summary>
        public ResourceType? ResourceType { get; }
        /// <summary>
        /// The Sku.
        /// Serialized Name: VirtualMachineScaleSetSku.sku
        /// </summary>
        public SampleSku Sku { get; }
        /// <summary>
        /// Specifies the number of virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetSku.capacity
        /// </summary>
        public VirtualMachineScaleSetSkuCapacity Capacity { get; }
    }
}
