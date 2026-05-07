
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
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modernmt")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Modernmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="oneai"></param>
        /// <param name="modernmt"></param>
        /// <param name="amazon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationlanguageDetectionResponseModel(
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? microsoft,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? google,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? xai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? openai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? oneai,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? modernmt,
            global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass? amazon)
        {
            this.Microsoft = microsoft;
            this.Google = google;
            this.Xai = xai;
            this.Openai = openai;
            this.Oneai = oneai;
            this.Modernmt = modernmt;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationlanguageDetectionResponseModel" /> class.
        /// </summary>
        public TranslationlanguageDetectionResponseModel()
        {
        }
    }
}