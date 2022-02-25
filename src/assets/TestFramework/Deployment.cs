// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.TestFramework
{
    /// <summary> A Class representing a Deployment along with the instance operations that can be performed on it. </summary>
    public partial class Deployment : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="Deployment"/> class for mocking. </summary>
        public Deployment()
        {
        }

        public DeploymentData Data;
    }

    public class DeploymentData {
        public Property Properties;
    }

    public class Property {
        public object Outputs;
    }
}