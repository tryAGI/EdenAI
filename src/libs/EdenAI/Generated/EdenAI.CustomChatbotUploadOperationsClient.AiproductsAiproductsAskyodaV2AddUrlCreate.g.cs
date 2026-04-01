
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotUploadOperationsClient
    {
        partial void PrepareAiproductsAiproductsAskyodaV2AddUrlCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId,
            global::EdenAI.AddUrlRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2AddUrlCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId,
            global::EdenAI.AddUrlRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2AddUrlCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Add Urls<br/>
        /// Add a list of URLs into your projects,<br/>
        /// they will be processed and stored as text embeddings within your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddUrlCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2AddUrlCreateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/add_url/",
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
            PrepareAiproductsAiproductsAskyodaV2AddUrlCreateRequest(
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
            ProcessAiproductsAiproductsAskyodaV2AddUrlCreateResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Add Urls<br/>
        /// Add a list of URLs into your projects,<br/>
        /// they will be processed and stored as text embeddings within your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="urls">
        /// Add multiple urls into the database, it loads all the text from HTML webpages into a document format.
        /// </param>
        /// <param name="jsRender">
        /// Enable JavaScript rendering for the provided URLs.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddUrlCreateAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string> urls,
            global::System.Collections.Generic.IList<bool>? jsRender = default,
            global::System.Collections.Generic.IList<object>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::EdenAI.AddUrlRequest
            {
                Urls = urls,
                JsRender = jsRender,
                Metadata = metadata,
            };

            await AiproductsAiproductsAskyodaV2AddUrlCreateAsync(
                projectId: projectId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}