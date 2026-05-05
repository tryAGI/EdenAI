
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotQueryOperationsClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirement0,
                s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirement1,
            };
        partial void PrepareAiproductsAiproductsAskyodaV2GenerateCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId,
            global::EdenAI.GenerateRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2GenerateCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId,
            global::EdenAI.GenerateRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2GenerateCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiproductsAiproductsAskyodaV2GenerateCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate<br/>
        /// Interact with different LLM providers, this endpoint is based on the structure of the<br/>
        /// LLM API.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaQueryResponse> AiproductsAiproductsAskyodaV2GenerateCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.GenerateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AiproductsAiproductsAskyodaV2GenerateCreateAsResponseAsync(
                projectId: projectId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate<br/>
        /// Interact with different LLM providers, this endpoint is based on the structure of the<br/>
        /// LLM API.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaQueryResponse>> AiproductsAiproductsAskyodaV2GenerateCreateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.GenerateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2GenerateCreateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AiproductsAiproductsAskyodaV2GenerateCreateSecurityRequirements,
                operationName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::EdenAI.PathBuilder(
                                path: $"/aiproducts/askyoda/v2/{projectId}/generate/",
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
                PrepareAiproductsAiproductsAskyodaV2GenerateCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId!,
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
                                operationId: "AiproductsAiproductsAskyodaV2GenerateCreate",
                                methodName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync",
                                pathTemplate: "$\"/aiproducts/askyoda/v2/{projectId}/generate/\"",
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
                                operationId: "AiproductsAiproductsAskyodaV2GenerateCreate",
                                methodName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync",
                                pathTemplate: "$\"/aiproducts/askyoda/v2/{projectId}/generate/\"",
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
                                operationId: "AiproductsAiproductsAskyodaV2GenerateCreate",
                                methodName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync",
                                pathTemplate: "$\"/aiproducts/askyoda/v2/{projectId}/generate/\"",
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
                ProcessAiproductsAiproductsAskyodaV2GenerateCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AiproductsAiproductsAskyodaV2GenerateCreate",
                                methodName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync",
                                pathTemplate: "$\"/aiproducts/askyoda/v2/{projectId}/generate/\"",
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
                                operationId: "AiproductsAiproductsAskyodaV2GenerateCreate",
                                methodName: "AiproductsAiproductsAskyodaV2GenerateCreateAsync",
                                pathTemplate: "$\"/aiproducts/askyoda/v2/{projectId}/generate/\"",
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
                                ProcessAiproductsAiproductsAskyodaV2GenerateCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::EdenAI.YodaQueryResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaQueryResponse>(
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

                                    var __value = await global::EdenAI.YodaQueryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaQueryResponse>(
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
        /// Generate<br/>
        /// Interact with different LLM providers, this endpoint is based on the structure of the<br/>
        /// LLM API.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="messages">
        /// A list containing all the conversations between the user and the assistant.<br/>
        /// Each item in the list should be a dictionary with two keys: 'role' and 'message'.<br/>
        /// **role**: Specifies the role of the speaker and can have the values 'user', 'system', 'assistant' or 'tool'.<br/>
        /// The system role instructs the way the model should answer, e.g. 'You are a helpful assistant'. The user<br/>
        /// role specifies the user query and assistant is the model's response. The tool role is for external tools that<br/>
        /// can be used in the conversation.<br/>
        /// **message**: A list of dictionaries. Each dictionary in the 'message' list must contain the keys 'type' and 'content'.<br/>
        /// #### Structure<br/>
        /// - **type**: Specifies the type of content and can be 'image_url' or 'text'.<br/>
        /// - **content**: A dictionary with the actual content based on the 'type':<br/>
        ///     - If 'type' is 'image_url', 'content' must contain 'image_url' and must not contain 'text'.<br/>
        ///     - If 'type' is 'text', 'content' must contain 'text' and must not contain 'image_url'.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": [<br/>
        ///         {<br/>
        ///           "type": "text",<br/>
        ///           "text": "Describe this image"<br/>
        ///         },<br/>
        ///         {<br/>
        ///         "type": "image_url",<br/>
        ///         "image_url": {<br/>
        ///           "url": "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg"<br/>
        ///           }<br/>
        ///         }<br/>
        ///     ]<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="model">
        /// The OpenAI model to use for the chat completion. <br/>
        /// This field is required and specifies which language model will process the conversation. <br/>
        /// **Example values**: 'gpt-3.5-turbo', 'gpt-4', 'gpt-4-turbo'
        /// </param>
        /// <param name="reasoningEffort">
        /// Optional parameter to control the model's reasoning depth. <br/>
        /// Allows specifying the level of analytical effort in generating responses. <br/>
        /// **Choices**:<br/>
        /// - 'low': Minimal reasoning, quick responses<br/>
        /// - 'medium': Balanced reasoning approach<br/>
        /// - 'high': In-depth, comprehensive reasoning<br/>
        /// **Example**: 'high' for complex problem-solving tasks<br/>
        /// * `low` - low<br/>
        /// * `medium` - medium<br/>
        /// * `high` - high
        /// </param>
        /// <param name="metadata">
        /// Optional list of metadata associated with the chat request. <br/>
        /// Can be used to provide additional context or tracking information. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "metadata": [<br/>
        ///     {"key": "conversation_id", "value": "chat_12345"},<br/>
        ///     {"key": "source", "value": "customer_support"}<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="frequencyPenalty">
        /// Controls repetitiveness of model responses by penalizing frequent tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Reduce token repetition<br/>
        /// - Negative values: Encourage repetition<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.5 to significantly reduce repeated phrases
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specific tokens appearing in the response. <br/>
        /// A dictionary where keys are token IDs and values are bias scores. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "logit_bias": {<br/>
        ///     "50256": -100,  # Reduce probability of end-of-text token<br/>
        ///     "15": 5  # Slightly increase probability of a specific token<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="logprobs">
        /// If set to True, returns log probabilities of the most likely tokens. <br/>
        /// Useful for advanced token probability analysis. <br/>
        /// **Example**: True to get detailed token likelihood information
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return with each token. <br/>
        /// Must be between 0 and 20. <br/>
        /// **Example**: 5 to get top 5 most likely tokens for each position
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of tokens to generate in the completion. <br/>
        /// Must be at least 1. <br/>
        /// **Example**: 150 to limit response to approximately 100-150 words
        /// </param>
        /// <param name="n">
        /// Number of chat completion choices to generate.<br/>
        ///     **Example**: 3 to generate multiple alternative responses
        /// </param>
        /// <param name="modalities">
        /// List of supported input/output modalities for the chat. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "modalities": ["text", "image", "audio"]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="prediction">
        /// Optional field for storing prediction-related information. <br/>
        /// Flexible dictionary to capture model's predictive metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "prediction": {<br/>
        ///     "confidence_score": 0.85,<br/>
        ///     "top_prediction": "response_category"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="audio">
        /// Optional dictionary for audio-related parameters or metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "audio": {<br/>
        ///     "language": "en-US",<br/>
        ///     "transcription_format": "srt"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="presencePenalty">
        /// Adjusts likelihood of discussing new topics by penalizing existing tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Encourage more diverse topics<br/>
        /// - Negative values: Keep discussion more focused<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.0 to promote topic diversity
        /// </param>
        /// <param name="responseFormat">
        /// Specify the desired response format for the completion. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "response_format": {<br/>
        ///     "type": "json_object",<br/>
        ///     "schema": {...}<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="seed">
        /// Set a seed for deterministic sampling to reproduce consistent results. <br/>
        /// **Example**: 42 for a reproducible random generation process
        /// </param>
        /// <param name="serviceTier">
        /// Select the service tier for the API request. <br/>
        /// **Choices**:<br/>
        /// - 'auto': Automatically select appropriate tier<br/>
        /// - 'default': Use default service configuration<br/>
        /// * `auto` - auto<br/>
        /// * `default` - default
        /// </param>
        /// <param name="stop">
        /// List of strings that will cause the model to stop generating. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stop": ["\n", "Human:", "AI:"]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="stream">
        /// If True, returns tokens as they are generated in a streaming format. <br/>
        /// Default is False. <br/>
        /// **Example**: True for real-time token streaming<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Additional configuration for streaming responses. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stream_options": {<br/>
        ///     "include_usage": true<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in token selection. <br/>
        /// Ranges from 0.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - 0.0: Most deterministic, focused responses<br/>
        /// - 1.0: Balanced randomness<br/>
        /// - 2.0: Most creative, unpredictable responses<br/>
        /// **Example**: 0.7 for a good balance of creativity and focus
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling threshold for token selection. <br/>
        /// Ranges from 0.0 to 1.0. Default is 1.0. <br/>
        /// **Values**:<br/>
        /// - 1.0: Consider all tokens<br/>
        /// - Lower values: More focused, deterministic sampling<br/>
        /// **Example**: 0.9 to select from top 90% most probable tokens
        /// </param>
        /// <param name="tools">
        /// List of tools or function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "function",<br/>
        ///       "function": {<br/>
        ///         "name": "get_weather",<br/>
        ///         "description": "Retrieve current weather"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="toolChoice">
        /// Specify how tools should be used in the completion. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Model decides when to use tools<br/>
        /// - 'none': Disable tool usage<br/>
        /// - Specific tool name to always use a particular tool
        /// </param>
        /// <param name="parallelToolCalls">
        /// Allow the model to make multiple tool calls in parallel. <br/>
        /// **Example**: True to enable concurrent tool invocations
        /// </param>
        /// <param name="user">
        /// Optional identifier for the end-user to help track and monitor API usage. <br/>
        /// **Example**: 'user_123456'
        /// </param>
        /// <param name="functionCall">
        /// Control how function calls are handled. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Default behavior<br/>
        /// - 'none': Disable function calls<br/>
        /// - Specific function name to force its execution
        /// </param>
        /// <param name="functions">
        /// List of function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "functions": [<br/>
        ///     {<br/>
        ///       "name": "get_current_weather",<br/>
        ///       "description": "Get the current weather for a location",<br/>
        ///       "parameters": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="thinking">
        /// Configuration for enabling Claude's extended thinking. When enabled, responses include thinking content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your max_tokens limit.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   'thinking': {<br/>
        ///     'type': 'enabled'<br/>
        ///     'budget_tokens': '1024'  }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="webSearchOptions">
        /// Options for web search integration. <br/>
        ///         **Example**:<br/>
        ///         ```json<br/>
        ///         web_search_options={<br/>
        ///             "search_context_size": "medium"  # Options: "low", "medium", "high"<br/>
        ///         }<br/>
        ///         ```
        /// </param>
        /// <param name="filterDocuments">
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="minScore">
        /// A minimum score threshold for the model to consider a chunk as a valid response. Higher values mean the model will be more conservative and only return chunks that are more similar to the query. Lower values mean the model will be more open to returning chunks that are less similar to the query.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="k">
        /// How many results chunk you want to return<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.YodaQueryResponse> AiproductsAiproductsAskyodaV2GenerateCreateAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<object> messages,
            string model,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort = default,
            global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>? metadata = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxCompletionTokens = default,
            int? n = default,
            global::System.Collections.Generic.IList<string>? modalities = default,
            object? prediction = default,
            object? audio = default,
            double? presencePenalty = default,
            object? responseFormat = default,
            int? seed = default,
            global::EdenAI.ServiceTierEnum? serviceTier = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            bool? stream = default,
            object? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            string? functionCall = default,
            global::System.Collections.Generic.IList<object>? functions = default,
            global::EdenAI.ThinkingRequest? thinking = default,
            object? webSearchOptions = default,
            object? filterDocuments = default,
            double? minScore = default,
            int? k = default,
            int? maxTokens = default,
            global::System.Guid? conversationId = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.GenerateRequest
            {
                Messages = messages,
                Model = model,
                ReasoningEffort = reasoningEffort,
                Metadata = metadata,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                Modalities = modalities,
                Prediction = prediction,
                Audio = audio,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
                FunctionCall = functionCall,
                Functions = functions,
                Thinking = thinking,
                WebSearchOptions = webSearchOptions,
                FilterDocuments = filterDocuments,
                MinScore = minScore,
                K = k,
                MaxTokens = maxTokens,
                ConversationId = conversationId,
            };

            return await AiproductsAiproductsAskyodaV2GenerateCreateAsync(
                projectId: projectId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}