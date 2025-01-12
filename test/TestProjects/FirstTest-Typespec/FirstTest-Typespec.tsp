import "@typespec/rest";
import "@typespec/http";
import "@typespec/openapi";
import "@azure-tools/typespec-client-generator-core";
import "@azure-tools/typespec-azure-core";

@service(
    {
        title: "hello world",
        version: "0.1.0"
    }
)
@doc("This is a sample cadl project.")
@server(
    "{firstTestCadlUrl}",
    "Endpoint Service",
    {
        firstTestCadlUrl: string,
    }
)
@useAuth(OAuth2Auth<[AuthFlow]> | ApiKeyAuth<ApiKeyLocation.header, "x-ms-api-key">)
namespace CadlFirstTest;

model AuthFlow {
    type: OAuth2FlowType.clientCredentials;
    tokenUrl: "https://api.example.com/oauth2/token";
    refreshUrl: "https://api.example.com/oauth2/refresh";
    scopes: [
        "https://api.example.com/.default"
    ]
}

using TypeSpec.Http;
using Azure.ClientGenerator.Core;
using Azure.Core;

@doc("Simple enum")
@fixed
enum SimpleEnum {
    One: "1",
    Two: "2",
    Four: "4"
}

@doc("Extensible enum")
enum ExtensibleEnum {
    One: "1",
    Two: "2",
    Four: "4"
}

model Thing {
  @doc("name of the Thing")
  name: string;

  @doc("required Union")
  requiredUnion: string | string[]|int32;

  @doc("required literal string")
  requiredLiteralString: "accept";

  @doc("required literal int")
  requiredLiteralInt: 123;

  @doc("required literal double")
  requiredLiteralDouble: 1.23;

  @doc("required literal bool")
  requiredLiteralBool: false;

  @doc("optional literal string")
  optionalLiteralString?: "reject";

  @doc("optional literal int")
  optionalLiteralInt?: 456;

  @doc("optional literal double")
  optionalLiteralDouble?: 4.56;

  @doc("optional literal bool")
  optionalLiteralBool?: true;

  @doc("description with xml <|endoftext|>")
  requiredBadDescription: string
}

@friendlyName("Friend")
model NotFriend {
  @doc("name of the NotFriend")
  name: string;
}

model RoundTripModel {
  @doc("Required string, illustrating a reference type property.")
  requiredString: string;

  @doc("Required int, illustrating a value type property.")
  requiredInt: int32;

  @doc("Required collection of enums")
  requiredCollection: SimpleEnum[];

  @doc("Required dictionary of enums")
  requiredDictionary: Record<ExtensibleEnum>;

  @doc("Required model")
  requiredModel: Thing;
}

enum DaysOfWeekExtensibleEnum {
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
  "Sunday",
}

@doc("Hello world service")
@route("/hello")
namespace Hello.Demo {
    @doc("Return hi")
    @get
    op sayHi(@header headParameter: string, @query queryParameter: string, @query optionalQuery?: string): Thing;
}

namespace Hello.Demo2 {
    @route("/againHi")
    @doc("Return hi again")
    @get
    @convenientAPI(true)
    op helloAgain(@header p1: string, @body action: RoundTripModel, @header contentType: "text/plain", @path p2: string): Thing;

    @route("/noContentType")
    @doc("Return hi again")
    @get
    @convenientAPI(false)
    op noContentType(@header p1: string, @body action: RoundTripModel, @path p2: string): Thing;

    @route("/demoHi")
    @doc("Return hi in demo2")
    @get
    @convenientAPI(true)
    op helloDemo2(): Thing;

    @route("/literal")
    @doc("Create with literal value")
    @post
    @convenientAPI(true)
    op createLiteral(@body body: Thing): Thing;

    @route("/helloLiteral")
    @doc("Send literal parameters")
    @get
    @convenientAPI(true)
    op helloLiteral(@header p1: "test", @path p2: 123, @query p3: true): Thing;
}

@route("/top")
@doc("top level method")
@get
@convenientAPI(true)
op topAction(@path @format("date") action: string): Thing;

@route("/top2")
@doc("top level method2")
@get
@convenientAPI(false)
op topAction2(): Thing;


@route("/patch")
@doc("top level patch")
@patch
@convenientAPI(true)
op patchAction(@body body: Thing): Thing;

@route("/anonymousBody")
@doc("body parameter without body decorator")
@post
@convenientAPI(true)
op anonymousBody( ...Thing ): Thing;

@route("/friendlyName")
@doc("Model can have its friendly name")
@post
@convenientAPI(true)
op friendlyModel(...NotFriend): NotFriend;

op addTimeHeader(@header("Repeatability-First-Sent") repeatabilityFirstSent?: zonedDateTime): void;

namespace EnumTest {
    @get
    @route("/unknown-value")
    @doc("get extensible enum")
    op getUnknownValue(): DaysOfWeekExtensibleEnum;
}

namespace ProtocolAndConvenient {
  @doc("When set protocol false and convenient true, then the protocol method should be internal")
  @route("internalProtocol")
  @post
  @convenientAPI(true)
  @protocolAPI(false)
  op internalProtocol(@body body: Thing): Thing;  

  @doc("When set protocol false and convenient true, the convenient method should be generated even it has the same signature as protocol one")
  @route("stillConvenient")
  @get
  @convenientAPI(true)
  @protocolAPI(false)
  op stillConvenient(): void;
}
