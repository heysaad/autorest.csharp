// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtLRO
{
    /// <summary> A class to add extension methods to MgmtLRO. </summary>
    public static partial class MgmtLROExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of Fakes in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Fakes and their operations over a Fake. </returns>
        public static FakeCollection GetFakes(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetFakes();
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public static async Task<Response<Fake>> GetFakeAsync(this ResourceGroup resourceGroup, string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetFakes().GetAsync(fakeName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public static Response<Fake> GetFake(this ResourceGroup resourceGroup, string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetFakes().Get(fakeName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of Bars in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Bars and their operations over a Bar. </returns>
        public static BarCollection GetBars(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetBars();
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public static async Task<Response<Bar>> GetBarAsync(this ResourceGroup resourceGroup, string barName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetBars().GetAsync(barName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public static Response<Bar> GetBar(this ResourceGroup resourceGroup, string barName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetBars().Get(barName, cancellationToken);
        }

        #region Fake
        /// <summary>
        /// Gets an object representing a <see cref="Fake" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="Fake.CreateResourceIdentifier" /> to create a <see cref="Fake" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Fake" /> object. </returns>
        public static Fake GetFake(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                Fake.ValidateResourceId(id);
                return new Fake(client, id);
            }
            );
        }
        #endregion

        #region Bar
        /// <summary>
        /// Gets an object representing a <see cref="Bar" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="Bar.CreateResourceIdentifier" /> to create a <see cref="Bar" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Bar" /> object. </returns>
        public static Bar GetBar(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                Bar.ValidateResourceId(id);
                return new Bar(client, id);
            }
            );
        }
        #endregion
    }
}