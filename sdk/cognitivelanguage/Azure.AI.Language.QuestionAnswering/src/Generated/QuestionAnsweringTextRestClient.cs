// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.QuestionAnswering.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Language.QuestionAnswering
{
    internal partial class QuestionAnsweringTextRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of QuestionAnsweringTextRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt;resource-name&gt;.api.cognitiveservices.azure.com). </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public QuestionAnsweringTextRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2021-05-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateQueryRequest(TextQueryOptions textQueryParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/:query-text", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(textQueryParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Answers the specified question using the provided text in the body. </summary>
        /// <param name="textQueryParameters"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="textQueryParameters"/> is null. </exception>
        public async Task<Response<TextAnswers>> QueryAsync(TextQueryOptions textQueryParameters, CancellationToken cancellationToken = default)
        {
            if (textQueryParameters == null)
            {
                throw new ArgumentNullException(nameof(textQueryParameters));
            }

            using var message = CreateQueryRequest(textQueryParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TextAnswers value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TextAnswers.DeserializeTextAnswers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Answers the specified question using the provided text in the body. </summary>
        /// <param name="textQueryParameters"> Post body of the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="textQueryParameters"/> is null. </exception>
        public Response<TextAnswers> Query(TextQueryOptions textQueryParameters, CancellationToken cancellationToken = default)
        {
            if (textQueryParameters == null)
            {
                throw new ArgumentNullException(nameof(textQueryParameters));
            }

            using var message = CreateQueryRequest(textQueryParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TextAnswers value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TextAnswers.DeserializeTextAnswers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
