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
    /// <summary> Test for VaultResource. </summary>
    public partial class VaultResourceMockTests : MockTestBase
    {
        public VaultResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a vault

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            await vaultResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            await vaultResource.GetAsync();
        }

        [RecordedTest]
        public async Task GetPrivateLinkResources()
        {
            // Example: KeyVaultListPrivateLinkResources

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            await foreach (var _ in vaultResource.GetPrivateLinkResourcesAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetVaults()
        {
            // Example: List vaults in the specified subscription

            var subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000");
            var subscriptionResource = GetArmClient().GetSubscriptionResource(subscriptionResourceId);
            await foreach (var _ in subscriptionResource.GetVaultsAsync())
            {
            }
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update an existing vault

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            await vaultResource.UpdateAsync(new VaultPatch()
            {
                Properties = new VaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new MgmtKeyvaultSku(MgmtKeyvaultSkuFamily.A, MgmtKeyvaultSkuName.Standard),
                    AccessPolicies =
{
new AccessPolicyEntry(Guid.Parse("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new Permissions()
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
                },
            });
        }

        [RecordedTest]
        public async Task UpdateAccessPolicy()
        {
            // Example: Add an access policy, or update an access policy with new permissions

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            await vaultResource.UpdateAccessPolicyAsync(AccessPolicyUpdateKind.Add, new VaultAccessPolicyParameters(new VaultAccessPolicyProperties(new MgmtKeyvault.Models.AccessPolicyEntry[]
            {
new AccessPolicyEntry(Guid.Parse("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new Permissions()
{
Keys =
{
KeyPermissions.Encrypt
},
Secrets =
{
SecretPermissions.Get
},
Certificates =
{
CertificatePermissions.Get
},
})
            })));
        }
    }
}
