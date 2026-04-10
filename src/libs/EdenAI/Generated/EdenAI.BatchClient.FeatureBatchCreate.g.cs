
#nullable enable

namespace EdenAI
{
    public partial class BatchClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_FeatureBatchCreateSecurityRequirement0 =
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
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_FeatureBatchCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_FeatureBatchCreateSecurityRequirement0,
            };
        partial void PrepareFeatureBatchCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string feature,
            ref string name,
            ref string subfeature,
            global::EdenAI.BatchRequest request);
        partial void PrepareFeatureBatchCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string feature,
            string name,
            string subfeature,
            global::EdenAI.BatchRequest request);
        partial void ProcessFeatureBatchCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFeatureBatchCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Launch Batch Job<br/>
        /// Launch a async Batch job, given a job name that will be used as its id.<br/>
        /// Each request should have the same parameters as you would normally pass to a feature.<br/>
        /// You can also pass an optional paramater `name` to help better identify each requests you send.<br/>
        /// Example with `text`/`sentiment_analysis`:<br/>
        /// ```json<br/>
        /// "requests": [<br/>
        ///     {<br/>
        ///         "text": "It's -25 outside and I am so hot.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google,amazon"<br/>
        ///     },<br/>
        ///     {<br/>
        ///         "name": "mixed",<br/>
        ///         "text": "Overall I am satisfied with my experience at Amazon, but two areas of major improvement needed.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// ### Limitations:<br/>
        /// You can have up to `5` concurrent running Jobs &amp; input up to `500` requests per Batch<br/>
        ///         <br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Features&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Feature Name|Subfeature Name|<br/>
        /// |------------|---------------|<br/>
        /// |`translation`|`language_detection`|<br/>
        /// |`image`|`face_detection`|<br/>
        /// |`text`|`chat`|<br/>
        /// |`ocr`|`receipt_parser`|<br/>
        /// |`image`|`anonymization`|<br/>
        /// |`audio`|`text_to_speech`|<br/>
        /// |`translation`|`document_translation`|<br/>
        /// |`image`|`logo_detection`|<br/>
        /// |`image`|`landmark_detection`|<br/>
        /// |`image`|`background_removal`|<br/>
        /// |`text`|`topic_extraction`|<br/>
        /// |`text`|`embeddings`|<br/>
        /// |`text`|`custom_classification`|<br/>
        /// |`text`|`anonymization`|<br/>
        /// |`text`|`summarize`|<br/>
        /// |`text`|`custom_named_entity_recognition`|<br/>
        /// |`text`|`generation`|<br/>
        /// |`text`|`code_generation`|<br/>
        /// |`text`|`moderation`|<br/>
        /// |`image`|`generation`|<br/>
        /// |`translation`|`automatic_translation`|<br/>
        /// |`text`|`search`|<br/>
        /// |`text`|`spell_check`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`ocr`|`identity_parser`|<br/>
        /// |`image`|`explicit_content`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`text`|`question_answer`|<br/>
        /// |`text`|`keyword_extraction`|<br/>
        /// |`text`|`named_entity_recognition`|<br/>
        /// |`text`|`syntax_analysis`|<br/>
        /// |`text`|`sentiment_analysis`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.BatchLaunchResponse> FeatureBatchCreateAsync(
            string feature,
            string name,
            string subfeature,

            global::EdenAI.BatchRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFeatureBatchCreateArguments(
                httpClient: HttpClient,
                feature: ref feature,
                name: ref name,
                subfeature: ref subfeature,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FeatureBatchCreateSecurityRequirements,
                operationName: "FeatureBatchCreateAsync");

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
                                path: $"/{feature}/{subfeature}/batch/{name}/",
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
                PrepareFeatureBatchCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    feature: feature,
                    name: name,
                    subfeature: subfeature,
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
                                operationId: "FeatureBatchCreate",
                                methodName: "FeatureBatchCreateAsync",
                                pathTemplate: "$\"/{feature}/{subfeature}/batch/{name}/\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FeatureBatchCreate",
                                methodName: "FeatureBatchCreateAsync",
                                pathTemplate: "$\"/{feature}/{subfeature}/batch/{name}/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::EdenAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FeatureBatchCreate",
                                methodName: "FeatureBatchCreateAsync",
                                pathTemplate: "$\"/{feature}/{subfeature}/batch/{name}/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessFeatureBatchCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FeatureBatchCreate",
                                methodName: "FeatureBatchCreateAsync",
                                pathTemplate: "$\"/{feature}/{subfeature}/batch/{name}/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FeatureBatchCreate",
                                methodName: "FeatureBatchCreateAsync",
                                pathTemplate: "$\"/{feature}/{subfeature}/batch/{name}/\"",
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
                                ProcessFeatureBatchCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::EdenAI.BatchLaunchResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::EdenAI.BatchLaunchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Launch Batch Job<br/>
        /// Launch a async Batch job, given a job name that will be used as its id.<br/>
        /// Each request should have the same parameters as you would normally pass to a feature.<br/>
        /// You can also pass an optional paramater `name` to help better identify each requests you send.<br/>
        /// Example with `text`/`sentiment_analysis`:<br/>
        /// ```json<br/>
        /// "requests": [<br/>
        ///     {<br/>
        ///         "text": "It's -25 outside and I am so hot.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google,amazon"<br/>
        ///     },<br/>
        ///     {<br/>
        ///         "name": "mixed",<br/>
        ///         "text": "Overall I am satisfied with my experience at Amazon, but two areas of major improvement needed.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// ### Limitations:<br/>
        /// You can have up to `5` concurrent running Jobs &amp; input up to `500` requests per Batch<br/>
        ///         <br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Features&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Feature Name|Subfeature Name|<br/>
        /// |------------|---------------|<br/>
        /// |`translation`|`language_detection`|<br/>
        /// |`image`|`face_detection`|<br/>
        /// |`text`|`chat`|<br/>
        /// |`ocr`|`receipt_parser`|<br/>
        /// |`image`|`anonymization`|<br/>
        /// |`audio`|`text_to_speech`|<br/>
        /// |`translation`|`document_translation`|<br/>
        /// |`image`|`logo_detection`|<br/>
        /// |`image`|`landmark_detection`|<br/>
        /// |`image`|`background_removal`|<br/>
        /// |`text`|`topic_extraction`|<br/>
        /// |`text`|`embeddings`|<br/>
        /// |`text`|`custom_classification`|<br/>
        /// |`text`|`anonymization`|<br/>
        /// |`text`|`summarize`|<br/>
        /// |`text`|`custom_named_entity_recognition`|<br/>
        /// |`text`|`generation`|<br/>
        /// |`text`|`code_generation`|<br/>
        /// |`text`|`moderation`|<br/>
        /// |`image`|`generation`|<br/>
        /// |`translation`|`automatic_translation`|<br/>
        /// |`text`|`search`|<br/>
        /// |`text`|`spell_check`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`ocr`|`identity_parser`|<br/>
        /// |`image`|`explicit_content`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`text`|`question_answer`|<br/>
        /// |`text`|`keyword_extraction`|<br/>
        /// |`text`|`named_entity_recognition`|<br/>
        /// |`text`|`syntax_analysis`|<br/>
        /// |`text`|`sentiment_analysis`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="webhookReceiver"></param>
        /// <param name="usersWebhookParameters">
        /// Json data that contains of additional parameters that will be sent back to the webhook receiver             (ex: api key for security or client's data ID to link the result internally).             Will only be used when webhook_receiver is set.
        /// </param>
        /// <param name="sendWebhookData">
        /// If set to false the webhook will not contain the result data. Use if your webhook receiver has a request size limit.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requests"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.BatchLaunchResponse> FeatureBatchCreateAsync(
            string feature,
            string name,
            string subfeature,
            global::System.Collections.Generic.IList<object> requests,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.BatchRequest
            {
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                Requests = requests,
            };

            return await FeatureBatchCreateAsync(
                feature: feature,
                name: name,
                subfeature: subfeature,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}