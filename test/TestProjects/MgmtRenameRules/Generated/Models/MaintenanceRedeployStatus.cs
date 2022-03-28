// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtRenameRules.Models
{
    /// <summary> Maintenance Operation Status. </summary>
    public partial class MaintenanceRedeployStatus
    {
        /// <summary> Initializes a new instance of MaintenanceRedeployStatus. </summary>
        internal MaintenanceRedeployStatus()
        {
        }

        /// <summary> Initializes a new instance of MaintenanceRedeployStatus. </summary>
        /// <param name="isCustomerInitiatedMaintenanceAllowed"> True, if customer is allowed to perform Maintenance. </param>
        /// <param name="preMaintenanceWindowStartOn"> Start Time for the Pre Maintenance Window. </param>
        /// <param name="preMaintenanceWindowEndOn"> End Time for the Pre Maintenance Window. </param>
        /// <param name="maintenanceWindowStartOn"> Start Time for the Maintenance Window. </param>
        /// <param name="maintenanceWindowEndOn"> End Time for the Maintenance Window. </param>
        /// <param name="lastOperationResultCode"> The Last Maintenance Operation Result Code. </param>
        /// <param name="lastOperationMessage"> Message returned for the last Maintenance Operation. </param>
        internal MaintenanceRedeployStatus(bool? isCustomerInitiatedMaintenanceAllowed, DateTimeOffset? preMaintenanceWindowStartOn, DateTimeOffset? preMaintenanceWindowEndOn, DateTimeOffset? maintenanceWindowStartOn, DateTimeOffset? maintenanceWindowEndOn, MaintenanceOperationResultCodeTypes? lastOperationResultCode, string lastOperationMessage)
        {
            IsCustomerInitiatedMaintenanceAllowed = isCustomerInitiatedMaintenanceAllowed;
            PreMaintenanceWindowStartOn = preMaintenanceWindowStartOn;
            PreMaintenanceWindowEndOn = preMaintenanceWindowEndOn;
            MaintenanceWindowStartOn = maintenanceWindowStartOn;
            MaintenanceWindowEndOn = maintenanceWindowEndOn;
            LastOperationResultCode = lastOperationResultCode;
            LastOperationMessage = lastOperationMessage;
        }

        /// <summary> True, if customer is allowed to perform Maintenance. </summary>
        public bool? IsCustomerInitiatedMaintenanceAllowed { get; }
        /// <summary> Start Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowStartOn { get; }
        /// <summary> End Time for the Pre Maintenance Window. </summary>
        public DateTimeOffset? PreMaintenanceWindowEndOn { get; }
        /// <summary> Start Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowStartOn { get; }
        /// <summary> End Time for the Maintenance Window. </summary>
        public DateTimeOffset? MaintenanceWindowEndOn { get; }
        /// <summary> The Last Maintenance Operation Result Code. </summary>
        public MaintenanceOperationResultCodeTypes? LastOperationResultCode { get; }
        /// <summary> Message returned for the last Maintenance Operation. </summary>
        public string LastOperationMessage { get; }
    }
}
