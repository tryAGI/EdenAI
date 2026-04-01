
#nullable enable

namespace EdenAI
{
    public partial class PromptOptimizationClient
    {
        partial void PrepareTextTextPromptOptimizationCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.TextpromptOptimizationPromptOptimizationRequest request);
        partial void PrepareTextTextPromptOptimizationCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.TextpromptOptimizationPromptOptimizationRequest request);
        partial void ProcessTextTextPromptOptimizationCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextTextPromptOptimizationCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Prompt Optimization<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v3.0.0`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v3.0.0`|0.0 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-prompt_optimization' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextpromptOptimizationResponseModel> TextTextPromptOptimizationCreateAsync(

            global::EdenAI.TextpromptOptimizationPromptOptimizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTextTextPromptOptimizationCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/text/prompt_optimization/",
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
            PrepareTextTextPromptOptimizationCreateRequest(
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
            ProcessTextTextPromptOptimizationCreateResponse(
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
                ProcessTextTextPromptOptimizationCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.TextpromptOptimizationResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.TextpromptOptimizationResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Prompt Optimization<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v3.0.0`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v3.0.0`|0.0 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-prompt_optimization' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
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
        /// <param name="text">
        /// Description of the desired prompt.
        /// </param>
        /// <param name="targetProvider">
        /// Select the provider for the prompt optimization
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextpromptOptimizationResponseModel> TextTextPromptOptimizationCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string targetProvider,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::EdenAI.TextpromptOptimizationPromptOptimizationRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                Text = text,
                TargetProvider = targetProvider,
            };

            return await TextTextPromptOptimizationCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}