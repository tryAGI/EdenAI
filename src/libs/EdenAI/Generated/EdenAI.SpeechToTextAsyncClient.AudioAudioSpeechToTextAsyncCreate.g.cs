
#nullable enable

namespace EdenAI
{
    public partial class SpeechToTextAsyncClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioSpeechToTextAsyncCreateSecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioSpeechToTextAsyncCreateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AudioAudioSpeechToTextAsyncCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AudioAudioSpeechToTextAsyncCreateSecurityRequirement0,
                s_AudioAudioSpeechToTextAsyncCreateSecurityRequirement1,
            };
        partial void PrepareAudioAudioSpeechToTextAsyncCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.SpeechToTextAsyncRequest request);
        partial void PrepareAudioAudioSpeechToTextAsyncCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.SpeechToTextAsyncRequest request);
        partial void ProcessAudioAudioSpeechToTextAsyncCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAudioAudioSpeechToTextAsyncCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Speech to Text Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|0.024 (per 60 seconde)|15 seconde<br/>
        /// |**google**|-|`v1p1beta1`|0.024 (per 60 seconde)|1 seconde<br/>
        /// |**microsoft**|-|`v1.0`|0.0168 (per 60 seconde)|1 seconde<br/>
        /// |**assembly**|-|`v2`|0.011 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**nova-3**|`v1`|0.0052 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**enhanced**|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|-|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**base**|`v1`|0.0169 (per 60 seconde)|1 seconde<br/>
        /// |**openai**|-|`boto3 (v1.15.18)`|0.006 (per 60 seconde)|1 seconde<br/>
        /// |**gladia**|-|`v1`|0.0102 (per 60 seconde)|1 seconde<br/>
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
        /// |**Bashkir**|`ba`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Breton**|`br`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Burmese**|`my`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Hausa**|`ha`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hebrew**|`iw`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
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
        /// |**Lingala**|`ln`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malagasy**|`mg`|<br/>
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
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`mo`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sindhi**|`sd`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Wu Chinese**|`wuu`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// |**at**|`at`|<br/>
        /// |**jp**|`jp`|<br/>
        /// |**mymr**|`mymr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Afrikaans (South Africa)**|`af-ZA`|<br/>
        /// |**Albanian (Albania)**|`sq-AL`|<br/>
        /// |**Amharic (Ethiopia)**|`am-ET`|<br/>
        /// |**Arabic (Algeria)**|`ar-DZ`|<br/>
        /// |**Arabic (Bahrain)**|`ar-BH`|<br/>
        /// |**Arabic (Egypt)**|`ar-EG`|<br/>
        /// |**Arabic (Iraq)**|`ar-IQ`|<br/>
        /// |**Arabic (Israel)**|`ar-IL`|<br/>
        /// |**Arabic (Jordan)**|`ar-JO`|<br/>
        /// |**Arabic (Kuwait)**|`ar-KW`|<br/>
        /// |**Arabic (Lebanon)**|`ar-LB`|<br/>
        /// |**Arabic (Libya)**|`ar-LY`|<br/>
        /// |**Arabic (Mauritania)**|`ar-MR`|<br/>
        /// |**Arabic (Morocco)**|`ar-MA`|<br/>
        /// |**Arabic (Oman)**|`ar-OM`|<br/>
        /// |**Arabic (Palestinian Territories)**|`ar-PS`|<br/>
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
        /// |**Cantonese (Traditional, Hong Kong SAR China)**|`yue-Hant-HK`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Hong Kong SAR China)**|`zh-HK`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Croatian (Croatia)**|`hr-HR`|<br/>
        /// |**Czech (Czechia)**|`cs-CZ`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Belgium)**|`nl-BE`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (Australia)**|`en-AU`|<br/>
        /// |**English (Canada)**|`en-CA`|<br/>
        /// |**English (Ghana)**|`en-GH`|<br/>
        /// |**English (Hong Kong SAR China)**|`en-HK`|<br/>
        /// |**English (India)**|`en-IN`|<br/>
        /// |**English (Ireland)**|`en-IE`|<br/>
        /// |**English (Kenya)**|`en-KE`|<br/>
        /// |**English (New Zealand)**|`en-NZ`|<br/>
        /// |**English (Nigeria)**|`en-NG`|<br/>
        /// |**English (Pakistan)**|`en-PK`|<br/>
        /// |**English (Philippines)**|`en-PH`|<br/>
        /// |**English (Singapore)**|`en-SG`|<br/>
        /// |**English (South Africa)**|`en-ZA`|<br/>
        /// |**English (Tanzania)**|`en-TZ`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United Kingdom)**|`en-UK`|<br/>
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
        /// |**Hebrew (Israel)**|`iw-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hindi (Latin)**|`hi-Latn`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Italian (Switzerland)**|`it-CH`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian (Norway)**|`no-NO`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Punjabi (India)**|`pa-Guru-IN`|<br/>
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
        /// |**Spanish (Latin America)**|`es-419`|<br/>
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
        /// |**Uzbek (Uzbekistan)**|`uz-UZ`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-speech_to_text_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**deepgram**|`enhanced`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> AudioAudioSpeechToTextAsyncCreateAsync(

            global::EdenAI.SpeechToTextAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AudioAudioSpeechToTextAsyncCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Speech to Text Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|0.024 (per 60 seconde)|15 seconde<br/>
        /// |**google**|-|`v1p1beta1`|0.024 (per 60 seconde)|1 seconde<br/>
        /// |**microsoft**|-|`v1.0`|0.0168 (per 60 seconde)|1 seconde<br/>
        /// |**assembly**|-|`v2`|0.011 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**nova-3**|`v1`|0.0052 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**enhanced**|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|-|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**base**|`v1`|0.0169 (per 60 seconde)|1 seconde<br/>
        /// |**openai**|-|`boto3 (v1.15.18)`|0.006 (per 60 seconde)|1 seconde<br/>
        /// |**gladia**|-|`v1`|0.0102 (per 60 seconde)|1 seconde<br/>
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
        /// |**Bashkir**|`ba`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Breton**|`br`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Burmese**|`my`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Hausa**|`ha`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hebrew**|`iw`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
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
        /// |**Lingala**|`ln`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malagasy**|`mg`|<br/>
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
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`mo`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sindhi**|`sd`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Wu Chinese**|`wuu`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// |**at**|`at`|<br/>
        /// |**jp**|`jp`|<br/>
        /// |**mymr**|`mymr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Afrikaans (South Africa)**|`af-ZA`|<br/>
        /// |**Albanian (Albania)**|`sq-AL`|<br/>
        /// |**Amharic (Ethiopia)**|`am-ET`|<br/>
        /// |**Arabic (Algeria)**|`ar-DZ`|<br/>
        /// |**Arabic (Bahrain)**|`ar-BH`|<br/>
        /// |**Arabic (Egypt)**|`ar-EG`|<br/>
        /// |**Arabic (Iraq)**|`ar-IQ`|<br/>
        /// |**Arabic (Israel)**|`ar-IL`|<br/>
        /// |**Arabic (Jordan)**|`ar-JO`|<br/>
        /// |**Arabic (Kuwait)**|`ar-KW`|<br/>
        /// |**Arabic (Lebanon)**|`ar-LB`|<br/>
        /// |**Arabic (Libya)**|`ar-LY`|<br/>
        /// |**Arabic (Mauritania)**|`ar-MR`|<br/>
        /// |**Arabic (Morocco)**|`ar-MA`|<br/>
        /// |**Arabic (Oman)**|`ar-OM`|<br/>
        /// |**Arabic (Palestinian Territories)**|`ar-PS`|<br/>
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
        /// |**Cantonese (Traditional, Hong Kong SAR China)**|`yue-Hant-HK`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Hong Kong SAR China)**|`zh-HK`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Croatian (Croatia)**|`hr-HR`|<br/>
        /// |**Czech (Czechia)**|`cs-CZ`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Belgium)**|`nl-BE`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (Australia)**|`en-AU`|<br/>
        /// |**English (Canada)**|`en-CA`|<br/>
        /// |**English (Ghana)**|`en-GH`|<br/>
        /// |**English (Hong Kong SAR China)**|`en-HK`|<br/>
        /// |**English (India)**|`en-IN`|<br/>
        /// |**English (Ireland)**|`en-IE`|<br/>
        /// |**English (Kenya)**|`en-KE`|<br/>
        /// |**English (New Zealand)**|`en-NZ`|<br/>
        /// |**English (Nigeria)**|`en-NG`|<br/>
        /// |**English (Pakistan)**|`en-PK`|<br/>
        /// |**English (Philippines)**|`en-PH`|<br/>
        /// |**English (Singapore)**|`en-SG`|<br/>
        /// |**English (South Africa)**|`en-ZA`|<br/>
        /// |**English (Tanzania)**|`en-TZ`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United Kingdom)**|`en-UK`|<br/>
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
        /// |**Hebrew (Israel)**|`iw-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hindi (Latin)**|`hi-Latn`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Italian (Switzerland)**|`it-CH`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian (Norway)**|`no-NO`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Punjabi (India)**|`pa-Guru-IN`|<br/>
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
        /// |**Spanish (Latin America)**|`es-419`|<br/>
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
        /// |**Uzbek (Uzbekistan)**|`uz-UZ`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-speech_to_text_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**deepgram**|`enhanced`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> AudioAudioSpeechToTextAsyncCreateAsResponseAsync(

            global::EdenAI.SpeechToTextAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAudioAudioSpeechToTextAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioAudioSpeechToTextAsyncCreateSecurityRequirements,
                operationName: "AudioAudioSpeechToTextAsyncCreateAsync");

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
                                path: "/audio/speech_to_text_async/",
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
                            if (request.ProviderParams != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ProviderParams ?? string.Empty),
                                    name: "\"provider_params\"");

                            }
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
                            if (request.FileUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.FileUrl ?? string.Empty),
                                    name: "\"file_url\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");

                            }
                            if (request.Speakers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Speakers, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"speakers\"");

                            }
                            if (request.ProfanityFilter != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ProfanityFilter, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"profanity_filter\"");

                            }
                            if (request.CustomVocabulary != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.CustomVocabulary ?? string.Empty),
                                    name: "\"custom_vocabulary\"");

                            }
                            if (request.ConvertToWav != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ConvertToWav, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"convert_to_wav\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAudioAudioSpeechToTextAsyncCreateRequest(
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
                                operationId: "AudioAudioSpeechToTextAsyncCreate",
                                methodName: "AudioAudioSpeechToTextAsyncCreateAsync",
                                pathTemplate: "\"/audio/speech_to_text_async/\"",
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
                                operationId: "AudioAudioSpeechToTextAsyncCreate",
                                methodName: "AudioAudioSpeechToTextAsyncCreateAsync",
                                pathTemplate: "\"/audio/speech_to_text_async/\"",
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
                                operationId: "AudioAudioSpeechToTextAsyncCreate",
                                methodName: "AudioAudioSpeechToTextAsyncCreateAsync",
                                pathTemplate: "\"/audio/speech_to_text_async/\"",
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
                ProcessAudioAudioSpeechToTextAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioAudioSpeechToTextAsyncCreate",
                                methodName: "AudioAudioSpeechToTextAsyncCreateAsync",
                                pathTemplate: "\"/audio/speech_to_text_async/\"",
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
                                operationId: "AudioAudioSpeechToTextAsyncCreate",
                                methodName: "AudioAudioSpeechToTextAsyncCreateAsync",
                                pathTemplate: "\"/audio/speech_to_text_async/\"",
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
                                ProcessAudioAudioSpeechToTextAsyncCreateResponseContent(
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
        /// Speech to Text Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|0.024 (per 60 seconde)|15 seconde<br/>
        /// |**google**|-|`v1p1beta1`|0.024 (per 60 seconde)|1 seconde<br/>
        /// |**microsoft**|-|`v1.0`|0.0168 (per 60 seconde)|1 seconde<br/>
        /// |**assembly**|-|`v2`|0.011 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**nova-3**|`v1`|0.0052 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**enhanced**|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|-|`v1`|0.0189 (per 60 seconde)|1 seconde<br/>
        /// |**deepgram**|**base**|`v1`|0.0169 (per 60 seconde)|1 seconde<br/>
        /// |**openai**|-|`boto3 (v1.15.18)`|0.006 (per 60 seconde)|1 seconde<br/>
        /// |**gladia**|-|`v1`|0.0102 (per 60 seconde)|1 seconde<br/>
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
        /// |**Bashkir**|`ba`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
        /// |**Bosnian**|`bs`|<br/>
        /// |**Breton**|`br`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Burmese**|`my`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Filipino**|`fil`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Galician**|`gl`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Gujarati**|`gu`|<br/>
        /// |**Haitian**|`ht`|<br/>
        /// |**Hausa**|`ha`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hebrew**|`iw`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
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
        /// |**Lingala**|`ln`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Macedonian**|`mk`|<br/>
        /// |**Malagasy**|`mg`|<br/>
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
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Romanian**|`mo`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Serbian**|`sr`|<br/>
        /// |**Sindhi**|`sd`|<br/>
        /// |**Sinhala**|`si`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Somali**|`so`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Sundanese**|`su`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Wu Chinese**|`wuu`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// |**at**|`at`|<br/>
        /// |**jp**|`jp`|<br/>
        /// |**mymr**|`mymr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Afrikaans (South Africa)**|`af-ZA`|<br/>
        /// |**Albanian (Albania)**|`sq-AL`|<br/>
        /// |**Amharic (Ethiopia)**|`am-ET`|<br/>
        /// |**Arabic (Algeria)**|`ar-DZ`|<br/>
        /// |**Arabic (Bahrain)**|`ar-BH`|<br/>
        /// |**Arabic (Egypt)**|`ar-EG`|<br/>
        /// |**Arabic (Iraq)**|`ar-IQ`|<br/>
        /// |**Arabic (Israel)**|`ar-IL`|<br/>
        /// |**Arabic (Jordan)**|`ar-JO`|<br/>
        /// |**Arabic (Kuwait)**|`ar-KW`|<br/>
        /// |**Arabic (Lebanon)**|`ar-LB`|<br/>
        /// |**Arabic (Libya)**|`ar-LY`|<br/>
        /// |**Arabic (Mauritania)**|`ar-MR`|<br/>
        /// |**Arabic (Morocco)**|`ar-MA`|<br/>
        /// |**Arabic (Oman)**|`ar-OM`|<br/>
        /// |**Arabic (Palestinian Territories)**|`ar-PS`|<br/>
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
        /// |**Cantonese (Traditional, Hong Kong SAR China)**|`yue-Hant-HK`|<br/>
        /// |**Catalan (Spain)**|`ca-ES`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Hong Kong SAR China)**|`zh-HK`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Croatian (Croatia)**|`hr-HR`|<br/>
        /// |**Czech (Czechia)**|`cs-CZ`|<br/>
        /// |**Danish (Denmark)**|`da-DK`|<br/>
        /// |**Dutch (Belgium)**|`nl-BE`|<br/>
        /// |**Dutch (Netherlands)**|`nl-NL`|<br/>
        /// |**English (Australia)**|`en-AU`|<br/>
        /// |**English (Canada)**|`en-CA`|<br/>
        /// |**English (Ghana)**|`en-GH`|<br/>
        /// |**English (Hong Kong SAR China)**|`en-HK`|<br/>
        /// |**English (India)**|`en-IN`|<br/>
        /// |**English (Ireland)**|`en-IE`|<br/>
        /// |**English (Kenya)**|`en-KE`|<br/>
        /// |**English (New Zealand)**|`en-NZ`|<br/>
        /// |**English (Nigeria)**|`en-NG`|<br/>
        /// |**English (Pakistan)**|`en-PK`|<br/>
        /// |**English (Philippines)**|`en-PH`|<br/>
        /// |**English (Singapore)**|`en-SG`|<br/>
        /// |**English (South Africa)**|`en-ZA`|<br/>
        /// |**English (Tanzania)**|`en-TZ`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United Kingdom)**|`en-UK`|<br/>
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
        /// |**Hebrew (Israel)**|`iw-IL`|<br/>
        /// |**Hindi (India)**|`hi-IN`|<br/>
        /// |**Hindi (Latin)**|`hi-Latn`|<br/>
        /// |**Hungarian (Hungary)**|`hu-HU`|<br/>
        /// |**Icelandic (Iceland)**|`is-IS`|<br/>
        /// |**Indonesian (Indonesia)**|`id-ID`|<br/>
        /// |**Irish (Ireland)**|`ga-IE`|<br/>
        /// |**Italian (Italy)**|`it-IT`|<br/>
        /// |**Italian (Switzerland)**|`it-CH`|<br/>
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
        /// |**Marathi (India)**|`mr-IN`|<br/>
        /// |**Mongolian (Mongolia)**|`mn-MN`|<br/>
        /// |**Nepali (Nepal)**|`ne-NP`|<br/>
        /// |**Norwegian (Norway)**|`no-NO`|<br/>
        /// |**Norwegian Bokmål (Norway)**|`nb-NO`|<br/>
        /// |**Pashto (Afghanistan)**|`ps-AF`|<br/>
        /// |**Persian (Iran)**|`fa-IR`|<br/>
        /// |**Polish (Poland)**|`pl-PL`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Punjabi (India)**|`pa-Guru-IN`|<br/>
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
        /// |**Spanish (Latin America)**|`es-419`|<br/>
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
        /// |**Uzbek (Uzbekistan)**|`uz-UZ`|<br/>
        /// |**Vietnamese (Vietnam)**|`vi-VN`|<br/>
        /// |**Welsh (United Kingdom)**|`cy-GB`|<br/>
        /// |**Wu Chinese (China)**|`wuu-CN`|<br/>
        /// |**Zulu (South Africa)**|`zu-ZA`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=audio-speech_to_text_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**deepgram**|`enhanced`|<br/>
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
        /// <param name="providerParams">
        /// Parameters specific to the provider that you want to send along the request.<br/>
        /// it should take a *provider* name as key and an object of parameters as value.<br/>
        /// Example:<br/>
        ///     {<br/>
        ///       "deepgram": {<br/>
        ///         "filler_words": true,<br/>
        ///         "smart_format": true,<br/>
        ///         "callback": "https://webhook.site/0000"<br/>
        ///       },<br/>
        ///       "assembly": {<br/>
        ///         "webhook_url": "https://webhook.site/0000"<br/>
        ///       }<br/>
        ///     }<br/>
        /// Please refer to the documentation of each provider to see which parameters to send.
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
        /// <param name="language">
        /// Language code expected (ex: en, fr)
        /// </param>
        /// <param name="speakers">
        /// Number of speakers in the file audio<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="profanityFilter">
        /// Boolean value to specify weather or not the service will filter profanity and replace inappropriate words with a series of asterisks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabulary">
        /// List of words or composed words to be detected by the speech to text engine. (Ex: Word, Mike, Draw, Los Angeles,...)
        /// </param>
        /// <param name="convertToWav">
        /// Boolean value to specify weather to convert the audio/video file to wav format to be accepted by a majority of the providers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> AudioAudioSpeechToTextAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            string? providerParams = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? language = default,
            int? speakers = default,
            bool? profanityFilter = default,
            string? customVocabulary = default,
            bool? convertToWav = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.SpeechToTextAsyncRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ShowOriginalResponse = showOriginalResponse,
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                ShowBase64 = showBase64,
                ProviderParams = providerParams,
                File = file,
                Filename = filename,
                FileUrl = fileUrl,
                Language = language,
                Speakers = speakers,
                ProfanityFilter = profanityFilter,
                CustomVocabulary = customVocabulary,
                ConvertToWav = convertToWav,
            };

            return await AudioAudioSpeechToTextAsyncCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}