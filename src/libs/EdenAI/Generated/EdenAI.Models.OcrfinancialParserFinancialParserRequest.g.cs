
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrfinancialParserFinancialParserRequest
    {
        /// <summary>
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Providers { get; set; }

        /// <summary>
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_providers")]
        public global::System.Collections.Generic.IList<string>? FallbackProviders { get; set; }

        /// <summary>
        /// Optional : When set to **true** (default), the response is an object of responses with providers names as keys :  <br/>
        ///                   ``` {"google" : { "status": "success", ... }, } ``` <br/>
        ///                 When set to **false** the response structure is a list of response objects :  <br/>
        ///                    ``` [{"status": "success", "provider": "google" ... }, ] ```. <br/>
        ///                   <br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_as_dict")]
        public bool? ResponseAsDict { get; set; }

        /// <summary>
        /// Optional : When set to **false** (default) the structure of the extracted items is list of objects having different attributes : <br/>
        ///      ```{'items': [{"attribute_1": "x1","attribute_2": "y2"}, ... ]}``` <br/>
        ///      When it is set to **true**, the response contains an object with each attribute as a list : <br/>
        ///      ```{ "attribute_1": ["x1","x2", ...], "attribute_2": [y1, y2, ...]}``` <br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes_as_list")]
        public bool? AttributesAsList { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_base_64")]
        public bool? ShowBase64 { get; set; }

        /// <summary>
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_original_response")]
        public bool? ShowOriginalResponse { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// If your PDF file has a password, you can pass it here!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_password")]
        public string? FilePassword { get; set; }

        /// <summary>
        /// Language code of the language the document is written in (ex: fr (French), en (English), es (Spanish))
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Specify the type of your document. Can be Set to 'auto-detect' for automatic detection if the provider supports it. Otherwise, the default is 'invoice'.<br/>
        /// * `auto-detect` - auto-detect<br/>
        /// * `invoice` - invoice<br/>
        /// * `receipt` - receipt<br/>
        /// Default Value: invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.DocumentTypeEnumJsonConverter))]
        public global::EdenAI.DocumentTypeEnum? DocumentType { get; set; }

        /// <summary>
        /// Boolean value to specify weather to convert the doc/docx files to pdf format to be accepted by a majority of the providers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_to_pdf")]
        public bool? ConvertToPdf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrfinancialParserFinancialParserRequest" /> class.
        /// </summary>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrfinancialParserFinancialParserRequest(
            global::System.Collections.Generic.IList<string> providers,
            string? settings,
            global::System.Collections.Generic.IList<string>? fallbackProviders,
            bool? responseAsDict,
            bool? attributesAsList,
            bool? showBase64,
            bool? showOriginalResponse,
            byte[]? file,
            string? filename,
            string? fileUrl,
            string? filePassword,
            string? language,
            global::EdenAI.DocumentTypeEnum? documentType,
            bool? convertToPdf)
        {
            this.Settings = settings;
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.FallbackProviders = fallbackProviders;
            this.ResponseAsDict = responseAsDict;
            this.AttributesAsList = attributesAsList;
            this.ShowBase64 = showBase64;
            this.ShowOriginalResponse = showOriginalResponse;
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
            this.FilePassword = filePassword;
            this.Language = language;
            this.DocumentType = documentType;
            this.ConvertToPdf = convertToPdf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrfinancialParserFinancialParserRequest" /> class.
        /// </summary>
        public OcrfinancialParserFinancialParserRequest()
        {
        }
    }
}