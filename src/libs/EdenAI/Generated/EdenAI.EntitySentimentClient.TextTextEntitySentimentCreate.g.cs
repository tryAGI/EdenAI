
#nullable enable

namespace EdenAI
{
    public partial class EntitySentimentClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_TextTextEntitySentimentCreateSecurityRequirement0 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                {                    new global::EdenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_TextTextEntitySentimentCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_TextTextEntitySentimentCreateSecurityRequirement0,
            };
        partial void PrepareTextTextEntitySentimentCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.TextentitySentimentEntitySentimentRequest request);
        partial void PrepareTextTextEntitySentimentCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.TextentitySentimentEntitySentimentRequest request);
        partial void ProcessTextTextEntitySentimentCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextTextEntitySentimentCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Entity Sentiment<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 1.26.8`|1.0 (per 1000000 char)|300 char<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-live-001**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-preview-image-generation**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp-01-21**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-pro-exp-02-05**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-06-17**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-04-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-05-20**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-tts**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-05-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-06-05**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-tts**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1114**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1206**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-27b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-9b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro-vision**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**learnlm-1.5-pro-experimental**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**English**|`en`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-entity_sentiment' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-1.5-flash`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextentitySentimentResponseModel> TextTextEntitySentimentCreateAsync(

            global::EdenAI.TextentitySentimentEntitySentimentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTextTextEntitySentimentCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TextTextEntitySentimentCreateSecurityRequirements,
                operationName: "TextTextEntitySentimentCreateAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/text/entity_sentiment/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareTextTextEntitySentimentCreateRequest(
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
            ProcessTextTextEntitySentimentCreateResponse(
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
                ProcessTextTextEntitySentimentCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.TextentitySentimentResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.TextentitySentimentResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Entity Sentiment<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 1.26.8`|1.0 (per 1000000 char)|300 char<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-live-001**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-preview-image-generation**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp-01-21**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-pro-exp-02-05**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-06-17**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-04-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-05-20**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-tts**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-05-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-06-05**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-tts**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1114**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1206**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-27b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-9b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro-vision**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**learnlm-1.5-pro-experimental**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**English**|`en`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-entity_sentiment' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-1.5-flash`|<br/>
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
        /// <param name="text">
        /// Text to analyze
        /// </param>
        /// <param name="language">
        /// Language code for the language the input text is written in (eg: en, fr).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextentitySentimentResponseModel> TextTextEntitySentimentCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? language = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.TextentitySentimentEntitySentimentRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                Text = text,
                Language = language,
            };

            return await TextTextEntitySentimentCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}