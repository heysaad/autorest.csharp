import "@cadl-lang/rest";
import "@azure-tools/cadl-dpg";
import "@azure-tools/cadl-azure-core";

@service(
    {
        title: "clientAndOperationGroupService",
        version: "2015-06-18"
    }
)
@server(
    "{operationGroupServiceUrl}",
    "OperationGroup Service",
    {
        operationGroupServiceUrl: string,
    }
)
namespace Azure.ClientAndOperationGroupService;

using Cadl.Http;
using Azure.DPG;
using Azure.Core;
using Cadl.Rest;

@autoRoute
namespace Alpha {
    #suppress "@azure-tools/cadl-azure-core/use-standard-operations" "This is test code."
    @action
    op one(): string;
}

@operationGroup
namespace Beta {
    #suppress "@azure-tools/cadl-azure-core/use-standard-operations" "This is test code."
    @route("/Beta")
    op two(): string;

    namespace SubBeta {
    #suppress "@azure-tools/cadl-azure-core/use-standard-operations" "This is test code."
        @route("/SubBeta")
        op three(): string;
    }
}

@operationGroup
namespace Gamma {
    #suppress "@azure-tools/cadl-azure-core/use-standard-operations" "This is test code."
    @route("/Gamma")
    op four(): string;

    #suppress "@azure-tools/cadl-azure-core/use-standard-operations" "This is test code."
    @route("/Gamma")
    @put op five(): string;
}

@route("/top")
op zero(): string;