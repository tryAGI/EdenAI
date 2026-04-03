
#nullable enable

namespace EdenAI
{
    public partial class BatchClient
    {
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
        /// |`text`|`chat`|<br/>
        /// |`image`|`face_detection`|<br/>
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
        /// |`ocr`|`identity_parser`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`image`|`explicit_content`|<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.BatchLaunchResponse> FeatureBatchCreateAsync(
            string feature,
            string name,
            string subfeature,

            global::EdenAI.BatchRequest request,
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

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/{feature}/{subfeature}/batch/{name}/",
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
            PrepareFeatureBatchCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                feature: feature,
                name: name,
                subfeature: subfeature,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFeatureBatchCreateResponse(
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
                ProcessFeatureBatchCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.BatchLaunchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::EdenAI.BatchLaunchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// |`text`|`chat`|<br/>
        /// |`image`|`face_detection`|<br/>
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
        /// |`ocr`|`identity_parser`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`image`|`explicit_content`|<br/>
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
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}