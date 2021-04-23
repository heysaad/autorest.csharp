// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SubscriptionExtensions.Models
{
    /// <summary> A class representing the AvailabilitySet data model. </summary>
    public partial class AvailabilitySetData
    {
        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        public AvailabilitySetData()
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="foo"> specifies the foo. </param>
        internal AvailabilitySetData(string foo)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}