
#nullable enable

namespace EdenAI
{
    public partial class TextToSpeechAsyncClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioTextToSpeechAsyncCreateSecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioTextToSpeechAsyncCreateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AudioAudioTextToSpeechAsyncCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AudioAudioTextToSpeechAsyncCreateSecurityRequirement0,
                s_AudioAudioTextToSpeechAsyncCreateSecurityRequirement1,
            };
        partial void PrepareAudioAudioTextToSpeechAsyncCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.TextToSpeechAsyncRequest request);
        partial void PrepareAudioAudioTextToSpeechAsyncCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.TextToSpeechAsyncRequest request);
        partial void ProcessAudioAudioTextToSpeechAsyncCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAudioAudioTextToSpeechAsyncCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text to Speech launch job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**lovoai**|-|`v1`|0.16 (per 1000 char)|1 char<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|4.0 (per 1000000 char)|1 char<br/>
        /// |**amazon**|**Neural**|`boto3 (v1.15.18)`|16.0 (per 1000000 char)|1 char<br/>
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
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
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
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
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
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
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
        /// |**Arabic (Qatar)**|`ar-QA`|<br/>
        /// |**Arabic (Saudi Arabia)**|`ar-SA`|<br/>
        /// |**Arabic (Tunisia)**|`ar-TN`|<br/>
        /// |**Arabic (United Arab Emirates)**|`ar-AE`|<br/>
        /// |**Armenian (Armenia)**|`hy-AM`|<br/>
        /// |**Azerbaijani (Azerbaijan)**|`az-AZ`|<br/>
        /// |**Bangla (India)**|`bn-IN`|<br/>
        /// |**Basque (Spain)**|`eu-ES`|<br/>
        /// |**Bosnian (Bosnia &amp; Herzegovina)**|`bs-BA`|<br/>
        /// |**Burmese (Myanmar (Burma))**|`my-MM`|<br/>
        /// |**Cantonese (China)**|`yue-CN`|<br/>
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
        /// |**Hebrew (Israel)**|`he-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Javanese (Indonesia)**|`jv-ID`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
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
        /// |**Spanish (Ecuador)**|`es-EC`|<br/>
        /// |**Spanish (El Salvador)**|`es-SV`|<br/>
        /// |**Spanish (Equatorial Guinea)**|`es-GQ`|<br/>
        /// |**Spanish (Guatemala)**|`es-GT`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Nicaragua)**|`es-NI`|<br/>
        /// |**Spanish (Panama)**|`es-PA`|<br/>
        /// |**Spanish (Paraguay)**|`es-PY`|<br/>
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
        /// |**Telugu (India)**|`te-IN`|<br/>
        /// |**Thai (Thailand)**|`th-TH`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Ukrainian (Ukraine)**|`uk-UA`|<br/>
        /// |**Urdu (India)**|`ur-IN`|<br/>
        /// |**Urdu (Pakistan)**|`ur-PK`|<br/>
        /// |**Uzbek (United Kingdom)**|`uz-UK`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Xhosa (South Africa)**|`xh-ZA`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-text_to_speech_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> AudioAudioTextToSpeechAsyncCreateAsync(

            global::EdenAI.TextToSpeechAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AudioAudioTextToSpeechAsyncCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Text to Speech launch job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**lovoai**|-|`v1`|0.16 (per 1000 char)|1 char<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|4.0 (per 1000000 char)|1 char<br/>
        /// |**amazon**|**Neural**|`boto3 (v1.15.18)`|16.0 (per 1000000 char)|1 char<br/>
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
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
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
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
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
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
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
        /// |**Arabic (Qatar)**|`ar-QA`|<br/>
        /// |**Arabic (Saudi Arabia)**|`ar-SA`|<br/>
        /// |**Arabic (Tunisia)**|`ar-TN`|<br/>
        /// |**Arabic (United Arab Emirates)**|`ar-AE`|<br/>
        /// |**Armenian (Armenia)**|`hy-AM`|<br/>
        /// |**Azerbaijani (Azerbaijan)**|`az-AZ`|<br/>
        /// |**Bangla (India)**|`bn-IN`|<br/>
        /// |**Basque (Spain)**|`eu-ES`|<br/>
        /// |**Bosnian (Bosnia &amp; Herzegovina)**|`bs-BA`|<br/>
        /// |**Burmese (Myanmar (Burma))**|`my-MM`|<br/>
        /// |**Cantonese (China)**|`yue-CN`|<br/>
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
        /// |**Hebrew (Israel)**|`he-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Javanese (Indonesia)**|`jv-ID`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
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
        /// |**Spanish (Ecuador)**|`es-EC`|<br/>
        /// |**Spanish (El Salvador)**|`es-SV`|<br/>
        /// |**Spanish (Equatorial Guinea)**|`es-GQ`|<br/>
        /// |**Spanish (Guatemala)**|`es-GT`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Nicaragua)**|`es-NI`|<br/>
        /// |**Spanish (Panama)**|`es-PA`|<br/>
        /// |**Spanish (Paraguay)**|`es-PY`|<br/>
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
        /// |**Telugu (India)**|`te-IN`|<br/>
        /// |**Thai (Thailand)**|`th-TH`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Ukrainian (Ukraine)**|`uk-UA`|<br/>
        /// |**Urdu (India)**|`ur-IN`|<br/>
        /// |**Urdu (Pakistan)**|`ur-PK`|<br/>
        /// |**Uzbek (United Kingdom)**|`uz-UK`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Xhosa (South Africa)**|`xh-ZA`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-text_to_speech_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> AudioAudioTextToSpeechAsyncCreateAsResponseAsync(

            global::EdenAI.TextToSpeechAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAudioAudioTextToSpeechAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioAudioTextToSpeechAsyncCreateSecurityRequirements,
                operationName: "AudioAudioTextToSpeechAsyncCreateAsync");

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
                                path: "/audio/text_to_speech_async/",
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
                            if (request.ResponseAsDict != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ResponseAsDict, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"response_as_dict\"");

                            }
                            if (request.AttributesAsList != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AttributesAsList, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"attributes_as_list\"");

                            }
                            if (request.ShowBase64 != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ShowBase64, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"show_base_64\"");

                            }
                            if (request.ShowOriginalResponse != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ShowOriginalResponse, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"show_original_response\"");

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Text ?? string.Empty),
                                name: "\"text\"");

                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");

                            }
                            if (request.Option != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Option.ToString() ?? string.Empty),
                                    name: "\"option\"");

                            }
                            if (request.Rate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Rate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"rate\"");

                            }
                            if (request.Pitch != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Pitch, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"pitch\"");

                            }
                            if (request.Volume != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Volume, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"volume\"");

                            }
                            if (request.AudioFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AudioFormat ?? string.Empty),
                                    name: "\"audio_format\"");

                            }
                            if (request.SamplingRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.SamplingRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"sampling_rate\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAudioAudioTextToSpeechAsyncCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                global::EdenAI.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

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
                                operationId: "AudioAudioTextToSpeechAsyncCreate",
                                methodName: "AudioAudioTextToSpeechAsyncCreateAsync",
                                pathTemplate: "\"/audio/text_to_speech_async/\"",
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
                                operationId: "AudioAudioTextToSpeechAsyncCreate",
                                methodName: "AudioAudioTextToSpeechAsyncCreateAsync",
                                pathTemplate: "\"/audio/text_to_speech_async/\"",
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
                                operationId: "AudioAudioTextToSpeechAsyncCreate",
                                methodName: "AudioAudioTextToSpeechAsyncCreateAsync",
                                pathTemplate: "\"/audio/text_to_speech_async/\"",
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
                ProcessAudioAudioTextToSpeechAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioAudioTextToSpeechAsyncCreate",
                                methodName: "AudioAudioTextToSpeechAsyncCreateAsync",
                                pathTemplate: "\"/audio/text_to_speech_async/\"",
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
                                operationId: "AudioAudioTextToSpeechAsyncCreate",
                                methodName: "AudioAudioTextToSpeechAsyncCreateAsync",
                                pathTemplate: "\"/audio/text_to_speech_async/\"",
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
                                ProcessAudioAudioTextToSpeechAsyncCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::EdenAI.LaunchAsyncJobResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>(
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

                                    var __value = await global::EdenAI.LaunchAsyncJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>(
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
        /// Text to Speech launch job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**lovoai**|-|`v1`|0.16 (per 1000 char)|1 char<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|4.0 (per 1000000 char)|1 char<br/>
        /// |**amazon**|**Neural**|`boto3 (v1.15.18)`|16.0 (per 1000000 char)|1 char<br/>
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
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
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
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
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
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
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
        /// |**Arabic (Qatar)**|`ar-QA`|<br/>
        /// |**Arabic (Saudi Arabia)**|`ar-SA`|<br/>
        /// |**Arabic (Tunisia)**|`ar-TN`|<br/>
        /// |**Arabic (United Arab Emirates)**|`ar-AE`|<br/>
        /// |**Armenian (Armenia)**|`hy-AM`|<br/>
        /// |**Azerbaijani (Azerbaijan)**|`az-AZ`|<br/>
        /// |**Bangla (India)**|`bn-IN`|<br/>
        /// |**Basque (Spain)**|`eu-ES`|<br/>
        /// |**Bosnian (Bosnia &amp; Herzegovina)**|`bs-BA`|<br/>
        /// |**Burmese (Myanmar (Burma))**|`my-MM`|<br/>
        /// |**Cantonese (China)**|`yue-CN`|<br/>
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
        /// |**Hebrew (Israel)**|`he-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Japanese (Japan)**|`ja-JP`|<br/>
        /// |**Javanese (Indonesia)**|`jv-ID`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
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
        /// |**Spanish (Ecuador)**|`es-EC`|<br/>
        /// |**Spanish (El Salvador)**|`es-SV`|<br/>
        /// |**Spanish (Equatorial Guinea)**|`es-GQ`|<br/>
        /// |**Spanish (Guatemala)**|`es-GT`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Nicaragua)**|`es-NI`|<br/>
        /// |**Spanish (Panama)**|`es-PA`|<br/>
        /// |**Spanish (Paraguay)**|`es-PY`|<br/>
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
        /// |**Telugu (India)**|`te-IN`|<br/>
        /// |**Thai (Thailand)**|`th-TH`|<br/>
        /// |**Turkish (Türkiye)**|`tr-TR`|<br/>
        /// |**Ukrainian (Ukraine)**|`uk-UA`|<br/>
        /// |**Urdu (India)**|`ur-IN`|<br/>
        /// |**Urdu (Pakistan)**|`ur-PK`|<br/>
        /// |**Uzbek (United Kingdom)**|`uz-UK`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Xhosa (South Africa)**|`xh-ZA`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-text_to_speech_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> AudioAudioTextToSpeechAsyncCreateAsync(
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
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.TextToSpeechAsyncRequest
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
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
            };

            return await AudioAudioTextToSpeechAsyncCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}