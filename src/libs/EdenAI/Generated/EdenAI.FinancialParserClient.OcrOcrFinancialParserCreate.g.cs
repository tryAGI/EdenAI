
#nullable enable

namespace EdenAI
{
    public partial class FinancialParserClient
    {
        partial void PrepareOcrOcrFinancialParserCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.OcrfinancialParserFinancialParserRequest request);
        partial void PrepareOcrOcrFinancialParserCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.OcrfinancialParserFinancialParserRequest request);
        partial void ProcessOcrOcrFinancialParserCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOcrOcrFinancialParserCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Financial Parser<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Document Type|Price|Billing unit|<br/>
        /// |----|----|-------|------|-----|------------|<br/>
        /// |**affinda**|-|`v3`|`invoice`|0.08 (per 1 page)|1 page<br/>
        /// |**affinda**|-|`v3`|`receipt`|0.07 (per 1 page)|1 page<br/>
        /// |**amazon**|-|`boto3 1.26.8`|-|0.01 (per 1 page)|1 page<br/>
        /// |**base64**|-|`latest`|-|0.25 (per 1 page)|1 page<br/>
        /// |**google**|-|`DocumentAI v1 beta3`|`invoice`|0.01 (per 1 page)|10 page<br/>
        /// |**google**|-|`DocumentAI v1 beta3`|`receipt`|0.01 (per 1 page)|10 page<br/>
        /// |**klippa**|-|`v1`|-|0.1 (per 1 file)|1 file<br/>
        /// |**microsoft**|-|`rest API 4.0 (2024-02-29-preview)`|-|0.01 (per 1 page)|1 page<br/>
        /// |**mindee**|-|`v1.2`|-|0.1 (per 1 page)|1 page<br/>
        /// |**tabscanner**|-|`latest`|-|0.08 (per 1 page)|1 page<br/>
        /// |**veryfi**|-|`v8`|`receipt`|0.08 (per 1 file)|1 file<br/>
        /// |**veryfi**|-|`v8`|`invoice`|0.16 (per 1 file)|1 file<br/>
        /// |**eagledoc**|-|`v1`|-|0.03 (per 1 page)|1 page<br/>
        /// |**extracta**|-|`v1`|-|0.1 (per 1 page)|1 page<br/>
        /// |**openai**|**gpt-4o**|`v1.0`|-|0.04 (per 1 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Amharic**|`am`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Armenian**|`hy`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Burmese**|`my`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Cebuano**|`ceb`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Hausa**|`ha`|<br/>
        /// |**Hawaiian**|`haw`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hmong**|`hmn`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Igbo**|`ig`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Kinyarwanda**|`rw`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malagasy**|`mg`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Malayalam**|`ml`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Nyanja**|`ny`|<br/>
        /// |**Oriya (macrolanguage)**|`or`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Samoan**|`sm`|<br/>
        /// |**Scottish Gaelic**|`gd`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Shona**|`sn`|<br/>
        /// |**Sindhi**|`sd`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Southern Sotho**|`st`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (China)**|`zh-cn`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Taiwan)**|`zh-tw`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**French (Switzerland)**|`fr-CH`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**German (Switzerland)**|`de-CH`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Italian (Switzerland)**|`it-CH`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=ocr-financial_parser' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.OcrfinancialParserResponseModel> OcrOcrFinancialParserCreateAsync(

            global::EdenAI.OcrfinancialParserFinancialParserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOcrOcrFinancialParserCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/ocr/financial_parser/",
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
            PrepareOcrOcrFinancialParserCreateRequest(
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
            ProcessOcrOcrFinancialParserCreateResponse(
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
                ProcessOcrOcrFinancialParserCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.OcrfinancialParserResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.OcrfinancialParserResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Financial Parser<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Document Type|Price|Billing unit|<br/>
        /// |----|----|-------|------|-----|------------|<br/>
        /// |**affinda**|-|`v3`|`invoice`|0.08 (per 1 page)|1 page<br/>
        /// |**affinda**|-|`v3`|`receipt`|0.07 (per 1 page)|1 page<br/>
        /// |**amazon**|-|`boto3 1.26.8`|-|0.01 (per 1 page)|1 page<br/>
        /// |**base64**|-|`latest`|-|0.25 (per 1 page)|1 page<br/>
        /// |**google**|-|`DocumentAI v1 beta3`|`invoice`|0.01 (per 1 page)|10 page<br/>
        /// |**google**|-|`DocumentAI v1 beta3`|`receipt`|0.01 (per 1 page)|10 page<br/>
        /// |**klippa**|-|`v1`|-|0.1 (per 1 file)|1 file<br/>
        /// |**microsoft**|-|`rest API 4.0 (2024-02-29-preview)`|-|0.01 (per 1 page)|1 page<br/>
        /// |**mindee**|-|`v1.2`|-|0.1 (per 1 page)|1 page<br/>
        /// |**tabscanner**|-|`latest`|-|0.08 (per 1 page)|1 page<br/>
        /// |**veryfi**|-|`v8`|`receipt`|0.08 (per 1 file)|1 file<br/>
        /// |**veryfi**|-|`v8`|`invoice`|0.16 (per 1 file)|1 file<br/>
        /// |**eagledoc**|-|`v1`|-|0.03 (per 1 page)|1 page<br/>
        /// |**extracta**|-|`v1`|-|0.1 (per 1 page)|1 page<br/>
        /// |**openai**|**gpt-4o**|`v1.0`|-|0.04 (per 1 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Amharic**|`am`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Armenian**|`hy`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Burmese**|`my`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Cebuano**|`ceb`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Hausa**|`ha`|<br/>
        /// |**Hawaiian**|`haw`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hmong**|`hmn`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Igbo**|`ig`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Kinyarwanda**|`rw`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malagasy**|`mg`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Malayalam**|`ml`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Nyanja**|`ny`|<br/>
        /// |**Oriya (macrolanguage)**|`or`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Samoan**|`sm`|<br/>
        /// |**Scottish Gaelic**|`gd`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Shona**|`sn`|<br/>
        /// |**Sindhi**|`sd`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Southern Sotho**|`st`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (China)**|`zh-cn`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Taiwan)**|`zh-tw`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**French (Switzerland)**|`fr-CH`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**German (Switzerland)**|`de-CH`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Italian (Switzerland)**|`it-CH`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=ocr-financial_parser' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
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
        /// <param name="file">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="filename">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="fileUrl">
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </param>
        /// <param name="filePassword">
        /// If your PDF file has a password, you can pass it here!
        /// </param>
        /// <param name="language">
        /// Language code of the language the document is written in (ex: fr (French), en (English), es (Spanish))
        /// </param>
        /// <param name="documentType">
        /// Specify the type of your document. Can be Set to 'auto-detect' for automatic detection if the provider supports it. Otherwise, the default is 'invoice'.<br/>
        /// * `auto-detect` - auto-detect<br/>
        /// * `invoice` - invoice<br/>
        /// * `receipt` - receipt<br/>
        /// Default Value: invoice
        /// </param>
        /// <param name="convertToPdf">
        /// Boolean value to specify weather to convert the doc/docx files to pdf format to be accepted by a majority of the providers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.OcrfinancialParserResponseModel> OcrOcrFinancialParserCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? filePassword = default,
            string? language = default,
            global::EdenAI.DocumentTypeEnum? documentType = default,
            bool? convertToPdf = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::EdenAI.OcrfinancialParserFinancialParserRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                File = file,
                Filename = filename,
                FileUrl = fileUrl,
                FilePassword = filePassword,
                Language = language,
                DocumentType = documentType,
                ConvertToPdf = convertToPdf,
            };

            return await OcrOcrFinancialParserCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}