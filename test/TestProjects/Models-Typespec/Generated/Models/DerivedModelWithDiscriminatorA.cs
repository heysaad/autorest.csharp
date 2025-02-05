// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ModelsInCadl.Models
{
    /// <summary> Deriver model with discriminator property. </summary>
    public partial class DerivedModelWithDiscriminatorA : BaseModelWithDiscriminator
    {
        /// <summary> Initializes a new instance of DerivedModelWithDiscriminatorA. </summary>
        /// <param name="requiredString"> Required string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/> is null. </exception>
        public DerivedModelWithDiscriminatorA(string requiredString) : base("A")
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));

            RequiredString = requiredString;
        }

        /// <summary> Required string. </summary>
        public string RequiredString { get; set; }
    }
}
