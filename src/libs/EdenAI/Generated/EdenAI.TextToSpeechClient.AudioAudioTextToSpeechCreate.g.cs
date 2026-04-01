
#nullable enable

namespace EdenAI
{
    public partial class TextToSpeechClient
    {
        partial void PrepareAudioAudioTextToSpeechCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.AudiotextToSpeechTextToSpeechRequest request);
        partial void PrepareAudioAudioTextToSpeechCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.AudiotextToSpeechTextToSpeechRequest request);
        partial void ProcessAudioAudioTextToSpeechCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAudioAudioTextToSpeechCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text to Speech<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|4.0 (per 1000000 char)|1 char<br/>
        /// |**amazon**|**Neural**|`boto3 (v1.15.18)`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|-|`v1`|4.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Standard**|`v1`|4.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Neural**|`v1`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Wavenet**|`v1`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Studio**|`v1`|0.16 (per 1000 char)|1 char<br/>
        /// |**google**|**gemini-2.5-flash-tts**|`v1`|10.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**gemini-2.5-pro-tts**|`v1`|20.0 (per 1000000 char)|None char<br/>
        /// |**microsoft**|-|`v1.0`|16.0 (per 1000000 char)|1 char<br/>
        /// |**lovoai**|-|`v1`|160.0 (per 1000000 char)|1000 char<br/>
        /// |**elevenlabs**|-|`v1`|0.3 (per 1000 char)|1 char<br/>
        /// |**openai**|-|`v1.0`|0.015 (per 1000 char)|1 char<br/>
        /// |**deepgram**|-|`v1`|0.015 (per 1000 char)|1 char<br/>
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
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Malayalam**|`ml`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Mandarin Chinese**|`cmn`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Standard Arabic**|`arb`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Wu Chinese**|`wuu`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans (South Africa)**|`af-ZA`|<br/>
        /// |**Albanian (Albania)**|`sq-AL`|<br/>
        /// |**Amharic (Ethiopia)**|`am-ET`|<br/>
        /// |**Arabic (Algeria)**|`ar-DZ`|<br/>
        /// |**Arabic (Bahrain)**|`ar-BH`|<br/>
        /// |**Arabic (Egypt)**|`ar-EG`|<br/>
        /// |**Arabic (Iraq)**|`ar-IQ`|<br/>
        /// |**Arabic (Jordan)**|`ar-JO`|<br/>
        /// |**Arabic (Kuwait)**|`ar-KW`|<br/>
        /// |**Arabic (Lebanon)**|`ar-LB`|<br/>
        /// |**Arabic (Libya)**|`ar-LY`|<br/>
        /// |**Arabic (Morocco)**|`ar-MA`|<br/>
        /// |**Arabic (Oman)**|`ar-OM`|<br/>
        /// |**Arabic (Pseudo-Accents)**|`ar-XA`|<br/>
        /// |**Arabic (Qatar)**|`ar-QA`|<br/>
        /// |**Arabic (Saudi Arabia)**|`ar-SA`|<br/>
        /// |**Arabic (Syria)**|`ar-SY`|<br/>
        /// |**Arabic (Tunisia)**|`ar-TN`|<br/>
        /// |**Arabic (United Arab Emirates)**|`ar-AE`|<br/>
        /// |**Arabic (Yemen)**|`ar-YE`|<br/>
        /// |**Armenian (Armenia)**|`hy-AM`|<br/>
        /// |**Azerbaijani (Azerbaijan)**|`az-AZ`|<br/>
        /// |**Bangla (Bangladesh)**|`bn-BD`|<br/>
        /// |**Bangla (India)**|`bn-IN`|<br/>
        /// |**Basque (Spain)**|`eu-ES`|<br/>
        /// |**Bosnian (Bosnia &amp; Herzegovina)**|`bs-BA`|<br/>
        /// |**Bulgarian (Bulgaria)**|`bg-BG`|<br/>
        /// |**Burmese (Myanmar (Burma))**|`my-MM`|<br/>
        /// |**Cantonese (China)**|`yue-CN`|<br/>
        /// |**Cantonese (Hong Kong SAR China)**|`yue-HK`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (China)**|`zh-CN-henan`|<br/>
        /// |**Chinese (China)**|`zh-CN-shandong`|<br/>
        /// |**Chinese (China)**|`zh-CN-sichuan`|<br/>
        /// |**Chinese (Hong Kong SAR China)**|`zh-HK`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Croatian (Croatia)**|`hr-HR`|<br/>
        /// |**Czech (Czechia)**|`cs-CZ`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Belgium)**|`nl-BE`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (Australia)**|`en-AU`|<br/>
        /// |**English (Canada)**|`en-CA`|<br/>
        /// |**English (Curaçao)**|`en-AN`|<br/>
        /// |**English (Hong Kong SAR China)**|`en-HK`|<br/>
        /// |**English (India)**|`en-IN`|<br/>
        /// |**English (Ireland)**|`en-IE`|<br/>
        /// |**English (Kenya)**|`en-KE`|<br/>
        /// |**English (New Zealand)**|`en-NZ`|<br/>
        /// |**English (Nigeria)**|`en-NG`|<br/>
        /// |**English (Philippines)**|`en-PH`|<br/>
        /// |**English (Singapore)**|`en-SG`|<br/>
        /// |**English (South Africa)**|`en-ZA`|<br/>
        /// |**English (Tanzania)**|`en-TZ`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**Estonian (Estonia)**|`et-EE`|<br/>
        /// |**Filipino (Philippines)**|`fil-PH`|<br/>
        /// |**Finnish (Finland)**|`fi-FI`|<br/>
        /// |**French (Belgium)**|`fr-BE`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**French (Switzerland)**|`fr-CH`|<br/>
        /// |**Galician (Spain)**|`gl-ES`|<br/>
        /// |**Georgian (Georgia)**|`ka-GE`|<br/>
        /// |**German (Austria)**|`de-AT`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**German (Switzerland)**|`de-CH`|<br/>
        /// |**Greek (Greece)**|`el-GR`|<br/>
        /// |**Gujarati (India)**|`gu-IN`|<br/>
        /// |**Hebrew (Israel)**|`he-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Javanese (Indonesia)**|`jv-ID`|<br/>
        /// |**Kannada (India)**|`kn-IN`|<br/>
        /// |**Kazakh (Kazakhstan)**|`kk-KZ`|<br/>
        /// |**Khmer (Cambodia)**|`km-KH`|<br/>
        /// |**Korean (South Korea)**|`ko-KR`|<br/>
        /// |**Lao (Laos)**|`lo-LA`|<br/>
        /// |**Latvian (Latvia)**|`lv-LV`|<br/>
        /// |**Lithuanian (Lithuania)**|`lt-LT`|<br/>
        /// |**Macedonian (North Macedonia)**|`mk-MK`|<br/>
        /// |**Malay (Malaysia)**|`ms-MY`|<br/>
        /// |**Malayalam (India)**|`ml-IN`|<br/>
        /// |**Maltese (Malta)**|`mt-MT`|<br/>
        /// |**Mandarin Chinese (China)**|`cmn-CN`|<br/>
        /// |**Mandarin Chinese (Taiwan)**|`cmn-TW`|<br/>
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Punjabi (India)**|`pa-IN`|<br/>
        /// |**Romanian (Romania)**|`ro-RO`|<br/>
        /// |**Russian (Russia)**|`ru-RU`|<br/>
        /// |**Serbian (Serbia)**|`sr-RS`|<br/>
        /// |**Sinhala (Sri Lanka)**|`si-LK`|<br/>
        /// |**Slovak (Slovakia)**|`sk-SK`|<br/>
        /// |**Slovenian (Slovenia)**|`sl-SI`|<br/>
        /// |**Somali (Somalia)**|`so-SO`|<br/>
        /// |**Spanish (Argentina)**|`es-AR`|<br/>
        /// |**Spanish (Bolivia)**|`es-BO`|<br/>
        /// |**Spanish (Chile)**|`es-CL`|<br/>
        /// |**Spanish (Colombia)**|`es-CO`|<br/>
        /// |**Spanish (Costa Rica)**|`es-CR`|<br/>
        /// |**Spanish (Cuba)**|`es-CU`|<br/>
        /// |**Spanish (Dominican Republic)**|`es-DO`|<br/>
        /// |**Spanish (Ecuador)**|`es-EC`|<br/>
        /// |**Spanish (El Salvador)**|`es-SV`|<br/>
        /// |**Spanish (Equatorial Guinea)**|`es-GQ`|<br/>
        /// |**Spanish (Guatemala)**|`es-GT`|<br/>
        /// |**Spanish (Honduras)**|`es-HN`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Nicaragua)**|`es-NI`|<br/>
        /// |**Spanish (Panama)**|`es-PA`|<br/>
        /// |**Spanish (Paraguay)**|`es-PY`|<br/>
        /// |**Spanish (Peru)**|`es-PE`|<br/>
        /// |**Spanish (Puerto Rico)**|`es-PR`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// |**Spanish (United States)**|`es-US`|<br/>
        /// |**Spanish (Uruguay)**|`es-UY`|<br/>
        /// |**Spanish (Venezuela)**|`es-VE`|<br/>
        /// |**Sundanese (Indonesia)**|`su-ID`|<br/>
        /// |**Swahili (Kenya)**|`sw-KE`|<br/>
        /// |**Swahili (Tanzania)**|`sw-TZ`|<br/>
        /// |**Swedish (Sweden)**|`sv-SE`|<br/>
        /// |**Tamil (India)**|`ta-IN`|<br/>
        /// |**Tamil (Malaysia)**|`ta-MY`|<br/>
        /// |**Tamil (Singapore)**|`ta-SG`|<br/>
        /// |**Tamil (Sri Lanka)**|`ta-LK`|<br/>
        /// |**Telugu (India)**|`te-IN`|<br/>
        /// |**Thai (Thailand)**|`th-TH`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Ukrainian (Ukraine)**|`uk-UA`|<br/>
        /// |**Urdu (India)**|`ur-IN`|<br/>
        /// |**Urdu (Pakistan)**|`ur-PK`|<br/>
        /// |**Uzbek (United Kingdom)**|`uz-UK`|<br/>
        /// |**Uzbek (Uzbekistan)**|`uz-UZ`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Xhosa (South Africa)**|`xh-ZA`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-text_to_speech' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AudiotextToSpeechResponseModel> AudioAudioTextToSpeechCreateAsync(

            global::EdenAI.AudiotextToSpeechTextToSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAudioAudioTextToSpeechCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/audio/text_to_speech/",
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
            PrepareAudioAudioTextToSpeechCreateRequest(
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
            ProcessAudioAudioTextToSpeechCreateResponse(
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
                ProcessAudioAudioTextToSpeechCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.AudiotextToSpeechResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::EdenAI.AudiotextToSpeechResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Text to Speech<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|4.0 (per 1000000 char)|1 char<br/>
        /// |**amazon**|**Neural**|`boto3 (v1.15.18)`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|-|`v1`|4.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Standard**|`v1`|4.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Neural**|`v1`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Wavenet**|`v1`|16.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**Studio**|`v1`|0.16 (per 1000 char)|1 char<br/>
        /// |**google**|**gemini-2.5-flash-tts**|`v1`|10.0 (per 1000000 char)|1 char<br/>
        /// |**google**|**gemini-2.5-pro-tts**|`v1`|20.0 (per 1000000 char)|None char<br/>
        /// |**microsoft**|-|`v1.0`|16.0 (per 1000000 char)|1 char<br/>
        /// |**lovoai**|-|`v1`|160.0 (per 1000000 char)|1000 char<br/>
        /// |**elevenlabs**|-|`v1`|0.3 (per 1000 char)|1 char<br/>
        /// |**openai**|-|`v1.0`|0.015 (per 1000 char)|1 char<br/>
        /// |**deepgram**|-|`v1`|0.015 (per 1000 char)|1 char<br/>
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
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Malayalam**|`ml`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Mandarin Chinese**|`cmn`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Standard Arabic**|`arb`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Wu Chinese**|`wuu`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans (South Africa)**|`af-ZA`|<br/>
        /// |**Albanian (Albania)**|`sq-AL`|<br/>
        /// |**Amharic (Ethiopia)**|`am-ET`|<br/>
        /// |**Arabic (Algeria)**|`ar-DZ`|<br/>
        /// |**Arabic (Bahrain)**|`ar-BH`|<br/>
        /// |**Arabic (Egypt)**|`ar-EG`|<br/>
        /// |**Arabic (Iraq)**|`ar-IQ`|<br/>
        /// |**Arabic (Jordan)**|`ar-JO`|<br/>
        /// |**Arabic (Kuwait)**|`ar-KW`|<br/>
        /// |**Arabic (Lebanon)**|`ar-LB`|<br/>
        /// |**Arabic (Libya)**|`ar-LY`|<br/>
        /// |**Arabic (Morocco)**|`ar-MA`|<br/>
        /// |**Arabic (Oman)**|`ar-OM`|<br/>
        /// |**Arabic (Pseudo-Accents)**|`ar-XA`|<br/>
        /// |**Arabic (Qatar)**|`ar-QA`|<br/>
        /// |**Arabic (Saudi Arabia)**|`ar-SA`|<br/>
        /// |**Arabic (Syria)**|`ar-SY`|<br/>
        /// |**Arabic (Tunisia)**|`ar-TN`|<br/>
        /// |**Arabic (United Arab Emirates)**|`ar-AE`|<br/>
        /// |**Arabic (Yemen)**|`ar-YE`|<br/>
        /// |**Armenian (Armenia)**|`hy-AM`|<br/>
        /// |**Azerbaijani (Azerbaijan)**|`az-AZ`|<br/>
        /// |**Bangla (Bangladesh)**|`bn-BD`|<br/>
        /// |**Bangla (India)**|`bn-IN`|<br/>
        /// |**Basque (Spain)**|`eu-ES`|<br/>
        /// |**Bosnian (Bosnia &amp; Herzegovina)**|`bs-BA`|<br/>
        /// |**Bulgarian (Bulgaria)**|`bg-BG`|<br/>
        /// |**Burmese (Myanmar (Burma))**|`my-MM`|<br/>
        /// |**Cantonese (China)**|`yue-CN`|<br/>
        /// |**Cantonese (Hong Kong SAR China)**|`yue-HK`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (China)**|`zh-CN-henan`|<br/>
        /// |**Chinese (China)**|`zh-CN-shandong`|<br/>
        /// |**Chinese (China)**|`zh-CN-sichuan`|<br/>
        /// |**Chinese (Hong Kong SAR China)**|`zh-HK`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Croatian (Croatia)**|`hr-HR`|<br/>
        /// |**Czech (Czechia)**|`cs-CZ`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Belgium)**|`nl-BE`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (Australia)**|`en-AU`|<br/>
        /// |**English (Canada)**|`en-CA`|<br/>
        /// |**English (Curaçao)**|`en-AN`|<br/>
        /// |**English (Hong Kong SAR China)**|`en-HK`|<br/>
        /// |**English (India)**|`en-IN`|<br/>
        /// |**English (Ireland)**|`en-IE`|<br/>
        /// |**English (Kenya)**|`en-KE`|<br/>
        /// |**English (New Zealand)**|`en-NZ`|<br/>
        /// |**English (Nigeria)**|`en-NG`|<br/>
        /// |**English (Philippines)**|`en-PH`|<br/>
        /// |**English (Singapore)**|`en-SG`|<br/>
        /// |**English (South Africa)**|`en-ZA`|<br/>
        /// |**English (Tanzania)**|`en-TZ`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**Estonian (Estonia)**|`et-EE`|<br/>
        /// |**Filipino (Philippines)**|`fil-PH`|<br/>
        /// |**Finnish (Finland)**|`fi-FI`|<br/>
        /// |**French (Belgium)**|`fr-BE`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**French (France)**|`fr-FR`|<br/>
        /// |**French (Switzerland)**|`fr-CH`|<br/>
        /// |**Galician (Spain)**|`gl-ES`|<br/>
        /// |**Georgian (Georgia)**|`ka-GE`|<br/>
        /// |**German (Austria)**|`de-AT`|<br/>
        /// |**German (Germany)**|`de-DE`|<br/>
        /// |**German (Switzerland)**|`de-CH`|<br/>
        /// |**Greek (Greece)**|`el-GR`|<br/>
        /// |**Gujarati (India)**|`gu-IN`|<br/>
        /// |**Hebrew (Israel)**|`he-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Javanese (Indonesia)**|`jv-ID`|<br/>
        /// |**Kannada (India)**|`kn-IN`|<br/>
        /// |**Kazakh (Kazakhstan)**|`kk-KZ`|<br/>
        /// |**Khmer (Cambodia)**|`km-KH`|<br/>
        /// |**Korean (South Korea)**|`ko-KR`|<br/>
        /// |**Lao (Laos)**|`lo-LA`|<br/>
        /// |**Latvian (Latvia)**|`lv-LV`|<br/>
        /// |**Lithuanian (Lithuania)**|`lt-LT`|<br/>
        /// |**Macedonian (North Macedonia)**|`mk-MK`|<br/>
        /// |**Malay (Malaysia)**|`ms-MY`|<br/>
        /// |**Malayalam (India)**|`ml-IN`|<br/>
        /// |**Maltese (Malta)**|`mt-MT`|<br/>
        /// |**Mandarin Chinese (China)**|`cmn-CN`|<br/>
        /// |**Mandarin Chinese (Taiwan)**|`cmn-TW`|<br/>
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Punjabi (India)**|`pa-IN`|<br/>
        /// |**Romanian (Romania)**|`ro-RO`|<br/>
        /// |**Russian (Russia)**|`ru-RU`|<br/>
        /// |**Serbian (Serbia)**|`sr-RS`|<br/>
        /// |**Sinhala (Sri Lanka)**|`si-LK`|<br/>
        /// |**Slovak (Slovakia)**|`sk-SK`|<br/>
        /// |**Slovenian (Slovenia)**|`sl-SI`|<br/>
        /// |**Somali (Somalia)**|`so-SO`|<br/>
        /// |**Spanish (Argentina)**|`es-AR`|<br/>
        /// |**Spanish (Bolivia)**|`es-BO`|<br/>
        /// |**Spanish (Chile)**|`es-CL`|<br/>
        /// |**Spanish (Colombia)**|`es-CO`|<br/>
        /// |**Spanish (Costa Rica)**|`es-CR`|<br/>
        /// |**Spanish (Cuba)**|`es-CU`|<br/>
        /// |**Spanish (Dominican Republic)**|`es-DO`|<br/>
        /// |**Spanish (Ecuador)**|`es-EC`|<br/>
        /// |**Spanish (El Salvador)**|`es-SV`|<br/>
        /// |**Spanish (Equatorial Guinea)**|`es-GQ`|<br/>
        /// |**Spanish (Guatemala)**|`es-GT`|<br/>
        /// |**Spanish (Honduras)**|`es-HN`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Nicaragua)**|`es-NI`|<br/>
        /// |**Spanish (Panama)**|`es-PA`|<br/>
        /// |**Spanish (Paraguay)**|`es-PY`|<br/>
        /// |**Spanish (Peru)**|`es-PE`|<br/>
        /// |**Spanish (Puerto Rico)**|`es-PR`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// |**Spanish (United States)**|`es-US`|<br/>
        /// |**Spanish (Uruguay)**|`es-UY`|<br/>
        /// |**Spanish (Venezuela)**|`es-VE`|<br/>
        /// |**Sundanese (Indonesia)**|`su-ID`|<br/>
        /// |**Swahili (Kenya)**|`sw-KE`|<br/>
        /// |**Swahili (Tanzania)**|`sw-TZ`|<br/>
        /// |**Swedish (Sweden)**|`sv-SE`|<br/>
        /// |**Tamil (India)**|`ta-IN`|<br/>
        /// |**Tamil (Malaysia)**|`ta-MY`|<br/>
        /// |**Tamil (Singapore)**|`ta-SG`|<br/>
        /// |**Tamil (Sri Lanka)**|`ta-LK`|<br/>
        /// |**Telugu (India)**|`te-IN`|<br/>
        /// |**Thai (Thailand)**|`th-TH`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Ukrainian (Ukraine)**|`uk-UA`|<br/>
        /// |**Urdu (India)**|`ur-IN`|<br/>
        /// |**Urdu (Pakistan)**|`ur-PK`|<br/>
        /// |**Uzbek (United Kingdom)**|`uz-UK`|<br/>
        /// |**Uzbek (Uzbekistan)**|`uz-UZ`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Xhosa (South Africa)**|`xh-ZA`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-text_to_speech' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
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
        /// Language code expected (ex: en, fr)
        /// </param>
        /// <param name="option"></param>
        /// <param name="rate">
        /// Increase or decrease the speaking rate by expressing a positif or negatif number ranging between             100 and -100 (a relative value as percentage varying from -100% to 100%)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pitch">
        /// Increase or decrease the speaking pitch by expressing a positif or negatif number ranging between             100 and -100 (a relative value as percentage varying from -100% to 100%)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="volume">
        /// Increase or decrease the audio volume by expressing a positif or negatif number ranging between             100 and -100 (a relative value as percentage varying from -100% to 100%)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="audioFormat">
        /// Optional parameter to specify the audio format in which the audio will be generated. By default,             audios are encoded in MP3, except for lovoai which use the wav container.
        /// </param>
        /// <param name="samplingRate">
        /// Optional. The synthesis sample rate (in hertz) for this audio. When this is specified, the audio will be converted             either to the right passed value, or to a the nearest value acceptable by the provider<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AudiotextToSpeechResponseModel> AudioAudioTextToSpeechCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? language = default,
            global::EdenAI.OneOf<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>? option = default,
            int? rate = default,
            int? pitch = default,
            int? volume = default,
            string? audioFormat = default,
            int? samplingRate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.AudiotextToSpeechTextToSpeechRequest
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
                Option = option,
                Rate = rate,
                Pitch = pitch,
                Volume = volume,
                AudioFormat = audioFormat,
                SamplingRate = samplingRate,
            };

            return await AudioAudioTextToSpeechCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}