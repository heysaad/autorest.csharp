// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for ManagedHsmCollection. </summary>
    public partial class ManagedHsmCollectionMockTests : MockTestBase
    {
        public ManagedHsmCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create a new managed HSM Pool or update an existing managed HSM Pool

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "hsm-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetManagedHsms();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "hsm1", new ManagedHsmData("westus")
            {
                Properties = new ManagedHsmProperties()
                {
                    TenantId = new Guid("00000000-0000-0000-0000-000000000000"),
                    InitialAdminObjectIds =
{
"00000000-0000-0000-0000-000000000000"
},
                    EnableSoftDelete = true,
                    SoftDeleteRetentionInDays = 90,
                    EnablePurgeProtection = true,
                },
                Sku = new ManagedHsmSku(ManagedHsmSkuFamily.B, ManagedHsmSkuName.StandardB1),
                Tags =
{
["Dept"] = "hsm",
["Environment"] = "dogfood",
},
            });
        }

        [RecordedTest]
        public async Task Exists()
        {
            // Example: Retrieve a managed HSM Pool

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "hsm-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetManagedHsms();
            await collection.ExistsAsync("hsm1");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a managed HSM Pool

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "hsm-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetManagedHsms();
            await collection.GetAsync("hsm1");
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List managed HSM Pools in a resource group

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "hsm-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetManagedHsms();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
