
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotQueryOperationsClient
    {
        partial void PrepareAiproductsAiproductsAskyodaV2QueryCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId,
            global::EdenAI.AskLLMRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2QueryCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId,
            global::EdenAI.AskLLMRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2QueryCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiproductsAiproductsAskyodaV2QueryCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query<br/>
        /// Interact with your data by selecting your preferred Language Model <br/>
        /// provider. The chosen provider will then respond to queries based on the data you have added<br/>
        /// to your collection
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaAskLlmResponse> AiproductsAiproductsAskyodaV2QueryCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AskLLMRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2QueryCreateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/query/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareAiproductsAiproductsAskyodaV2QueryCreateRequest(
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
            ProcessAiproductsAiproductsAskyodaV2QueryCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::EdenAI.BadRequest? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::EdenAI.ApiException<global::EdenAI.BadRequest>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::EdenAI.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::EdenAI.ApiException<global::EdenAI.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::EdenAI.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::EdenAI.ApiException<global::EdenAI.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::EdenAI.NotFoundResponse? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::EdenAI.ApiException<global::EdenAI.NotFoundResponse>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessAiproductsAiproductsAskyodaV2QueryCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.YodaAskLlmResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.YodaAskLlmResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Query<br/>
        /// Interact with your data by selecting your preferred Language Model <br/>
        /// provider. The chosen provider will then respond to queries based on the data you have added<br/>
        /// to your collection
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query">
        /// Enter your question or query about the data. The large language model (LLM) will provide a response.
        /// </param>
        /// <param name="llmProvider">
        /// Select a provider for the large language model for processing. Leave empty for default.
        /// </param>
        /// <param name="llmModel">
        /// Specify the model to use for language processing. Leave empty for default.
        /// </param>
        /// <param name="k">
        /// How many results chunk you want to return<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="history">
        /// A list containing all the previous conversations between the user and the chatbot AI. Each item in the list should be a dictionary with two keys: 'user' and 'assistant'.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="chatbotGlobalAction">
        /// A system message that helps set the behavior of the assistant.
        /// </param>
        /// <param name="filterDocuments">
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="minScore">
        /// A minimum score threshold for the model to consider a chunk as a valid response. Higher values mean the model will be more conservative and only return chunks that are more similar to the query. Lower values mean the model will be more open to returning chunks that are less similar to the query.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="useReranking">
        /// Activate/deactivate the reranking. This is experimental.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topN">
        /// The number of documents returned by the reranker (experimental)<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaAskLlmResponse> AiproductsAiproductsAskyodaV2QueryCreateAsync(
            global::System.Guid projectId,
            string query,
            string? llmProvider = default,
            string? llmModel = default,
            int? k = default,
            global::System.Collections.Generic.IList<object>? history = default,
            string? chatbotGlobalAction = default,
            object? filterDocuments = default,
            double? minScore = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Guid? conversationId = default,
            bool? useReranking = default,
            int? topN = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::EdenAI.AskLLMRequest
            {
                Query = query,
                LlmProvider = llmProvider,
                LlmModel = llmModel,
                K = k,
                History = history,
                ChatbotGlobalAction = chatbotGlobalAction,
                FilterDocuments = filterDocuments,
                MinScore = minScore,
                Temperature = temperature,
                MaxTokens = maxTokens,
                ConversationId = conversationId,
                UseReranking = useReranking,
                TopN = topN,
            };

            return await AiproductsAiproductsAskyodaV2QueryCreateAsync(
                projectId: projectId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}