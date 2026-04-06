
#nullable enable

namespace EdenAI
{
    public partial class PromptsClient
    {
        partial void PreparePromptsPromptsCreate2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            global::EdenAI.PromptCallRequest request);
        partial void PreparePromptsPromptsCreate2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            global::EdenAI.PromptCallRequest request);
        partial void ProcessPromptsPromptsCreate2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPromptsPromptsCreate2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Call prompt<br/>
        /// Call prompt with your variables in prompt_context. You can override params saved in the prompt and specifiy file urls
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsCreate2Async(
            string name,

            global::EdenAI.PromptCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePromptsPromptsCreate2Arguments(
                httpClient: HttpClient,
                name: ref name,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/prompts/{name}/",
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
            PreparePromptsPromptsCreate2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPromptsPromptsCreate2Response(
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
                ProcessPromptsPromptsCreate2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.PromptUpdate.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.PromptUpdate.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Call prompt<br/>
        /// Call prompt with your variables in prompt_context. You can override params saved in the prompt and specifiy file urls
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model">
        /// Optional model override (e.g., 'openai/gpt-4o'). If not provided, the model specified in the prompt will be used.
        /// </param>
        /// <param name="promptContext">
        /// Variables to inject into the prompt template.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "my_variable": "some_value",<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="params">
        /// Optional params override. If not provided, the default params in the prompt will be used<br/>
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="fileUrls">
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models. Overrides the file urls set on the prompt.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsCreate2Async(
            string name,
            string? model = default,
            object? promptContext = default,
            object? @params = default,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.PromptCallRequest
            {
                Model = model,
                PromptContext = promptContext,
                Params = @params,
                FileUrls = fileUrls,
            };

            return await PromptsPromptsCreate2Async(
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}