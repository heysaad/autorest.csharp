// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Effective network security group. </summary>
    public partial class EffectiveNetworkSecurityGroup
    {
        /// <summary> Initializes a new instance of EffectiveNetworkSecurityGroup. </summary>
        internal EffectiveNetworkSecurityGroup()
        {
        }

        /// <summary> Initializes a new instance of EffectiveNetworkSecurityGroup. </summary>
        /// <param name="networkSecurityGroup"> The ID of network security group that is applied. </param>
        /// <param name="association"> Associated resources. </param>
        /// <param name="effectiveSecurityRules"> A collection of effective security rules. </param>
        /// <param name="tagMap"> Mapping of tags to list of IP Addresses included within the tag. </param>
        internal EffectiveNetworkSecurityGroup(SubResource networkSecurityGroup, EffectiveNetworkSecurityGroupAssociation association, IList<EffectiveNetworkSecurityRule> effectiveSecurityRules, string tagMap)
        {
            NetworkSecurityGroup = networkSecurityGroup;
            Association = association;
            EffectiveSecurityRules = effectiveSecurityRules;
            TagMap = tagMap;
        }

        /// <summary> The ID of network security group that is applied. </summary>
        public SubResource NetworkSecurityGroup { get; internal set; }
        /// <summary> Associated resources. </summary>
        public EffectiveNetworkSecurityGroupAssociation Association { get; internal set; }
        /// <summary> A collection of effective security rules. </summary>
        public IList<EffectiveNetworkSecurityRule> EffectiveSecurityRules { get; internal set; }
        /// <summary> Mapping of tags to list of IP Addresses included within the tag. </summary>
        public string TagMap { get; internal set; }
    }
}