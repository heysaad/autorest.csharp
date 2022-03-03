// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultResourceMockTests : MockTestBase
    {
        public VaultResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
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
        public async Task Delete()
        {
            // Example: Delete a vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await vaultResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update an existing vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.VaultPatch patch = new MgmtKeyvault.Models.VaultPatch()
            {
                Properties = new MgmtKeyvault.Models.VaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new MgmtKeyvault.Models.MgmtKeyvaultSku(family: new MgmtKeyvault.Models.MgmtKeyvaultSkuFamily("A"), name: MgmtKeyvault.Models.MgmtKeyvaultSkuName.Standard),
                    EnabledForDeployment = true,
                    EnabledForDiskEncryption = true,
                    EnabledForTemplateDeployment = true,
                },
            };
            options.Properties.AccessPolicies.Add(new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), objectId: "00000000-0000-0000-0000-000000000000", permissions: new MgmtKeyvault.Models.Permissions()));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("encrypt"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("decrypt"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("wrapKey"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("unwrapKey"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("sign"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("verify"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("get"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("list"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("create"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("update"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("import"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("delete"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("backup"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("restore"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("recover"));
            options.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("purge"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("get"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("list"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("set"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("delete"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("backup"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("restore"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("recover"));
            options.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("purge"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("get"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("list"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("delete"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("create"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("import"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("update"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("managecontacts"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("getissuers"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("listissuers"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("setissuers"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("deleteissuers"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("manageissuers"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("recover"));
            options.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("purge"));

            await vaultResource.UpdateAsync(patch);
        }

        [RecordedTest]
        public async Task UpdateAccessPolicy()
        {
            // Example: Add an access policy, or update an access policy with new permissions
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.AccessPolicyUpdateKind operationKind = MgmtKeyvault.Models.AccessPolicyUpdateKind.Add;
            MgmtKeyvault.Models.VaultAccessPolicyParameters vaultAccessPolicyParameters = new MgmtKeyvault.Models.VaultAccessPolicyParameters(properties: new MgmtKeyvault.Models.VaultAccessPolicyProperties(accessPolicies: new List<MgmtKeyvault.Models.AccessPolicyEntry>()
{
new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"),objectId: "00000000-0000-0000-0000-000000000000",permissions: new MgmtKeyvault.Models.Permissions()),}));
            parameters.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("encrypt"));
            parameters.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("get"));
            parameters.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("get"));

            await vaultResource.UpdateAccessPolicyAsync(operationKind, vaultAccessPolicyParameters);
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
    }
}
