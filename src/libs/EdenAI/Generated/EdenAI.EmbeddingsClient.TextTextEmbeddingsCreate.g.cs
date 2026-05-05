
#nullable enable

namespace EdenAI
{
    public partial class EmbeddingsClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_TextTextEmbeddingsCreateSecurityRequirement0 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                {                    new global::EdenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "FeatureApiAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_TextTextEmbeddingsCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_TextTextEmbeddingsCreateSecurityRequirement0,
            };
        partial void PrepareTextTextEmbeddingsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.TextembeddingsEmbeddingsRequest request);
        partial void PrepareTextTextEmbeddingsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.TextembeddingsEmbeddingsRequest request);
        partial void ProcessTextTextEmbeddingsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextTextEmbeddingsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Embeddings<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**1536__text-embedding-ada-002**|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-large**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-small**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002-v2**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-embedding-001**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-v4.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**mistral**|**1024__mistral-embed**|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral/mistral-embed**|`v0.0.1`|0.1 (per 1000000 seconde)|1 seconde<br/>
        /// |**mistral**|**mistral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed-2505**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**jina**|-|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v2-base-en**|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v3**|`v1`|0.02 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-embeddings' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`1536__text-embedding-ada-002`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**cohere**|`4096__embed-english-v2.0`|<br/>
        /// |**mistral**|`1024__mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextembeddingsResponseModel> TextTextEmbeddingsCreateAsync(

            global::EdenAI.TextembeddingsEmbeddingsRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TextTextEmbeddingsCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Embeddings<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**1536__text-embedding-ada-002**|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-large**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-small**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002-v2**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-embedding-001**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-v4.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**mistral**|**1024__mistral-embed**|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral/mistral-embed**|`v0.0.1`|0.1 (per 1000000 seconde)|1 seconde<br/>
        /// |**mistral**|**mistral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed-2505**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**jina**|-|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v2-base-en**|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v3**|`v1`|0.02 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-embeddings' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`1536__text-embedding-ada-002`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**cohere**|`4096__embed-english-v2.0`|<br/>
        /// |**mistral**|`1024__mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TextembeddingsResponseModel>> TextTextEmbeddingsCreateAsResponseAsync(

            global::EdenAI.TextembeddingsEmbeddingsRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTextTextEmbeddingsCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TextTextEmbeddingsCreateSecurityRequirements,
                operationName: "TextTextEmbeddingsCreateAsync");

            using var __timeoutCancellationTokenSource = global::EdenAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::EdenAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::EdenAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::EdenAI.PathBuilder(
                                path: "/text/embeddings/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::EdenAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTextTextEmbeddingsCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextEmbeddingsCreate",
                                methodName: "TextTextEmbeddingsCreateAsync",
                                pathTemplate: "\"/text/embeddings/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::EdenAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextEmbeddingsCreate",
                                methodName: "TextTextEmbeddingsCreateAsync",
                                pathTemplate: "\"/text/embeddings/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::EdenAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::EdenAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextEmbeddingsCreate",
                                methodName: "TextTextEmbeddingsCreateAsync",
                                pathTemplate: "\"/text/embeddings/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessTextTextEmbeddingsCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextEmbeddingsCreate",
                                methodName: "TextTextEmbeddingsCreateAsync",
                                pathTemplate: "\"/text/embeddings/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextEmbeddingsCreate",
                                methodName: "TextTextEmbeddingsCreateAsync",
                                pathTemplate: "\"/text/embeddings/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::EdenAI.BadRequest? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessTextTextEmbeddingsCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::EdenAI.TextembeddingsResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TextembeddingsResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::EdenAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::EdenAI.TextembeddingsResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TextembeddingsResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::EdenAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Embeddings<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**1536__text-embedding-ada-002**|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-large**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-small**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002-v2**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-embedding-001**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-v4.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**mistral**|**1024__mistral-embed**|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral/mistral-embed**|`v0.0.1`|0.1 (per 1000000 seconde)|1 seconde<br/>
        /// |**mistral**|**mistral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed-2505**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**jina**|-|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v2-base-en**|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v3**|`v1`|0.02 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-embeddings' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`1536__text-embedding-ada-002`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**cohere**|`4096__embed-english-v2.0`|<br/>
        /// |**mistral**|`1024__mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </param>
        /// <param name="responseAsDict">
        /// Optional : When set to **true** (default), the response is an object of responses with providers names as keys :  <br/>
        ///                   ``` {"google" : { "status": "success", ... }, } ``` <br/>
        ///                 When set to **false** the response structure is a list of response objects :  <br/>
        ///                    ``` [{"status": "success", "provider": "google" ... }, ] ```. <br/>
        ///                   <br/>
        /// Default Value: true
        /// </param>
        /// <param name="attributesAsList">
        /// Optional : When set to **false** (default) the structure of the extracted items is list of objects having different attributes : <br/>
        ///      ```{'items': [{"attribute_1": "x1","attribute_2": "y2"}, ... ]}``` <br/>
        ///      When it is set to **true**, the response contains an object with each attribute as a list : <br/>
        ///      ```{ "attribute_1": ["x1","x2", ...], "attribute_2": [y1, y2, ...]}``` <br/>
        /// Default Value: false
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="texts">
        /// List of texts to transform into embeddings.
        /// </param>
        /// <param name="dimensions">
        ///  parameter to control the size of the output embedding vecto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextembeddingsResponseModel> TextTextEmbeddingsCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            global::System.Collections.Generic.IList<string> texts,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            int? dimensions = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.TextembeddingsEmbeddingsRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                Texts = texts,
                Dimensions = dimensions,
            };

            return await TextTextEmbeddingsCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}