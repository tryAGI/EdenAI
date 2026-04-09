
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotUpdateOperationsClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirement0 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                {                    new global::EdenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirement0,
                s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirement1,
            };
        partial void PrepareAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId,
            global::EdenAI.PatchedAskYodaProjectUpdateRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId,
            global::EdenAI.PatchedAskYodaProjectUpdateRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Project<br/>
        /// Update the default settings of the Yoda project.<br/>
        /// It allows you to modify the project's default settings,<br/>
        /// specifically changing the llm_provider (language model provider),<br/>
        /// llm_model (language model), ocr_provider (upload pdf), speech_to_text provider (upload audio)<br/>
        /// and the default chunks parameter associated with the default project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AskYodaProjectUpdate> AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync(
            global::System.Guid projectId,

            global::EdenAI.PatchedAskYodaProjectUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateSecurityRequirements,
                operationName: "AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/update_project/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.AskYodaProjectUpdate.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::EdenAI.AskYodaProjectUpdate.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Update Project<br/>
        /// Update the default settings of the Yoda project.<br/>
        /// It allows you to modify the project's default settings,<br/>
        /// specifically changing the llm_provider (language model provider),<br/>
        /// llm_model (language model), ocr_provider (upload pdf), speech_to_text provider (upload audio)<br/>
        /// and the default chunks parameter associated with the default project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ocrProvider">
        /// Default Value: amazon
        /// </param>
        /// <param name="speechToTextProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="llmProvider">
        /// Select a default LLM provider to use in your project.
        /// </param>
        /// <param name="llmModel">
        /// Select a default Model for LLM provider to use in your project
        /// </param>
        /// <param name="chunkSize"></param>
        /// <param name="chunkSeparators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AskYodaProjectUpdate> AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync(
            global::System.Guid projectId,
            string? ocrProvider = default,
            string? speechToTextProvider = default,
            string? llmProvider = default,
            string? llmModel = default,
            int? chunkSize = default,
            global::System.Collections.Generic.IList<string>? chunkSeparators = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.PatchedAskYodaProjectUpdateRequest
            {
                OcrProvider = ocrProvider,
                SpeechToTextProvider = speechToTextProvider,
                LlmProvider = llmProvider,
                LlmModel = llmModel,
                ChunkSize = chunkSize,
                ChunkSeparators = chunkSeparators,
            };

            return await AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync(
                projectId: projectId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}