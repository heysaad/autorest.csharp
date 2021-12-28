// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtKeyvault.Models
{
    /// <summary> List of deleted managed HSM Pools. </summary>
    internal partial class DeletedManagedHsmListResult
    {
        /// <summary> Initializes a new instance of DeletedManagedHsmListResult. </summary>
        internal DeletedManagedHsmListResult()
        {
            Value = new ChangeTrackingList<DeletedManagedHsm>();
        }

        /// <summary> The list of deleted managed HSM Pools. </summary>
        public IReadOnlyList<DeletedManagedHsm> Value { get; }
        /// <summary> The URL to get the next set of deleted managed HSM Pools. </summary>
        public string NextLink { get; }
    }
}
