// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.RenameGetList
{
    /// <summary> Client options for RenameGetListClient. </summary>
    public partial class RenameGetListClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_05_15_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-05-15-preview". </summary>
            V2022_05_15_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of RenameGetListClientOptions. </summary>
        public RenameGetListClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_05_15_Preview => "2022-05-15-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
