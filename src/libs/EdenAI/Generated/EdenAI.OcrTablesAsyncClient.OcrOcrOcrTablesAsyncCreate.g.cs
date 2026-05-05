
#nullable enable

namespace EdenAI
{
    public partial class OcrTablesAsyncClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_OcrOcrOcrTablesAsyncCreateSecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_OcrOcrOcrTablesAsyncCreateSecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_OcrOcrOcrTablesAsyncCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_OcrOcrOcrTablesAsyncCreateSecurityRequirement0,
                s_OcrOcrOcrTablesAsyncCreateSecurityRequirement1,
            };
        partial void PrepareOcrOcrOcrTablesAsyncCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.OcrTablesAsyncRequest request);
        partial void PrepareOcrOcrOcrTablesAsyncCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.OcrTablesAsyncRequest request);
        partial void ProcessOcrOcrOcrTablesAsyncCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOcrOcrOcrTablesAsyncCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// OCR Tables Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|15.0 (per 1000 page)|1 page<br/>
        /// |**google**|`DocumentAI v1 beta3`|65.0 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`rest API 4.0 (2024-02-29-preview)`|10.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
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
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
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
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
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
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Ossetian**|`os`|<br/>
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
        /// |**Belarusian**|`be-Cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-Latn`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-Cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-Latn`|<br/>
        /// |**Kurdish (Arabic)**|`ku-Arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-Latn`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Uzbek (Arabic)**|`uz-Arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> OcrOcrOcrTablesAsyncCreateAsync(

            global::EdenAI.OcrTablesAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await OcrOcrOcrTablesAsyncCreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// OCR Tables Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|15.0 (per 1000 page)|1 page<br/>
        /// |**google**|`DocumentAI v1 beta3`|65.0 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`rest API 4.0 (2024-02-29-preview)`|10.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
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
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
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
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
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
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Ossetian**|`os`|<br/>
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
        /// |**Belarusian**|`be-Cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-Latn`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-Cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-Latn`|<br/>
        /// |**Kurdish (Arabic)**|`ku-Arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-Latn`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Uzbek (Arabic)**|`uz-Arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> OcrOcrOcrTablesAsyncCreateAsResponseAsync(

            global::EdenAI.OcrTablesAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOcrOcrOcrTablesAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OcrOcrOcrTablesAsyncCreateSecurityRequirements,
                operationName: "OcrOcrOcrTablesAsyncCreateAsync");

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
                                path: "/ocr/ocr_tables_async/",
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
                            if (request.FilePassword != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.FilePassword ?? string.Empty),
                                    name: "\"file_password\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOcrOcrOcrTablesAsyncCreateRequest(
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                ProcessOcrOcrOcrTablesAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                ProcessOcrOcrOcrTablesAsyncCreateResponseContent(
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
        /// OCR Tables Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|15.0 (per 1000 page)|1 page<br/>
        /// |**google**|`DocumentAI v1 beta3`|65.0 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`rest API 4.0 (2024-02-29-preview)`|10.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
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
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
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
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
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
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Ossetian**|`os`|<br/>
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
        /// |**Belarusian**|`be-Cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-Latn`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-Cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-Latn`|<br/>
        /// |**Kurdish (Arabic)**|`ku-Arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-Latn`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Uzbek (Arabic)**|`uz-Arab`|<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> OcrOcrOcrTablesAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? filePassword = default,
            string? language = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.OcrTablesAsyncRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ShowOriginalResponse = showOriginalResponse,
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                ShowBase64 = showBase64,
                File = file,
                Filename = filename,
                FileUrl = fileUrl,
                FilePassword = filePassword,
                Language = language,
            };

            return await OcrOcrOcrTablesAsyncCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// OCR Tables Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|15.0 (per 1000 page)|1 page<br/>
        /// |**google**|`DocumentAI v1 beta3`|65.0 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`rest API 4.0 (2024-02-29-preview)`|10.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
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
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
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
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
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
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Ossetian**|`os`|<br/>
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
        /// |**Belarusian**|`be-Cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-Latn`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-Cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-Latn`|<br/>
        /// |**Kurdish (Arabic)**|`ku-Arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-Latn`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Uzbek (Arabic)**|`uz-Arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        /// To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        /// Default Value: []
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        /// When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> OcrOcrOcrTablesAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? filePassword = default,
            string? language = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var request = new global::EdenAI.OcrTablesAsyncRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ShowOriginalResponse = showOriginalResponse,
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                ShowBase64 = showBase64,
                File = global::System.Array.Empty<byte>(),
                Filename = filename,
                FileUrl = fileUrl,
                FilePassword = filePassword,
                Language = language,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareOcrOcrOcrTablesAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OcrOcrOcrTablesAsyncCreateSecurityRequirements,
                operationName: "OcrOcrOcrTablesAsyncCreateAsync");

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
                                path: "/ocr/ocr_tables_async/",
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
                            if (file != default)
                            {

                                var __contentFile = new global::System.Net.Http.StreamContent(file);
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
                            if (request.FilePassword != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.FilePassword ?? string.Empty),
                                    name: "\"file_password\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOcrOcrOcrTablesAsyncCreateRequest(
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                ProcessOcrOcrOcrTablesAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                ProcessOcrOcrOcrTablesAsyncCreateResponseContent(
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
        /// OCR Tables Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|15.0 (per 1000 page)|1 page<br/>
        /// |**google**|`DocumentAI v1 beta3`|65.0 (per 1000 page)|1 page<br/>
        /// |**microsoft**|`rest API 4.0 (2024-02-29-preview)`|10.0 (per 1000 page)|1 page<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Angika**|`anp`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Asturian**|`ast`|<br/>
        /// |**Awadhi**|`awa`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bagheli**|`bfy`|<br/>
        /// |**Basque**|`eu`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bhojpuri**|`bho`|<br/>
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
        /// |**Chhattisgarhi**|`hne`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Cornish**|`kw`|<br/>
        /// |**Corsican**|`co`|<br/>
        /// |**Crimean Tatar**|`crh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Czech**|`cs`|<br/>
        /// |**Danish**|`da`|<br/>
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
        /// |**Interlingua (International Auxiliary Language Association)**|`ia`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Jaunsari**|`jns`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**K'iche'**|`quc`|<br/>
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
        /// |**Lakota**|`lkt`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Lower Sorbian**|`dsb`|<br/>
        /// |**Lule Sami**|`smj`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Mahasu Pahari**|`bfz`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Maltese**|`mt`|<br/>
        /// |**Manx**|`gv`|<br/>
        /// |**Maori**|`mi`|<br/>
        /// |**Marathi**|`mr`|<br/>
        /// |**Mongolian**|`mn`|<br/>
        /// |**Montenegrin**|`cnr`|<br/>
        /// |**Neapolitan**|`nap`|<br/>
        /// |**Nepali (macrolanguage)**|`ne`|<br/>
        /// |**Niuean**|`niu`|<br/>
        /// |**Nogai**|`nog`|<br/>
        /// |**Northern Sami**|`se`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Occitan (post 1500)**|`oc`|<br/>
        /// |**Ossetian**|`os`|<br/>
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
        /// |**Belarusian**|`be-Cyrl`|<br/>
        /// |**Belarusian (Latin)**|`be-Latn`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Kara-Kalpak (Cyrillic)**|`kaa-Cyrl`|<br/>
        /// |**Kazakh**|`kk-Cyrl`|<br/>
        /// |**Kazakh (Latin)**|`kk-Latn`|<br/>
        /// |**Kurdish (Arabic)**|`ku-Arab`|<br/>
        /// |**Kurdish (Latin)**|`ku-Latn`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Cyrillic, Montenegro)**|`sr-Cyrl-ME`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Serbian (Latin, Montenegro)**|`sr-Latn-ME`|<br/>
        /// |**Uzbek (Arabic)**|`uz-Arab`|<br/>
        /// |**Uzbek (Cyrillic)**|`uz-cyrl`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        /// To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        /// Default Value: []
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        /// When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> OcrOcrOcrTablesAsyncCreateAsResponseAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? filePassword = default,
            string? language = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var request = new global::EdenAI.OcrTablesAsyncRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ShowOriginalResponse = showOriginalResponse,
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                ShowBase64 = showBase64,
                File = global::System.Array.Empty<byte>(),
                Filename = filename,
                FileUrl = fileUrl,
                FilePassword = filePassword,
                Language = language,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareOcrOcrOcrTablesAsyncCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OcrOcrOcrTablesAsyncCreateSecurityRequirements,
                operationName: "OcrOcrOcrTablesAsyncCreateAsync");

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
                                path: "/ocr/ocr_tables_async/",
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
                            if (file != default)
                            {

                                var __contentFile = new global::System.Net.Http.StreamContent(file);
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
                            if (request.FilePassword != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.FilePassword ?? string.Empty),
                                    name: "\"file_password\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOcrOcrOcrTablesAsyncCreateRequest(
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                ProcessOcrOcrOcrTablesAsyncCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                operationId: "OcrOcrOcrTablesAsyncCreate",
                                methodName: "OcrOcrOcrTablesAsyncCreateAsync",
                                pathTemplate: "\"/ocr/ocr_tables_async/\"",
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
                                ProcessOcrOcrOcrTablesAsyncCreateResponseContent(
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
    }
}