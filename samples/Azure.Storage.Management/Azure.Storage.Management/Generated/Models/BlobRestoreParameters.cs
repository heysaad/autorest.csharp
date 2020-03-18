// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> Blob restore parameters. </summary>
    public partial class BlobRestoreParameters
    {
        /// <summary> Initializes a new instance of BlobRestoreParameters. </summary>
        public BlobRestoreParameters()
        {
        }

        /// <summary> Initializes a new instance of BlobRestoreParameters. </summary>
        /// <param name="timeToRestore"> Restore blob to the specified time. </param>
        /// <param name="blobRanges"> Blob ranges to restore. </param>
        internal BlobRestoreParameters(DateTimeOffset timeToRestore, IList<BlobRestoreRange> blobRanges)
        {
            TimeToRestore = timeToRestore;
            BlobRanges = blobRanges;
        }

        /// <summary> Restore blob to the specified time. </summary>
        public DateTimeOffset TimeToRestore { get; set; }
        /// <summary> Blob ranges to restore. </summary>
        public IList<BlobRestoreRange> BlobRanges { get; set; } = new List<BlobRestoreRange>();
    }
}