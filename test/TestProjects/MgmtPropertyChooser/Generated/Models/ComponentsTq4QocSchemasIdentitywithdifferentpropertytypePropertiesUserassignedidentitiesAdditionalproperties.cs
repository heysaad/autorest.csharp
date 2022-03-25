// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtPropertyChooser.Models
{
    /// <summary> The ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties. </summary>
    internal partial class ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties
    {
        /// <summary> Initializes a new instance of ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties. </summary>
        public ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties()
        {
        }

        /// <summary> Initializes a new instance of ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal ComponentsTq4QocSchemasIdentitywithdifferentpropertytypePropertiesUserassignedidentitiesAdditionalproperties(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; }
    }
}
