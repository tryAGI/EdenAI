
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationlanguageDetectionResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Xai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modernmt")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Modernmt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Oneai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Openai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="xai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modernmt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="oneai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationlanguageDetectionResponseModel(
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? xai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? amazon,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? modernmt,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? oneai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? openai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? microsoft,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? google)
        {
            this.Xai = xai;
            this.Amazon = amazon;
            this.Modernmt = modernmt;
            this.Oneai = oneai;
            this.Openai = openai;
            this.Microsoft = microsoft;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        public TranslationlanguageDetectionResponseModel()
        {
        }
    }
}