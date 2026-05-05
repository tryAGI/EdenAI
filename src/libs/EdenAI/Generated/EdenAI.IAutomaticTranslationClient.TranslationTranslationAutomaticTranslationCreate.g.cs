#nullable enable

namespace EdenAI
{
    public partial interface IAutomaticTranslationClient
    {
        /// <summary>
        /// Automatic Translation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|15.0 (per 1000000 char)|1 char<br/>
        /// |**google**|-|`v3`|20.0 (per 1000000 char)|1 char<br/>
        /// |**microsoft**|-|`v3.0`|10.0 (per 1000000 char)|1 char<br/>
        /// |**deepl**|-|`v2`|20.0 (per 1000000 char)|1 char<br/>
        /// |**modernmt**|-|`1.2.8`|8.0 (per 1000000 char)|1 char<br/>
        /// |**openai**|-|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Amharic**|`am`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Armenian**|`hy`|<br/>
        /// |**Assamese**|`as`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bashkir**|`ba`|<br/>
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
        /// |**Dari**|`prs`|<br/>
        /// |**Dhivehi**|`dv`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Faroese**|`fo`|<br/>
        /// |**Fijian**|`fj`|<br/>
        /// |**Filipino**|`fil`|<br/>
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
        /// |**Hmong Daw**|`mww`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Igbo**|`ig`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Inuinnaqtun**|`ikt`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Kinyarwanda**|`rw`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Klingon**|`tlh`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Literary Chinese**|`lzh`|<br/>
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
        /// |**Northern Kurdish**|`kmr`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Norwegian Nynorsk**|`nn`|<br/>
        /// |**Nyanja**|`ny`|<br/>
        /// |**Oriya (macrolanguage)**|`or`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Querétaro Otomi**|`otq`|<br/>
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
        /// |**Tahitian**|`ty`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Tibetan**|`bo`|<br/>
        /// |**Tigrinya**|`ti`|<br/>
        /// |**Tonga (Tonga Islands)**|`to`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Upper Sorbian**|`hsb`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yucateco**|`yua`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**Inuktitut (Latin)**|`iu-Latn`|<br/>
        /// |**Klingon (Klingon (KLI pIqaD))**|`tlh-Piqd`|<br/>
        /// |**Klingon (Latin)**|`tlh-Latn`|<br/>
        /// |**Mongolian (Cyrillic)**|`mn-Cyrl`|<br/>
        /// |**Mongolian (Mongolian)**|`mn-Mong`|<br/>
        /// |**Persian (Afghanistan)**|`fa-AF`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Spanish (Latin America)**|`es-419`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=translation-automatic_translation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TranslationautomaticTranslationResponseModel> TranslationTranslationAutomaticTranslationCreateAsync(

            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Automatic Translation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|15.0 (per 1000000 char)|1 char<br/>
        /// |**google**|-|`v3`|20.0 (per 1000000 char)|1 char<br/>
        /// |**microsoft**|-|`v3.0`|10.0 (per 1000000 char)|1 char<br/>
        /// |**deepl**|-|`v2`|20.0 (per 1000000 char)|1 char<br/>
        /// |**modernmt**|-|`1.2.8`|8.0 (per 1000000 char)|1 char<br/>
        /// |**openai**|-|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Amharic**|`am`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Armenian**|`hy`|<br/>
        /// |**Assamese**|`as`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bashkir**|`ba`|<br/>
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
        /// |**Dari**|`prs`|<br/>
        /// |**Dhivehi**|`dv`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Faroese**|`fo`|<br/>
        /// |**Fijian**|`fj`|<br/>
        /// |**Filipino**|`fil`|<br/>
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
        /// |**Hmong Daw**|`mww`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Igbo**|`ig`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Inuinnaqtun**|`ikt`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Kinyarwanda**|`rw`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Klingon**|`tlh`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Literary Chinese**|`lzh`|<br/>
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
        /// |**Northern Kurdish**|`kmr`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Norwegian Nynorsk**|`nn`|<br/>
        /// |**Nyanja**|`ny`|<br/>
        /// |**Oriya (macrolanguage)**|`or`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Querétaro Otomi**|`otq`|<br/>
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
        /// |**Tahitian**|`ty`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Tibetan**|`bo`|<br/>
        /// |**Tigrinya**|`ti`|<br/>
        /// |**Tonga (Tonga Islands)**|`to`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Upper Sorbian**|`hsb`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yucateco**|`yua`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**Inuktitut (Latin)**|`iu-Latn`|<br/>
        /// |**Klingon (Klingon (KLI pIqaD))**|`tlh-Piqd`|<br/>
        /// |**Klingon (Latin)**|`tlh-Latn`|<br/>
        /// |**Mongolian (Cyrillic)**|`mn-Cyrl`|<br/>
        /// |**Mongolian (Mongolian)**|`mn-Mong`|<br/>
        /// |**Persian (Afghanistan)**|`fa-AF`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Spanish (Latin America)**|`es-419`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=translation-automatic_translation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TranslationautomaticTranslationResponseModel>> TranslationTranslationAutomaticTranslationCreateAsResponseAsync(

            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Automatic Translation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|15.0 (per 1000000 char)|1 char<br/>
        /// |**google**|-|`v3`|20.0 (per 1000000 char)|1 char<br/>
        /// |**microsoft**|-|`v3.0`|10.0 (per 1000000 char)|1 char<br/>
        /// |**deepl**|-|`v2`|20.0 (per 1000000 char)|1 char<br/>
        /// |**modernmt**|-|`1.2.8`|8.0 (per 1000000 char)|1 char<br/>
        /// |**openai**|-|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1`|20.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Albanian**|`sq`|<br/>
        /// |**Amharic**|`am`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Armenian**|`hy`|<br/>
        /// |**Assamese**|`as`|<br/>
        /// |**Azerbaijani**|`az`|<br/>
        /// |**Bashkir**|`ba`|<br/>
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
        /// |**Dari**|`prs`|<br/>
        /// |**Dhivehi**|`dv`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Esperanto**|`eo`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Faroese**|`fo`|<br/>
        /// |**Fijian**|`fj`|<br/>
        /// |**Filipino**|`fil`|<br/>
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
        /// |**Hmong Daw**|`mww`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Igbo**|`ig`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Inuinnaqtun**|`ikt`|<br/>
        /// |**Inuktitut**|`iu`|<br/>
        /// |**Irish**|`ga`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Javanese**|`jv`|<br/>
        /// |**Kannada**|`kn`|<br/>
        /// |**Kazakh**|`kk`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Kinyarwanda**|`rw`|<br/>
        /// |**Kirghiz**|`ky`|<br/>
        /// |**Klingon**|`tlh`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Kurdish**|`ku`|<br/>
        /// |**Lao**|`lo`|<br/>
        /// |**Latin**|`la`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Literary Chinese**|`lzh`|<br/>
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
        /// |**Northern Kurdish**|`kmr`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Norwegian Nynorsk**|`nn`|<br/>
        /// |**Nyanja**|`ny`|<br/>
        /// |**Oriya (macrolanguage)**|`or`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Pushto**|`ps`|<br/>
        /// |**Querétaro Otomi**|`otq`|<br/>
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
        /// |**Tahitian**|`ty`|<br/>
        /// |**Tajik**|`tg`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Tatar**|`tt`|<br/>
        /// |**Telugu**|`te`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Tibetan**|`bo`|<br/>
        /// |**Tigrinya**|`ti`|<br/>
        /// |**Tonga (Tonga Islands)**|`to`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Turkmen**|`tk`|<br/>
        /// |**Uighur**|`ug`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Upper Sorbian**|`hsb`|<br/>
        /// |**Urdu**|`ur`|<br/>
        /// |**Uzbek**|`uz`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// |**Welsh**|`cy`|<br/>
        /// |**Western Frisian**|`fy`|<br/>
        /// |**Xhosa**|`xh`|<br/>
        /// |**Yiddish**|`yi`|<br/>
        /// |**Yoruba**|`yo`|<br/>
        /// |**Yucateco**|`yua`|<br/>
        /// |**Yue Chinese**|`yue`|<br/>
        /// |**Zulu**|`zu`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (China)**|`zh-CN`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**English (United Kingdom)**|`en-GB`|<br/>
        /// |**English (United States)**|`en-US`|<br/>
        /// |**French (Canada)**|`fr-CA`|<br/>
        /// |**Inuktitut (Latin)**|`iu-Latn`|<br/>
        /// |**Klingon (Klingon (KLI pIqaD))**|`tlh-Piqd`|<br/>
        /// |**Klingon (Latin)**|`tlh-Latn`|<br/>
        /// |**Mongolian (Cyrillic)**|`mn-Cyrl`|<br/>
        /// |**Mongolian (Mongolian)**|`mn-Mong`|<br/>
        /// |**Persian (Afghanistan)**|`fa-AF`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// |**Serbian (Cyrillic)**|`sr-Cyrl`|<br/>
        /// |**Serbian (Latin)**|`sr-Latn`|<br/>
        /// |**Spanish (Latin America)**|`es-419`|<br/>
        /// |**Spanish (Mexico)**|`es-MX`|<br/>
        /// |**Spanish (Spain)**|`es-ES`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=translation-automatic_translation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
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
        /// <param name="text">
        /// Text to analyze
        /// </param>
        /// <param name="sourceLanguage">
        /// Source language code (ex: en, fr)
        /// </param>
        /// <param name="targetLanguage">
        /// Target language code (ex: en, fr)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TranslationautomaticTranslationResponseModel> TranslationTranslationAutomaticTranslationCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string targetLanguage,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? sourceLanguage = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}