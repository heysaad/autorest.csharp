// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using MgmtSupersetInheritance;

namespace MgmtSupersetInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class SupersetModel7ListResult
    {
        /// <summary> Initializes a new instance of SupersetModel7ListResult. </summary>
        internal SupersetModel7ListResult()
        {
            Value = new ChangeTrackingList<SupersetModel7Data>();
        }

        /// <summary> Initializes a new instance of SupersetModel7ListResult. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal SupersetModel7ListResult(IReadOnlyList<SupersetModel7Data> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<SupersetModel7Data> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}