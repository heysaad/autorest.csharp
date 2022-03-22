// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to Azure.Management.Storage. </summary>
    public static partial class StorageExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedAccounts in the Subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAccounts and their operations over a DeletedAccount. </returns>
        public static DeletedAccountCollection GetDeletedAccounts(this Subscription subscription)
        {
            return GetExtensionClient(subscription).GetDeletedAccounts();
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public static async Task<Response<DeletedAccount>> GetDeletedAccountAsync(this Subscription subscription, string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return await subscription.GetDeletedAccounts().GetAsync(location, deletedAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}
        /// Operation Id: DeletedAccounts_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public static Response<DeletedAccount> GetDeletedAccount(this Subscription subscription, string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            return subscription.GetDeletedAccounts().Get(location, deletedAccountName, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSkuInformation> GetSkusAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSkuInformation> GetSkus(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetSkus(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccount> GetStorageAccountsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetStorageAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccount> GetStorageAccounts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetStorageAccounts(cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageUsage> GetUsagesByLocationAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageUsage> GetUsagesByLocation(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsagesByLocation(location, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of StorageAccounts in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageAccounts and their operations over a StorageAccount. </returns>
        public static StorageAccountCollection GetStorageAccounts(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetStorageAccounts();
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static async Task<Response<StorageAccount>> GetStorageAccountAsync(this ResourceGroup resourceGroup, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetStorageAccounts().GetAsync(accountName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static Response<StorageAccount> GetStorageAccount(this ResourceGroup resourceGroup, string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetStorageAccounts().Get(accountName, expand, cancellationToken);
        }

        #region BlobService
        /// <summary>
        /// Gets an object representing a <see cref="BlobService" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobService.CreateResourceIdentifier" /> to create a <see cref="BlobService" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobService" /> object. </returns>
        public static BlobService GetBlobService(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobService.ValidateResourceId(id);
                return new BlobService(client, id);
            }
            );
        }
        #endregion

        #region BlobContainer
        /// <summary>
        /// Gets an object representing a <see cref="BlobContainer" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobContainer.CreateResourceIdentifier" /> to create a <see cref="BlobContainer" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainer" /> object. </returns>
        public static BlobContainer GetBlobContainer(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobContainer.ValidateResourceId(id);
                return new BlobContainer(client, id);
            }
            );
        }
        #endregion

        #region ImmutabilityPolicy
        /// <summary>
        /// Gets an object representing an <see cref="ImmutabilityPolicy" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImmutabilityPolicy.CreateResourceIdentifier" /> to create an <see cref="ImmutabilityPolicy" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicy" /> object. </returns>
        public static ImmutabilityPolicy GetImmutabilityPolicy(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ImmutabilityPolicy.ValidateResourceId(id);
                return new ImmutabilityPolicy(client, id);
            }
            );
        }
        #endregion

        #region FileService
        /// <summary>
        /// Gets an object representing a <see cref="FileService" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileService.CreateResourceIdentifier" /> to create a <see cref="FileService" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileService" /> object. </returns>
        public static FileService GetFileService(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileService.ValidateResourceId(id);
                return new FileService(client, id);
            }
            );
        }
        #endregion

        #region FileShare
        /// <summary>
        /// Gets an object representing a <see cref="FileShare" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileShare.CreateResourceIdentifier" /> to create a <see cref="FileShare" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShare" /> object. </returns>
        public static FileShare GetFileShare(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FileShare.ValidateResourceId(id);
                return new FileShare(client, id);
            }
            );
        }
        #endregion

        #region StorageAccount
        /// <summary>
        /// Gets an object representing a <see cref="StorageAccount" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccount.CreateResourceIdentifier" /> to create a <see cref="StorageAccount" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccount" /> object. </returns>
        public static StorageAccount GetStorageAccount(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageAccount.ValidateResourceId(id);
                return new StorageAccount(client, id);
            }
            );
        }
        #endregion

        #region DeletedAccount
        /// <summary>
        /// Gets an object representing a <see cref="DeletedAccount" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAccount.CreateResourceIdentifier" /> to create a <see cref="DeletedAccount" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccount" /> object. </returns>
        public static DeletedAccount GetDeletedAccount(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeletedAccount.ValidateResourceId(id);
                return new DeletedAccount(client, id);
            }
            );
        }
        #endregion

        #region ManagementPolicy
        /// <summary>
        /// Gets an object representing a <see cref="ManagementPolicy" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementPolicy.CreateResourceIdentifier" /> to create a <see cref="ManagementPolicy" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementPolicy" /> object. </returns>
        public static ManagementPolicy GetManagementPolicy(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagementPolicy.ValidateResourceId(id);
                return new ManagementPolicy(client, id);
            }
            );
        }
        #endregion

        #region BlobInventoryPolicy
        /// <summary>
        /// Gets an object representing a <see cref="BlobInventoryPolicy" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobInventoryPolicy.CreateResourceIdentifier" /> to create a <see cref="BlobInventoryPolicy" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicy" /> object. </returns>
        public static BlobInventoryPolicy GetBlobInventoryPolicy(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlobInventoryPolicy.ValidateResourceId(id);
                return new BlobInventoryPolicy(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary>
        /// Gets an object representing a <see cref="PrivateEndpointConnection" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateEndpointConnection.CreateResourceIdentifier" /> to create a <see cref="PrivateEndpointConnection" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnection.ValidateResourceId(id);
                return new PrivateEndpointConnection(client, id);
            }
            );
        }
        #endregion

        #region ObjectReplicationPolicy
        /// <summary>
        /// Gets an object representing an <see cref="ObjectReplicationPolicy" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ObjectReplicationPolicy.CreateResourceIdentifier" /> to create an <see cref="ObjectReplicationPolicy" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicy" /> object. </returns>
        public static ObjectReplicationPolicy GetObjectReplicationPolicy(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ObjectReplicationPolicy.ValidateResourceId(id);
                return new ObjectReplicationPolicy(client, id);
            }
            );
        }
        #endregion

        #region EncryptionScope
        /// <summary>
        /// Gets an object representing an <see cref="EncryptionScope" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EncryptionScope.CreateResourceIdentifier" /> to create an <see cref="EncryptionScope" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScope" /> object. </returns>
        public static EncryptionScope GetEncryptionScope(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EncryptionScope.ValidateResourceId(id);
                return new EncryptionScope(client, id);
            }
            );
        }
        #endregion
    }
}