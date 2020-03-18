// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> Response schema. Contains list of shares returned, and if paging is requested or required, a URL to next page of shares. </summary>
    public partial class FileShareItems
    {
        /// <summary> Initializes a new instance of FileShareItems. </summary>
        internal FileShareItems()
        {
        }

        /// <summary> Initializes a new instance of FileShareItems. </summary>
        /// <param name="value"> List of file shares returned. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of shares. Returned when total number of requested shares exceed maximum page size. </param>
        internal FileShareItems(IList<FileShareItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of file shares returned. </summary>
        public IList<FileShareItem> Value { get; internal set; }
        /// <summary> Request URL that can be used to query next page of shares. Returned when total number of requested shares exceed maximum page size. </summary>
        public string NextLink { get; internal set; }
    }
}