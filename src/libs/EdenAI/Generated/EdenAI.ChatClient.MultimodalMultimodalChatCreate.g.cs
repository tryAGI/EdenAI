
#nullable enable

namespace EdenAI
{
    public partial class ChatClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_MultimodalMultimodalChatCreateSecurityRequirement0 =
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
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_MultimodalMultimodalChatCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_MultimodalMultimodalChatCreateSecurityRequirement0,
            };
        partial void PrepareMultimodalMultimodalChatCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.MultimodalchatChatRequest request);
        partial void PrepareMultimodalMultimodalChatCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.MultimodalchatChatRequest request);
        partial void ProcessMultimodalMultimodalChatCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMultimodalMultimodalChatCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.MultimodalchatResponseModel> MultimodalMultimodalChatCreateAsync(

            global::EdenAI.MultimodalchatChatRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await MultimodalMultimodalChatCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.MultimodalchatResponseModel>> MultimodalMultimodalChatCreateAsResponseAsync(

            global::EdenAI.MultimodalchatChatRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMultimodalMultimodalChatCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MultimodalMultimodalChatCreateSecurityRequirements,
                operationName: "MultimodalMultimodalChatCreateAsync");

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
                                path: "/multimodal/chat/",
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
                PrepareMultimodalMultimodalChatCreateRequest(
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
                                operationId: "MultimodalMultimodalChatCreate",
                                methodName: "MultimodalMultimodalChatCreateAsync",
                                pathTemplate: "\"/multimodal/chat/\"",
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
                                operationId: "MultimodalMultimodalChatCreate",
                                methodName: "MultimodalMultimodalChatCreateAsync",
                                pathTemplate: "\"/multimodal/chat/\"",
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
                                operationId: "MultimodalMultimodalChatCreate",
                                methodName: "MultimodalMultimodalChatCreateAsync",
                                pathTemplate: "\"/multimodal/chat/\"",
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
                ProcessMultimodalMultimodalChatCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MultimodalMultimodalChatCreate",
                                methodName: "MultimodalMultimodalChatCreateAsync",
                                pathTemplate: "\"/multimodal/chat/\"",
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
                                operationId: "MultimodalMultimodalChatCreate",
                                methodName: "MultimodalMultimodalChatCreateAsync",
                                pathTemplate: "\"/multimodal/chat/\"",
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
                                ProcessMultimodalMultimodalChatCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::EdenAI.MultimodalchatResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.MultimodalchatResponseModel>(
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

                                    var __value = await global::EdenAI.MultimodalchatResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.MultimodalchatResponseModel>(
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
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
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
        /// <param name="messages">
        /// A list containing all the conversations between the user and the assistant. Each item in the list should be a dictionary with two keys: 'role' and 'message'.<br/>
        /// **role**: Specifies the role of the speaker and can have the values 'user' or 'assistant'.<br/>
        /// **message**: A list of dictionaries. Each dictionary in the 'message' list must contain the keys 'type' and 'content'.<br/>
        /// #### Structure<br/>
        /// - **type**: Specifies the type of content and can be 'media_url', 'media_base64', or 'text'.<br/>
        /// - **content**: A dictionary with the actual content based on the 'type':<br/>
        ///   - If 'type' is 'media_url', 'content' must contain 'media_url' and must not contain 'media_base64' or 'text'.<br/>
        ///   - If 'type' is 'media_base64', 'content' must contain 'media_base64' and must not contain 'media_url' or 'text'.<br/>
        ///   - If 'type' is 'text', 'content' must contain 'text' and must not contain 'media_url' or 'media_base64'.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     'role': 'user',<br/>
        ///     'content': [<br/>
        ///       {<br/>
        ///         'type': 'text',<br/>
        ///         'content': {'text': 'Describe this image'}<br/>
        ///       },<br/>
        ///       {<br/>
        ///         'type': 'media_url',<br/>
        ///         'content': {<br/>
        ///            'media_url': 'https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg',<br/>
        ///            'media_type': 'image/jpeg'}<br/>
        ///       },<br/>
        ///     ]<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="chatbotGlobalAction">
        /// A system message that helps set the behavior of the assistant. For example, 'You are a helpful assistant'.
        /// </param>
        /// <param name="temperature">
        /// Controls the creativity of the model's responses. Higher values (up to 2) make the output more random, while lower values make it more focused and deterministic. A value of 0 (argmax sampling) is useful for scenarios requiring precise answers.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.<br/>
        /// Default Value: 2048
        /// </param>
        /// <param name="stopSequences">
        /// A list of sequences where the model will stop generating further tokens. Useful for controlling response length and format.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="topK">
        /// Limits the sampling pool to the top K options for each token. Setting this to a lower value can make the output more focused and deterministic.
        /// </param>
        /// <param name="topP">
        /// Enables nucleus sampling, where the model considers the smallest number of tokens whose cumulative probability is at least top_p. This allows for a dynamic selection of tokens based on probability, offering a balance between focus and creativity.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.MultimodalchatResponseModel> MultimodalMultimodalChatCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            global::System.Collections.Generic.IList<object> messages,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? chatbotGlobalAction = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topK = default,
            double? topP = default,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.MultimodalchatChatRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                Messages = messages,
                ChatbotGlobalAction = chatbotGlobalAction,
                Temperature = temperature,
                MaxTokens = maxTokens,
                StopSequences = stopSequences,
                TopK = topK,
                TopP = topP,
                ReasoningEffort = reasoningEffort,
            };

            return await MultimodalMultimodalChatCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}