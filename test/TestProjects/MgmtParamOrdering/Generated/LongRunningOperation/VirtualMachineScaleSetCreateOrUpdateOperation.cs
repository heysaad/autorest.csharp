// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtParamOrdering;

namespace MgmtParamOrdering.Models
{
    /// <summary> required body, required header;Create or update a VM scale set. </summary>
    public partial class VirtualMachineScaleSetCreateOrUpdateOperation : Operation<VirtualMachineScaleSet>, IOperationSource<VirtualMachineScaleSet>
    {
        private readonly OperationInternals<VirtualMachineScaleSet> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSet>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSet Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSet>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSet>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSet IOperationSource<VirtualMachineScaleSet>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineScaleSetData.DeserializeVirtualMachineScaleSetData(document.RootElement);
            return new VirtualMachineScaleSet(_armClient, data);
        }

        async ValueTask<VirtualMachineScaleSet> IOperationSource<VirtualMachineScaleSet>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineScaleSetData.DeserializeVirtualMachineScaleSetData(document.RootElement);
            return new VirtualMachineScaleSet(_armClient, data);
        }
    }
}
