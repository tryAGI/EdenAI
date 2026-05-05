#nullable enable

namespace EdenAI
{
    public partial interface IOcrClient
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.OcrocrResponseModel> OcrOcrOcrCreateAsync(

            global::EdenAI.OcrocrOcrRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.OcrocrResponseModel>> OcrOcrOcrCreateAsResponseAsync(

            global::EdenAI.OcrocrOcrRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.OcrocrResponseModel> OcrOcrOcrCreateAsync(
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
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}