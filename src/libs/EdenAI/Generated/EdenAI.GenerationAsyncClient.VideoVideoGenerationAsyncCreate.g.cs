
#nullable enable

namespace EdenAI
{
    public partial class GenerationAsyncClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_VideoVideoGenerationAsyncCreateSecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_VideoVideoGenerationAsyncCreateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_VideoVideoGenerationAsyncCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_VideoVideoGenerationAsyncCreateSecurityRequirement0,
                s_VideoVideoGenerationAsyncCreateSecurityRequirement1,
            };
        partial void PrepareVideoVideoGenerationAsyncCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.GenerationAsyncRequest request);
        partial void PrepareVideoVideoGenerationAsyncCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.GenerationAsyncRequest request);
        partial void ProcessVideoVideoGenerationAsyncCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessVideoVideoGenerationAsyncCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generation Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-reel-v1:1**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|**amazon.nova-reel-v1:0**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|-|`boto3`|0.5 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-2.3**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-02**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|-|`v1`|0.56 (per 1 request)|1 request<br/>
        /// |**minimax**|**S2V-01**|`v1`|0.65 (per 1 request)|1 request<br/>
        /// |**minimax**|**T2V/I2V-01-Director**|`v1`|0.43 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedance-1-0-pro-250528**|`v3`|0.62 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**bytedance**|**seedance-1-0-lite-t2v-250428**|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**google**|**veo-3.1-generate-preview**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-generate-001**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-fast-generate-001**|`v1Beta`|0.15 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1Beta`|3.6 (per 1 request)|1 request<br/>
        /// |**openai**|-|`v1`|5.0 (per 1 request)|1 request<br/>
        /// |**openai**|**sora-2**|`v1`|0.1 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-generation_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-reel-v1:1`|<br/>
        /// |**minimax**|`MiniMax-Hailuo-2.3`|<br/>
        /// |**bytedance**|`seedance-1-0-pro-250528`|<br/>
        /// |**google**|`veo-3.1-generate-preview`|<br/>
        /// |**openai**|`sora-2`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoGenerationAsyncCreateAsync(

            global::EdenAI.GenerationAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareVideoVideoGenerationAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_VideoVideoGenerationAsyncCreateSecurityRequirements,
                operationName: "VideoVideoGenerationAsyncCreateAsync");

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
                                path: "/video/generation_async/",
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Settings != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Settings ?? string.Empty),
                                    name: "\"settings\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Providers, x => x))}]"),
                                name: "\"providers\"");
                            if (request.FallbackProviders != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.FallbackProviders, x => x))}]"),
                                    name: "\"fallback_providers\"");
                            } 
                            if (request.ShowOriginalResponse != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ShowOriginalResponse, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"show_original_response\"");
                            } 
                            if (request.WebhookReceiver != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookReceiver ?? string.Empty),
                                    name: "\"webhook_receiver\"");
                            } 
                            if (request.UsersWebhookParameters != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.UsersWebhookParameters.ToString() ?? string.Empty),
                                    name: "\"users_webhook_parameters\"");
                            } 
                            if (request.SendWebhookData != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SendWebhookData, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"send_webhook_data\"");
                            } 
                            if (request.ShowBase64 != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ShowBase64, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"show_base_64\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Text ?? string.Empty),
                                name: "\"text\"");
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Filename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Duration != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Duration, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"duration\"");
                            } 
                            if (request.Fps != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Fps, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"fps\"");
                            } 
                            if (request.Dimension != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Dimension ?? string.Empty),
                                    name: "\"dimension\"");
                            } 
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareVideoVideoGenerationAsyncCreateRequest(
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
                                operationId: "VideoVideoGenerationAsyncCreate",
                                methodName: "VideoVideoGenerationAsyncCreateAsync",
                                pathTemplate: "\"/video/generation_async/\"",
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
                                operationId: "VideoVideoGenerationAsyncCreate",
                                methodName: "VideoVideoGenerationAsyncCreateAsync",
                                pathTemplate: "\"/video/generation_async/\"",
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
                                operationId: "VideoVideoGenerationAsyncCreate",
                                methodName: "VideoVideoGenerationAsyncCreateAsync",
                                pathTemplate: "\"/video/generation_async/\"",
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
                ProcessVideoVideoGenerationAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VideoVideoGenerationAsyncCreate",
                                methodName: "VideoVideoGenerationAsyncCreateAsync",
                                pathTemplate: "\"/video/generation_async/\"",
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
                                operationId: "VideoVideoGenerationAsyncCreate",
                                methodName: "VideoVideoGenerationAsyncCreateAsync",
                                pathTemplate: "\"/video/generation_async/\"",
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
                                ProcessVideoVideoGenerationAsyncCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::EdenAI.LaunchAsyncJobResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::EdenAI.LaunchAsyncJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Generation Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-reel-v1:1**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|**amazon.nova-reel-v1:0**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|-|`boto3`|0.5 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-2.3**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-02**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|-|`v1`|0.56 (per 1 request)|1 request<br/>
        /// |**minimax**|**S2V-01**|`v1`|0.65 (per 1 request)|1 request<br/>
        /// |**minimax**|**T2V/I2V-01-Director**|`v1`|0.43 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedance-1-0-pro-250528**|`v3`|0.62 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**bytedance**|**seedance-1-0-lite-t2v-250428**|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**google**|**veo-3.1-generate-preview**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-generate-001**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-fast-generate-001**|`v1Beta`|0.15 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1Beta`|3.6 (per 1 request)|1 request<br/>
        /// |**openai**|-|`v1`|5.0 (per 1 request)|1 request<br/>
        /// |**openai**|**sora-2**|`v1`|0.1 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-generation_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-reel-v1:1`|<br/>
        /// |**minimax**|`MiniMax-Hailuo-2.3`|<br/>
        /// |**bytedance**|`seedance-1-0-pro-250528`|<br/>
        /// |**google**|`veo-3.1-generate-preview`|<br/>
        /// |**openai**|`sora-2`|<br/>
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
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookReceiver">
        /// Webhook receiver should be a valid https URL (ex : https://your.listner.com/endpoint).             After the processing is done, the webhook endpoint will receive a POST request with the result.
        /// </param>
        /// <param name="usersWebhookParameters">
        /// Json data that contains of additional parameters that will be sent back to the webhook receiver             (ex: api key for security or client's data ID to link the result internally).             Will only be used when webhook_receiver is set.
        /// </param>
        /// <param name="sendWebhookData">
        /// If set to false the webhook will not contain the result data. Use if your webhook receiver has a request size limit.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="text">
        /// The text prompt that describes the content and style of the video you want to generate. Be specific and detailed to guide the AI in creating your desired video.
        /// </param>
        /// <param name="file">
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </param>
        /// <param name="filename">
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </param>
        /// <param name="duration">
        /// Length of the generated video in seconds. Minimum duration is 1 second. If not specified, the video will default to 6 seconds.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="fps">
        /// Frames per second (FPS) of the generated video. Determines the smoothness of the video motion. Default is 24 FPS, which is standard for most video content. Minimum value is 1 FPS.<br/>
        /// Default Value: 24
        /// </param>
        /// <param name="dimension">
        /// Video resolution in the format 'width x height' (e.g., '1280x720'). Default resolution is 1280x720 (720p). Ensure the format is exactly 'width x height' with a lowercase 'x'.<br/>
        /// Default Value: 1280x720
        /// </param>
        /// <param name="seed">
        /// Random seed value that initializes the noise for the generation process. Use this to create consistent or unique variations of your video:<br/>
        /// - Range: 0 to 2,147,483,646<br/>
        /// - Default: 12<br/>
        /// - Changing the seed while keeping other parameters constant will produce a different video that still matches your prompt<br/>
        /// - Useful for exploring multiple creative variations of the same concept<br/>
        /// Default Value: 12
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoGenerationAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            byte[]? file = default,
            string? filename = default,
            int? duration = default,
            int? fps = default,
            string? dimension = default,
            int? seed = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.GenerationAsyncRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ShowOriginalResponse = showOriginalResponse,
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                ShowBase64 = showBase64,
                Text = text,
                File = file,
                Filename = filename,
                Duration = duration,
                Fps = fps,
                Dimension = dimension,
                Seed = seed,
            };

            return await VideoVideoGenerationAsyncCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}