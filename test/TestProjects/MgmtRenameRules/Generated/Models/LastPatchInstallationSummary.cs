// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtRenameRules.Models
{
    /// <summary> Describes the properties of the last installed patch summary. </summary>
    public partial class LastPatchInstallationSummary
    {
        /// <summary> Initializes a new instance of LastPatchInstallationSummary. </summary>
        internal LastPatchInstallationSummary()
        {
        }

        /// <summary> Initializes a new instance of LastPatchInstallationSummary. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes. At that point it will become &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;. </param>
        /// <param name="installationActivityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="maintenanceWindowExceeded"> Describes whether the operation ran out of time before it completed all its intended actions. </param>
        /// <param name="rebootStatus"> The reboot status of the machine after the patch operation. It will be in &quot;NotNeeded&quot; status if reboot is not needed after the patch operation. &quot;Required&quot; will be the status once the patch is applied and machine is required to reboot. &quot;Started&quot; will be the reboot status when the machine has started to reboot. &quot;Failed&quot; will be the status if the machine is failed to reboot. &quot;Completed&quot; will be the status once the machine is rebooted successfully. </param>
        /// <param name="notSelectedPatchCount"> The number of all available patches but not going to be installed because it didn&apos;t match a classification or inclusion list entry. </param>
        /// <param name="excludedPatchCount"> The number of all available patches but excluded explicitly by a customer-specified exclusion list match. </param>
        /// <param name="pendingPatchCount"> The number of all available patches expected to be installed over the course of the patch installation operation. </param>
        /// <param name="installedPatchCount"> The count of patches that successfully installed. </param>
        /// <param name="failedPatchCount"> The count of patches that failed installation. </param>
        /// <param name="startTime"> The UTC timestamp when the operation began. </param>
        /// <param name="lastModifiedTime"> The UTC timestamp when the operation began. </param>
        /// <param name="startedBy"> The person or system account that started the operation. </param>
        /// <param name="error"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        internal LastPatchInstallationSummary(PatchOperationStatus? status, string installationActivityId, bool? maintenanceWindowExceeded, RebootStatus? rebootStatus, int? notSelectedPatchCount, int? excludedPatchCount, int? pendingPatchCount, int? installedPatchCount, int? failedPatchCount, DateTimeOffset? startTime, DateTimeOffset? lastModifiedTime, string startedBy, ApiError error)
        {
            Status = status;
            InstallationActivityId = installationActivityId;
            MaintenanceWindowExceeded = maintenanceWindowExceeded;
            RebootStatus = rebootStatus;
            NotSelectedPatchCount = notSelectedPatchCount;
            ExcludedPatchCount = excludedPatchCount;
            PendingPatchCount = pendingPatchCount;
            InstalledPatchCount = installedPatchCount;
            FailedPatchCount = failedPatchCount;
            StartTime = startTime;
            LastModifiedTime = lastModifiedTime;
            StartedBy = startedBy;
            Error = error;
        }

        /// <summary> The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes. At that point it will become &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;. </summary>
        public PatchOperationStatus? Status { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string InstallationActivityId { get; }
        /// <summary> Describes whether the operation ran out of time before it completed all its intended actions. </summary>
        public bool? MaintenanceWindowExceeded { get; }
        /// <summary> The reboot status of the machine after the patch operation. It will be in &quot;NotNeeded&quot; status if reboot is not needed after the patch operation. &quot;Required&quot; will be the status once the patch is applied and machine is required to reboot. &quot;Started&quot; will be the reboot status when the machine has started to reboot. &quot;Failed&quot; will be the status if the machine is failed to reboot. &quot;Completed&quot; will be the status once the machine is rebooted successfully. </summary>
        public RebootStatus? RebootStatus { get; }
        /// <summary> The number of all available patches but not going to be installed because it didn&apos;t match a classification or inclusion list entry. </summary>
        public int? NotSelectedPatchCount { get; }
        /// <summary> The number of all available patches but excluded explicitly by a customer-specified exclusion list match. </summary>
        public int? ExcludedPatchCount { get; }
        /// <summary> The number of all available patches expected to be installed over the course of the patch installation operation. </summary>
        public int? PendingPatchCount { get; }
        /// <summary> The count of patches that successfully installed. </summary>
        public int? InstalledPatchCount { get; }
        /// <summary> The count of patches that failed installation. </summary>
        public int? FailedPatchCount { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The person or system account that started the operation. </summary>
        public string StartedBy { get; }
        /// <summary> The errors that were encountered during execution of the operation. The details array contains the list of them. </summary>
        public ApiError Error { get; }
    }
}