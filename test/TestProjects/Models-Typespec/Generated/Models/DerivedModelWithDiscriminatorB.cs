// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ModelsInCadl.Models
{
    /// <summary> Deriver model with discriminator property. </summary>
    public partial class DerivedModelWithDiscriminatorB : BaseModelWithDiscriminator
    {
        /// <summary> Initializes a new instance of DerivedModelWithDiscriminatorB. </summary>
        /// <param name="requiredInt"> Required int. </param>
        public DerivedModelWithDiscriminatorB(int requiredInt) : base("B")
        {
            RequiredInt = requiredInt;
        }

        /// <summary> Required int. </summary>
        public int RequiredInt { get; set; }
    }
}
