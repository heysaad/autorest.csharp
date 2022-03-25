// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OmitOperationGroups.Models
{
    /// <summary> The OmitOperationGroupsResourceData. </summary>
    internal partial class OmitOperationGroupsResourceData
    {
        /// <summary> Initializes a new instance of OmitOperationGroupsResourceData. </summary>
        public OmitOperationGroupsResourceData()
        {
        }

        /// <summary> Initializes a new instance of OmitOperationGroupsResourceData. </summary>
        /// <param name="id"></param>
        /// <param name="resourceType"></param>
        /// <param name="name"></param>
        internal OmitOperationGroupsResourceData(string id, string resourceType, string name)
        {
            Id = id;
            ResourceType = resourceType;
            Name = name;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}
