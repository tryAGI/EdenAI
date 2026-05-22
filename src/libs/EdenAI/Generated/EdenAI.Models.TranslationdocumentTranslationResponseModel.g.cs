
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationdocumentTranslationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepl")]
        public global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? Deepl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationdocumentTranslationResponseModel" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="deepl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationdocumentTranslationResponseModel(
            global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? google,
            global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? deepl)
        {
            this.Google = google;
            this.Deepl = deepl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationdocumentTranslationResponseModel" /> class.
        /// </summary>
        public TranslationdocumentTranslationResponseModel()
        {
        }

    }
}