
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationdocumentTranslationResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepl")]
        public global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? Deepl { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationdocumentTranslationResponseModel" /> class.
        /// </summary>
        /// <param name="deepl">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationdocumentTranslationResponseModel(
            global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? deepl,
            global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass? google)
        {
            this.Deepl = deepl;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationdocumentTranslationResponseModel" /> class.
        /// </summary>
        public TranslationdocumentTranslationResponseModel()
        {
        }
    }
}