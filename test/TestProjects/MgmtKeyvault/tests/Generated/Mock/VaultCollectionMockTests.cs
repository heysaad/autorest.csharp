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
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for VaultCollection. </summary>
    public partial class VaultCollectionMockTests : MockTestBase
    {
        public VaultCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate_CreateANewVaultOrUpdateAnExistingVault()
        {
            // Example: Create a new vault or update an existing vault

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetVaults();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "sample-vault", new VaultCreateOrUpdateContent("westus", new VaultProperties(new Guid("00000000-0000-0000-0000-000000000000"), new MgmtKeyvaultSku(MgmtKeyvaultSkuFamily.A, MgmtKeyvaultSkuName.Standard))
            {
                AccessPolicies =
{
new AccessPolicyEntry(new Guid("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new Permissions()
{
Keys =
{
KeyPermissions.Encrypt,KeyPermissions.Decrypt,KeyPermissions.WrapKey,KeyPermissions.UnwrapKey,KeyPermissions.Sign,KeyPermissions.Verify,KeyPermissions.Get,KeyPermissions.List,KeyPermissions.Create,KeyPermissions.Update,KeyPermissions.Import,KeyPermissions.Delete,KeyPermissions.Backup,KeyPermissions.Restore,KeyPermissions.Recover,KeyPermissions.Purge
},
Secrets =
{
SecretPermissions.Get,SecretPermissions.List,SecretPermissions.Set,SecretPermissions.Delete,SecretPermissions.Backup,SecretPermissions.Restore,SecretPermissions.Recover,SecretPermissions.Purge
},
Certificates =
{
CertificatePermissions.Get,CertificatePermissions.List,CertificatePermissions.Delete,CertificatePermissions.Create,CertificatePermissions.Import,CertificatePermissions.Update,CertificatePermissions.Managecontacts,CertificatePermissions.Getissuers,CertificatePermissions.Listissuers,CertificatePermissions.Setissuers,CertificatePermissions.Deleteissuers,CertificatePermissions.Manageissuers,CertificatePermissions.Recover,CertificatePermissions.Purge
},
})
},
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
            }));
        }

        [RecordedTest]
        public async Task CreateOrUpdate_CreateOrUpdateAVaultWithNetworkAcls()
        {
            // Example: Create or update a vault with network acls

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetVaults();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "sample-vault", new VaultCreateOrUpdateContent("westus", new VaultProperties(new Guid("00000000-0000-0000-0000-000000000000"), new MgmtKeyvaultSku(MgmtKeyvaultSkuFamily.A, MgmtKeyvaultSkuName.Standard))
            {
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
                NetworkAcls = new NetworkRuleSet()
                {
                    Bypass = NetworkRuleBypassOptions.AzureServices,
                    DefaultAction = NetworkRuleAction.Deny,
                    IpRules =
{
new IPRule("124.56.78.91"),new IPRule("'10.91.4.0/24'")
},
                    VirtualNetworkRules =
{
new VirtualNetworkRule("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1")
},
                },
            }));
        }

        [RecordedTest]
        public async Task Exists()
        {
            // Example: Retrieve a vault

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetVaults();
            await collection.ExistsAsync("sample-vault");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetVaults();
            await collection.GetAsync("sample-vault");
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List vaults in the specified resource group

            var resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group");
            var resourceGroupResource = GetArmClient().GetResourceGroupResource(resourceGroupResourceId);
            var collection = resourceGroupResource.GetVaults();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
