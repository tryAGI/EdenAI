
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotCreateOperationsClient
    {
        partial void PrepareAiproductsAiproductsAskyodaV2CreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.AskYourDataProjectRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2CreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.AskYourDataProjectRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2CreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiproductsAiproductsAskyodaV2CreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Project<br/>
        /// Allows you to create a new Ask YODA project with specified details.<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Embedding Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`text-embedding-3-large`|<br/>
        /// |**cohere**|`embed-multilingual-v3.0`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**mistral**|`mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaCreateProjectResponse> AiproductsAiproductsAskyodaV2CreateAsync(

            global::EdenAI.AskYourDataProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2CreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/aiproducts/askyoda/v2/",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAiproductsAiproductsAskyodaV2CreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2CreateResponse(
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
                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerOptions);
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
                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerOptions);
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
                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerOptions);
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
                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerOptions);
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
                ProcessAiproductsAiproductsAskyodaV2CreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.YodaCreateProjectResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::EdenAI.YodaCreateProjectResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Project<br/>
        /// Allows you to create a new Ask YODA project with specified details.<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Embedding Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`text-embedding-3-large`|<br/>
        /// |**cohere**|`embed-multilingual-v3.0`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**mistral**|`mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="credential">
        /// The credential resource name
        /// </param>
        /// <param name="asset">
        /// The asset sub_resource name
        /// </param>
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
        /// <param name="projectName">
        /// Project name
        /// </param>
        /// <param name="collectionName">
        /// Database Collection Name
        /// </param>
        /// <param name="dbProvider">
        /// Database Provider<br/>
        /// * `qdrant` - qdrant<br/>
        /// * `supabase` - supabase<br/>
        /// Default Value: qdrant
        /// </param>
        /// <param name="embeddingsProvider">
        /// Select an embedding provider to use in your search database. Leave empty for default.<br/>
        /// * `openai` - openai<br/>
        /// * `cohere` - cohere<br/>
        /// * `google` - google<br/>
        /// * `mistral` - mistral<br/>
        /// * `jina` - jina
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaCreateProjectResponse> AiproductsAiproductsAskyodaV2CreateAsync(
            string projectName,
            string collectionName,
            global::EdenAI.EmbeddingsProviderEnum embeddingsProvider,
            string? credential = default,
            string? asset = default,
            string? ocrProvider = default,
            string? speechToTextProvider = default,
            string? llmProvider = default,
            string? llmModel = default,
            int? chunkSize = default,
            global::System.Collections.Generic.IList<string>? chunkSeparators = default,
            global::EdenAI.DbProviderEnum? dbProvider = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.AskYourDataProjectRequest
            {
                Credential = credential,
                Asset = asset,
                OcrProvider = ocrProvider,
                SpeechToTextProvider = speechToTextProvider,
                LlmProvider = llmProvider,
                LlmModel = llmModel,
                ChunkSize = chunkSize,
                ChunkSeparators = chunkSeparators,
                ProjectName = projectName,
                CollectionName = collectionName,
                DbProvider = dbProvider,
                EmbeddingsProvider = embeddingsProvider,
            };

            return await AiproductsAiproductsAskyodaV2CreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}