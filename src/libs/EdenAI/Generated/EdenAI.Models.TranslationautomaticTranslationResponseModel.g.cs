
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationautomaticTranslationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepl")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Deepl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modernmt")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Modernmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Xai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationautomaticTranslationResponseModel" /> class.
        /// </summary>
        /// <param name="deepl"></param>
        /// <param name="modernmt"></param>
        /// <param name="openai"></param>
        /// <param name="amazon"></param>
        /// <param name="google"></param>
        /// <param name="microsoft"></param>
        /// <param name="xai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationautomaticTranslationResponseModel(
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? deepl,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? modernmt,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? openai,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? amazon,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? google,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? microsoft,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? xai)
        {
            this.Deepl = deepl;
            this.Modernmt = modernmt;
            this.Openai = openai;
            this.Amazon = amazon;
            this.Google = google;
            this.Microsoft = microsoft;
            this.Xai = xai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationautomaticTranslationResponseModel" /> class.
        /// </summary>
        public TranslationautomaticTranslationResponseModel()
        {
        }
    }
}