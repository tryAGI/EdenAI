
#nullable enable

namespace EdenAI
{
    public partial class OcrClient
    {
        partial void PrepareOcrOcrOcrCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.OcrocrOcrRequest request);
        partial void PrepareOcrOcrOcrCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.OcrocrOcrRequest request);
        partial void ProcessOcrOcrOcrCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOcrOcrOcrCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// OCR<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|1.5 (per 1000 page)|1 page<br/>
        /// |**google**|`v1`|1.5 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`v3.2`|1.0 (per 1000 page)|1 page<br/>
        /// |**sentisight**|`v3.3.1`|0.75 (per 1000 file)|1 file<br/>
        /// |**api4ai**|`v1.0.0`|3.0 (per 1000 request)|1 request<br/>
        /// |**mistral**|`v1`|1.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Abaza**|`abq`|<br/>
        /// |**Adyghe**|`ady`|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Assamese**|`as`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Avaric**|`av`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
        /// |**Bihari languages**|`bh`|<br/>
        /// |**Bislama**|`bi`|<br/>
        /// |**Bodo (India)**|`brx`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Braj**|`bra`|<br/>
        /// |**Breton**|`br`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Bundeli**|`bns`|<br/>
        /// |**Buriat**|`bua`|<br/>
        /// |**Camling**|`rab`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Cebuano**|`ceb`|<br/>
        /// |**Chamorro**|`ch`|<br/>
        /// |**Chechen**|`ce`|<br/>
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dargwa**|`dar`|<br/>
        /// |**Dari**|`prs`|<br/>
        /// |**Dhimal**|`dhi`|<br/>
        /// |**Dogri (macrolanguage)**|`doi`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Erzya**|`myv`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Faroese**|`fo`|<br/>
        /// |**Fijian**|`fj`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Friulian**|`fur`|<br/>
        /// |**Gagauz**|`gag`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gilbertese**|`gil`|<br/>
        /// |**Goan Konkani**|`gom`|<br/>
        /// |**Gondi**|`gon`|<br/>
        /// |**Gurung**|`gvr`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Halbi**|`hlb`|<br/>
        /// |**Hani**|`hni`|<br/>
        /// |**Haryanvi**|`bgc`|<br/>
        /// |**Hawaiian**|`haw`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hmong Daw**|`mww`|<br/>
        /// |**Ho**|`hoc`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Inari Sami**|`smn`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Ingush**|`inh`|<br/>
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
        /// |**Kabardian**|`kbd`|<br/>
        /// |**Kabuverdianu**|`kea`|<br/>
        /// |**Kachin**|`kac`|<br/>
        /// |**Kalaallisut**|`kl`|<br/>
        /// |**Kangri**|`xnr`|<br/>
        /// |**Kara-Kalpak**|`kaa`|<br/>
        /// |**Karachay-Balkar**|`krc`|<br/>
        /// |**Kashubian**|`csb`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khaling**|`klr`|<br/>
        /// |**Khasi**|`kha`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Korku**|`kfq`|<br/>
        /// |**Koryak**|`kpy`|<br/>
        /// |**Kosraean**|`kos`|<br/>
        /// |**Kumarbhag Paharia**|`kmj`|<br/>
        /// |**Kumyk**|`kum`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Kurukh**|`kru`|<br/>
        /// |**Kölsch**|`ksh`|<br/>
        /// |**Lak**|`lbe`|<br/>
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lezghian**|`lez`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Maithili**|`mai`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Marshallese**|`mh`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Newari**|`new`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Old English (ca. 450-1100)**|`ang`|<br/>
        /// |**Ossetian**|`os`|<br/>
        /// |**Pali**|`pi`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Romansh**|`rm`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Sadri**|`sck`|<br/>
        /// |**Samoan**|`sm`|<br/>
        /// |**Sanskrit**|`sa`|<br/>
        /// |**Santali**|`sat`|<br/>
        /// |**Scots**|`sco`|<br/>
        /// |**Scottish Gaelic**|`gd`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sherpa**|`xsr`|<br/>
        /// |**Sirmauri**|`srx`|<br/>
        /// |**Skolt Sami**|`sms`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Southern Sami**|`sma`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tabassaran**|`tab`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Tetum**|`tet`|<br/>
        /// |**Thangmi**|`thf`|<br/>
        /// |**Tonga (Tonga Islands)**|`to`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Tuvinian**|`tyv`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Upper Sorbian**|`hsb`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Volapük**|`vo`|<br/>
        /// |**Walser**|`wae`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Yucateco**|`yua`|<br/>
        /// |**Zhuang**|`za`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Arabic (Pseudo-Accents)**|`ar-XA`|<br/>
        /// |**Belarusian**|`be-cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-latn`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**Finnish (Finland)**|`fi-FI`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-latn`|<br/>
        /// |**Korean (South Korea)**|`ko-KR`|<br/>
        /// |**Kurdish (Arabic)**|`ku-arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-latn`|<br/>
        /// |**Polish**|`pl-PO`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Region: Czechia**|`cz-CZ`|<br/>
        /// |**Region: Greece**|`gr-GR`|<br/>
        /// |**Russian (Russia)**|`ru-RU`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// |**Swedish (Sweden)**|`sv-SE`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Uzbek (Arabic)**|`uz-arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.OcrocrResponseModel> OcrOcrOcrCreateAsync(

            global::EdenAI.OcrocrOcrRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOcrOcrOcrCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/ocr/ocr/",
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
            PrepareOcrOcrOcrCreateRequest(
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
            ProcessOcrOcrOcrCreateResponse(
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
                ProcessOcrOcrOcrCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.OcrocrResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::EdenAI.OcrocrResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// OCR<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|1.5 (per 1000 page)|1 page<br/>
        /// |**google**|`v1`|1.5 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`v3.2`|1.0 (per 1000 page)|1 page<br/>
        /// |**sentisight**|`v3.3.1`|0.75 (per 1000 file)|1 file<br/>
        /// |**api4ai**|`v1.0.0`|3.0 (per 1000 request)|1 request<br/>
        /// |**mistral**|`v1`|1.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Abaza**|`abq`|<br/>
        /// |**Adyghe**|`ady`|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Assamese**|`as`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Avaric**|`av`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
        /// |**Bihari languages**|`bh`|<br/>
        /// |**Bislama**|`bi`|<br/>
        /// |**Bodo (India)**|`brx`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Braj**|`bra`|<br/>
        /// |**Breton**|`br`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Bundeli**|`bns`|<br/>
        /// |**Buriat**|`bua`|<br/>
        /// |**Camling**|`rab`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Cebuano**|`ceb`|<br/>
        /// |**Chamorro**|`ch`|<br/>
        /// |**Chechen**|`ce`|<br/>
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dargwa**|`dar`|<br/>
        /// |**Dari**|`prs`|<br/>
        /// |**Dhimal**|`dhi`|<br/>
        /// |**Dogri (macrolanguage)**|`doi`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Erzya**|`myv`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Faroese**|`fo`|<br/>
        /// |**Fijian**|`fj`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Friulian**|`fur`|<br/>
        /// |**Gagauz**|`gag`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gilbertese**|`gil`|<br/>
        /// |**Goan Konkani**|`gom`|<br/>
        /// |**Gondi**|`gon`|<br/>
        /// |**Gurung**|`gvr`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Halbi**|`hlb`|<br/>
        /// |**Hani**|`hni`|<br/>
        /// |**Haryanvi**|`bgc`|<br/>
        /// |**Hawaiian**|`haw`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hmong Daw**|`mww`|<br/>
        /// |**Ho**|`hoc`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Inari Sami**|`smn`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Ingush**|`inh`|<br/>
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
        /// |**Kabardian**|`kbd`|<br/>
        /// |**Kabuverdianu**|`kea`|<br/>
        /// |**Kachin**|`kac`|<br/>
        /// |**Kalaallisut**|`kl`|<br/>
        /// |**Kangri**|`xnr`|<br/>
        /// |**Kara-Kalpak**|`kaa`|<br/>
        /// |**Karachay-Balkar**|`krc`|<br/>
        /// |**Kashubian**|`csb`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khaling**|`klr`|<br/>
        /// |**Khasi**|`kha`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Korku**|`kfq`|<br/>
        /// |**Koryak**|`kpy`|<br/>
        /// |**Kosraean**|`kos`|<br/>
        /// |**Kumarbhag Paharia**|`kmj`|<br/>
        /// |**Kumyk**|`kum`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Kurukh**|`kru`|<br/>
        /// |**Kölsch**|`ksh`|<br/>
        /// |**Lak**|`lbe`|<br/>
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lezghian**|`lez`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Maithili**|`mai`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Marshallese**|`mh`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Newari**|`new`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Old English (ca. 450-1100)**|`ang`|<br/>
        /// |**Ossetian**|`os`|<br/>
        /// |**Pali**|`pi`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Romansh**|`rm`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Sadri**|`sck`|<br/>
        /// |**Samoan**|`sm`|<br/>
        /// |**Sanskrit**|`sa`|<br/>
        /// |**Santali**|`sat`|<br/>
        /// |**Scots**|`sco`|<br/>
        /// |**Scottish Gaelic**|`gd`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sherpa**|`xsr`|<br/>
        /// |**Sirmauri**|`srx`|<br/>
        /// |**Skolt Sami**|`sms`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Southern Sami**|`sma`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tabassaran**|`tab`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Tetum**|`tet`|<br/>
        /// |**Thangmi**|`thf`|<br/>
        /// |**Tonga (Tonga Islands)**|`to`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Tuvinian**|`tyv`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Upper Sorbian**|`hsb`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Volapük**|`vo`|<br/>
        /// |**Walser**|`wae`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Yucateco**|`yua`|<br/>
        /// |**Zhuang**|`za`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Arabic (Pseudo-Accents)**|`ar-XA`|<br/>
        /// |**Belarusian**|`be-cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-latn`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**Finnish (Finland)**|`fi-FI`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-latn`|<br/>
        /// |**Korean (South Korea)**|`ko-KR`|<br/>
        /// |**Kurdish (Arabic)**|`ku-arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-latn`|<br/>
        /// |**Polish**|`pl-PO`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Region: Czechia**|`cz-CZ`|<br/>
        /// |**Region: Greece**|`gr-GR`|<br/>
        /// |**Russian (Russia)**|`ru-RU`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// |**Swedish (Sweden)**|`sv-SE`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Uzbek (Arabic)**|`uz-arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.OcrocrResponseModel> OcrOcrOcrCreateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.OcrocrOcrRequest
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
            };

            return await OcrOcrOcrCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}