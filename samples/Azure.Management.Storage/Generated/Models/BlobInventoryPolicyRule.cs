// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> An object that wraps the blob inventory rule. Each rule is uniquely defined by name. </summary>
    public partial class BlobInventoryPolicyRule
    {
        /// <summary> Initializes a new instance of BlobInventoryPolicyRule. </summary>
        /// <param name="enabled"> Rule is enabled when set to true. </param>
        /// <param name="name"> A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy. </param>
        /// <param name="destination"> Container name where blob inventory files are stored. Must be pre-created. </param>
        /// <param name="definition"> An object that defines the blob inventory policy rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="destination"/>, or <paramref name="definition"/> is null. </exception>
        public BlobInventoryPolicyRule(bool enabled, string name, string destination, BlobInventoryPolicyDefinition definition)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }
            if (definition == null)
            {
                throw new ArgumentNullException(nameof(definition));
            }

            Enabled = enabled;
            Name = name;
            Destination = destination;
            Definition = definition;
        }

        /// <summary> Rule is enabled when set to true. </summary>
        public bool Enabled { get; set; }
        /// <summary> A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy. </summary>
        public string Name { get; set; }
        /// <summary> Container name where blob inventory files are stored. Must be pre-created. </summary>
        public string Destination { get; set; }
        /// <summary> An object that defines the blob inventory policy rule. </summary>
        public BlobInventoryPolicyDefinition Definition { get; set; }
    }
}