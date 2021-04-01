// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> Specifies Windows operating system settings on the virtual machine. </summary>
    public partial class WindowsConfiguration
    {
        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        public WindowsConfiguration()
        {
            AdditionalUnattendContent = new ChangeTrackingList<AdditionalUnattendContent>();
        }

        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        /// <param name="provisionVMAgent"> Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </param>
        /// <param name="enableAutomaticUpdates"> Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true. &lt;br&gt;&lt;br&gt; For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning. </param>
        /// <param name="timeZone"> Specifies the time zone of the virtual machine. e.g. &quot;Pacific Standard Time&quot;. &lt;br&gt;&lt;br&gt; Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.getsystemtimezones). </param>
        /// <param name="additionalUnattendContent"> Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. </param>
        /// <param name="patchSettings"> Specifies settings related to in-guest patching (KBs). </param>
        /// <param name="winRM"> Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell. </param>
        internal WindowsConfiguration(bool? provisionVMAgent, bool? enableAutomaticUpdates, string timeZone, IList<AdditionalUnattendContent> additionalUnattendContent, PatchSettings patchSettings, WinRMConfiguration winRM)
        {
            ProvisionVMAgent = provisionVMAgent;
            EnableAutomaticUpdates = enableAutomaticUpdates;
            TimeZone = timeZone;
            AdditionalUnattendContent = additionalUnattendContent;
            PatchSettings = patchSettings;
            WinRM = winRM;
        }

        /// <summary> Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </summary>
        public bool? ProvisionVMAgent { get; set; }
        /// <summary> Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true. &lt;br&gt;&lt;br&gt; For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning. </summary>
        public bool? EnableAutomaticUpdates { get; set; }
        /// <summary> Specifies the time zone of the virtual machine. e.g. &quot;Pacific Standard Time&quot;. &lt;br&gt;&lt;br&gt; Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.getsystemtimezones). </summary>
        public string TimeZone { get; set; }
        /// <summary> Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. </summary>
        public IList<AdditionalUnattendContent> AdditionalUnattendContent { get; }
        /// <summary> Specifies settings related to in-guest patching (KBs). </summary>
        public PatchSettings PatchSettings { get; set; }
        /// <summary> Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell. </summary>
        public WinRMConfiguration WinRM { get; set; }
    }
}