#nullable enable

namespace EdenAI
{
    public partial interface IAnonymizationClient
    {
        /// <summary>
        /// Anonymization<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|`v3.1`|0.25 (per 1000000 char)|1000 char<br/>
        /// |**privateai**|`v3`|5.0 (per 1000000 char)|100 char<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bambara**|`bm`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
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
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextanonymizationResponseModel> TextTextAnonymizationCreateAsync(

            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anonymization<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|`v3.1`|0.25 (per 1000000 char)|1000 char<br/>
        /// |**privateai**|`v3`|5.0 (per 1000000 char)|100 char<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bambara**|`bm`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
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
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TextanonymizationResponseModel>> TextTextAnonymizationCreateAsResponseAsync(

            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anonymization<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|`v3.1`|0.25 (per 1000000 char)|1000 char<br/>
        /// |**privateai**|`v3`|5.0 (per 1000000 char)|100 char<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bambara**|`bm`|<br/>
        /// |**Belarusian**|`be`|<br/>
        /// |**Bengali**|`bn`|<br/>
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
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**Georgian**|`ka`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hebrew**|`he`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Icelandic**|`is`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Khmer**|`km`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Lithuanian**|`lt`|<br/>
        /// |**Luxembourgish**|`lb`|<br/>
        /// |**Malay (macrolanguage)**|`ms`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Panjabi**|`pa`|<br/>
        /// |**Persian**|`fa`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swahili (macrolanguage)**|`sw`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Tagalog**|`tl`|<br/>
        /// |**Tamil**|`ta`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Ukrainian**|`uk`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextanonymizationResponseModel> TextTextAnonymizationCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? language = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}