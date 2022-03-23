// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtHierarchicalNonResource.Models;

namespace MgmtHierarchicalNonResource
{
    /// <summary>
    /// A Class representing a SharedGallery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SharedGalleryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSharedGalleryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSharedGallery method.
    /// </summary>
    public partial class SharedGalleryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SharedGalleryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string galleryUniqueName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sharedGalleryClientDiagnostics;
        private readonly SharedGalleriesRestOperations _sharedGalleryRestClient;
        private readonly ClientDiagnostics _sharedGalleryImagesClientDiagnostics;
        private readonly SharedGalleryImagesRestOperations _sharedGalleryImagesRestClient;
        private readonly ClientDiagnostics _sharedGalleryImageVersionsClientDiagnostics;
        private readonly SharedGalleryImageVersionsRestOperations _sharedGalleryImageVersionsRestClient;
        private readonly SharedGalleryData _data;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryResource"/> class for mocking. </summary>
        protected SharedGalleryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SharedGalleryResource(ArmClient client, SharedGalleryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SharedGalleryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryClientDiagnostics = new ClientDiagnostics("MgmtHierarchicalNonResource", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sharedGalleryApiVersion);
            _sharedGalleryRestClient = new SharedGalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryApiVersion);
            _sharedGalleryImagesClientDiagnostics = new ClientDiagnostics("MgmtHierarchicalNonResource", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _sharedGalleryImagesRestClient = new SharedGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _sharedGalleryImageVersionsClientDiagnostics = new ClientDiagnostics("MgmtHierarchicalNonResource", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _sharedGalleryImageVersionsRestClient = new SharedGalleryImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SharedGalleryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SharedGalleryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryResource.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGalleryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryResource.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared gallery images by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images
        /// Operation Id: SharedGalleryImages_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryImage> GetSharedGalleryImagesAsync(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedGalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImages");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImagesRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedGalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImages");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImagesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List shared gallery images by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images
        /// Operation Id: SharedGalleryImages_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryImage> GetSharedGalleryImages(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Page<SharedGalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImages");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImagesRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedGalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImages");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImagesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryImage>> GetSharedGalleryImageAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImage");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImagesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<SharedGalleryImage> GetSharedGalleryImage(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImagesClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImage");
            scope.Start();
            try
            {
                var response = _sharedGalleryImagesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared gallery image versions by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions
        /// Operation Id: SharedGalleryImageVersions_List
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        /// <returns> An async collection of <see cref="SharedGalleryImageVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryImageVersion> GetSharedGalleryImageVersionsAsync(string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            async Task<Page<SharedGalleryImageVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersions");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImageVersionsRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedGalleryImageVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersions");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImageVersionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List shared gallery image versions by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions
        /// Operation Id: SharedGalleryImageVersions_List
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        /// <returns> A collection of <see cref="SharedGalleryImageVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryImageVersion> GetSharedGalleryImageVersions(string galleryImageName, SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            Page<SharedGalleryImageVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersions");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImageVersionsRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedGalleryImageVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersions");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImageVersionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: SharedGalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryImageVersion>> GetSharedGalleryImageVersionAsync(string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersion");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageVersionsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, galleryImageVersionName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: SharedGalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<SharedGalleryImageVersion> GetSharedGalleryImageVersion(string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionsClientDiagnostics.CreateScope("SharedGalleryResource.GetSharedGalleryImageVersion");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageVersionsRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, galleryImageVersionName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}