// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The Polymorphicrecursive service client. </summary>
    public partial class PolymorphicrecursiveClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PolymorphicrecursiveClient for mocking. </summary>
        protected PolymorphicrecursiveClient()
        {
        }

        /// <summary> Initializes a new instance of PolymorphicrecursiveClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public PolymorphicrecursiveClient(AzureKeyCredential credential) : this(credential, new Uri("http://localhost:3000"), new AutoRestComplexTestServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of PolymorphicrecursiveClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="endpoint"/> is null. </exception>
        public PolymorphicrecursiveClient(AzureKeyCredential credential, Uri endpoint, AutoRestComplexTestServiceClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new AutoRestComplexTestServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetValidAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// Response response = await client.GetValidAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("fishtype").ToString());
        /// Console.WriteLine(result.GetProperty("species").ToString());
        /// Console.WriteLine(result.GetProperty("length").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// This method takes one of the JSON objects below as a payload. Please select a JSON object to view the schema for this.
        /// <details><summary>Salmon</summary>Schema for <c>Salmon</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>~+ 5 more JSON objects</summary><details><summary>SmartSalmon</summary>Schema for <c>SmartSalmon</c>:
        /// <code>{
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   college_degree: string, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Shark</summary>Schema for <c>Shark</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Sawshark</summary>Schema for <c>Sawshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   picture: SawsharkPicture, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Goblinshark</summary>Schema for <c>Goblinshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   jawsize: number, # Optional.
        ///   color: &quot;pink&quot; | &quot;gray&quot; | &quot;brown&quot; | &quot;RED&quot; | &quot;red&quot;, # Optional. Colors possible
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Cookiecuttershark</summary>Schema for <c>Cookiecuttershark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        /// }
        /// </code>
        /// </details>
        /// </details>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetValidAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphicrecursiveClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call GetValid and parse the result.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// Response response = client.GetValid();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("fishtype").ToString());
        /// Console.WriteLine(result.GetProperty("species").ToString());
        /// Console.WriteLine(result.GetProperty("length").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// This method takes one of the JSON objects below as a payload. Please select a JSON object to view the schema for this.
        /// <details><summary>Salmon</summary>Schema for <c>Salmon</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>~+ 5 more JSON objects</summary><details><summary>SmartSalmon</summary>Schema for <c>SmartSalmon</c>:
        /// <code>{
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   college_degree: string, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Shark</summary>Schema for <c>Shark</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Sawshark</summary>Schema for <c>Sawshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   picture: SawsharkPicture, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Goblinshark</summary>Schema for <c>Goblinshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   jawsize: number, # Optional.
        ///   color: &quot;pink&quot; | &quot;gray&quot; | &quot;brown&quot; | &quot;RED&quot; | &quot;red&quot;, # Optional. Colors possible
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Cookiecuttershark</summary>Schema for <c>Cookiecuttershark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        /// }
        /// </code>
        /// </details>
        /// </details>
        /// 
        /// </remarks>
        public virtual Response GetValid(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PolymorphicrecursiveClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call PutValidAsync with required request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// var data = new {
        ///     fishtype = "salmon",
        ///     length = 1234,
        /// };
        /// 
        /// Response response = await client.PutValidAsync(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// This sample shows how to call PutValidAsync with all request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// var data = new {
        ///     fishtype = "salmon",
        ///     species = "<FishSpecies>",
        ///     length = 1234,
        ///     siblings = new[] {},
        ///     location = "<SalmonLocation>",
        ///     iswild = true,
        /// };
        /// 
        /// Response response = await client.PutValidAsync(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request payload.
        /// 
        /// Request Body:
        /// 
        /// This method takes one of the JSON objects below as a payload. Please select a JSON object to view the schema for this.
        /// <details><summary>Salmon</summary>Schema for <c>Salmon</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>~+ 5 more JSON objects</summary><details><summary>SmartSalmon</summary>Schema for <c>SmartSalmon</c>:
        /// <code>{
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   college_degree: string, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Shark</summary>Schema for <c>Shark</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Sawshark</summary>Schema for <c>Sawshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   picture: SawsharkPicture, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Goblinshark</summary>Schema for <c>Goblinshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   jawsize: number, # Optional.
        ///   color: &quot;pink&quot; | &quot;gray&quot; | &quot;brown&quot; | &quot;RED&quot; | &quot;red&quot;, # Optional. Colors possible
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Cookiecuttershark</summary>Schema for <c>Cookiecuttershark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        /// }
        /// </code>
        /// </details>
        /// </details>
        /// 
        /// </remarks>
        public virtual async Task<Response> PutValidAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphicrecursiveClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call PutValid with required request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// var data = new {
        ///     fishtype = "salmon",
        ///     length = 1234,
        /// };
        /// 
        /// Response response = client.PutValid(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// This sample shows how to call PutValid with all request content.
        /// <code><![CDATA[
        /// var credential = new AzureKeyCredential("<key>");
        /// var client = new PolymorphicrecursiveClient(credential);
        /// 
        /// var data = new {
        ///     fishtype = "salmon",
        ///     species = "<FishSpecies>",
        ///     length = 1234,
        ///     siblings = new[] {},
        ///     location = "<SalmonLocation>",
        ///     iswild = true,
        /// };
        /// 
        /// Response response = client.PutValid(RequestContent.Create(data));
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the request payload.
        /// 
        /// Request Body:
        /// 
        /// This method takes one of the JSON objects below as a payload. Please select a JSON object to view the schema for this.
        /// <details><summary>Salmon</summary>Schema for <c>Salmon</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>~+ 5 more JSON objects</summary><details><summary>SmartSalmon</summary>Schema for <c>SmartSalmon</c>:
        /// <code>{
        ///   location: string, # Optional.
        ///   iswild: boolean, # Optional.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   college_degree: string, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Shark</summary>Schema for <c>Shark</c>:
        /// <code>{
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Sawshark</summary>Schema for <c>Sawshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   picture: SawsharkPicture, # Optional.
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Goblinshark</summary>Schema for <c>Goblinshark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        ///   jawsize: number, # Optional.
        ///   color: &quot;pink&quot; | &quot;gray&quot; | &quot;brown&quot; | &quot;RED&quot; | &quot;red&quot;, # Optional. Colors possible
        /// }
        /// </code>
        /// </details>
        /// <details><summary>Cookiecuttershark</summary>Schema for <c>Cookiecuttershark</c>:
        /// <code>{
        ///   age: number, # Optional.
        ///   birthday: string (ISO 8601 Format), # Required.
        ///   fishtype: string, # Required.
        ///   species: string, # Optional.
        ///   length: number, # Required.
        ///   siblings: [
        ///     {
        ///       fishtype: string, # Required.
        ///       species: string, # Optional.
        ///       length: number, # Required.
        ///       siblings: [Fish], # Optional.
        ///     }
        ///   ], # Optional.
        /// }
        /// </code>
        /// </details>
        /// </details>
        /// 
        /// </remarks>
        public virtual Response PutValid(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PolymorphicrecursiveClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetValidRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphicrecursive/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutValidRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/polymorphicrecursive/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
