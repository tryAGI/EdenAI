
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
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modernmt")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Modernmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepl")]
        public global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? Deepl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationautomaticTranslationResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="xai"></param>
        /// <param name="modernmt"></param>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="openai"></param>
        /// <param name="deepl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationautomaticTranslationResponseModel(
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? microsoft,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? xai,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? modernmt,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? google,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? amazon,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? openai,
            global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass? deepl)
        {
            this.Microsoft = microsoft;
            this.Xai = xai;
            this.Modernmt = modernmt;
            this.Google = google;
            this.Amazon = amazon;
            this.Openai = openai;
            this.Deepl = deepl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationautomaticTranslationResponseModel" /> class.
        /// </summary>
        public TranslationautomaticTranslationResponseModel()
        {
        }
    }
}