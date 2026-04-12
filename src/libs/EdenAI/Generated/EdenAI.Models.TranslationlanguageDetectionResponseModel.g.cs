
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationlanguageDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modernmt")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Modernmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="oneai"></param>
        /// <param name="openai"></param>
        /// <param name="google"></param>
        /// <param name="modernmt"></param>
        /// <param name="xai"></param>
        /// <param name="microsoft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationlanguageDetectionResponseModel(
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? amazon,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? oneai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? openai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? google,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? modernmt,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? xai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? microsoft)
        {
            this.Amazon = amazon;
            this.Oneai = oneai;
            this.Openai = openai;
            this.Google = google;
            this.Modernmt = modernmt;
            this.Xai = xai;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        public TranslationlanguageDetectionResponseModel()
        {
        }
    }
}