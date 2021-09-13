// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace SubscriptionExtensions
{
    /// <summary> A class representing the Toaster data model. </summary>
    public partial class ToasterData : TrackedResource
    {
        /// <summary> Initializes a new instance of ToasterData. </summary>
        /// <param name="location"> The location. </param>
        public ToasterData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ToasterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        internal ToasterData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string foo) : base(id, name, type, tags, location)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}