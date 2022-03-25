// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtPropertyChooser.Models
{
    /// <summary> The Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties. </summary>
    internal partial class Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties
    {
        /// <summary> Initializes a new instance of Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties. </summary>
        public Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties()
        {
        }

        /// <summary> Initializes a new instance of Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal Components1Jz5XdsSchemasIdentityv3PropertiesUserassignedidentitiesAdditionalproperties(string principalId, string clientId)
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
