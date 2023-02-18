// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtCollectionParent;

namespace MgmtCollectionParent.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtCollectionParentModelFactory
    {
        /// <summary> Initializes a new instance of OrderResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="orderItemIds"> List of order item ARM Ids which are part of an order. </param>
        /// <param name="currentStage"> Order current status. </param>
        /// <param name="orderStageHistory"> Order status history. </param>
        /// <returns> A new <see cref="MgmtCollectionParent.OrderResourceData"/> instance for mocking. </returns>
        public static OrderResourceData OrderResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> orderItemIds = null, StageDetails currentStage = null, IEnumerable<StageDetails> orderStageHistory = null)
        {
            orderItemIds ??= new List<string>();
            orderStageHistory ??= new List<StageDetails>();

            return new OrderResourceData(id, name, resourceType, systemData, orderItemIds?.ToList(), currentStage, orderStageHistory?.ToList());
        }

        /// <summary> Initializes a new instance of StageDetails. </summary>
        /// <param name="stageStatus"> Stage status. </param>
        /// <param name="stageName"> Stage name. </param>
        /// <param name="displayName"> Display name of the resource stage. </param>
        /// <param name="startOn"> Stage start time. </param>
        /// <returns> A new <see cref="Models.StageDetails"/> instance for mocking. </returns>
        public static StageDetails StageDetails(StageStatus? stageStatus = null, StageName? stageName = null, string displayName = null, DateTimeOffset? startOn = null)
        {
            return new StageDetails(stageStatus, stageName, displayName, startOn);
        }
    }
}