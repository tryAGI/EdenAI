
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextembeddingsResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iointelligence")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Iointelligence { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jina")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Jina { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai21labs")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Ai21labs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Mistral { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Google { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Cohere { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Openai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextembeddingsResponseModel" /> class.
        /// </summary>
        /// <param name="iointelligence">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="jina">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ai21labs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mistral">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cohere">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextembeddingsResponseModel(
            global::EdenAI.TextembeddingsEmbeddingsDataClass? iointelligence,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? jina,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? ai21labs,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? mistral,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? google,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? cohere,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? openai)
        {
            this.Iointelligence = iointelligence;
            this.Jina = jina;
            this.Ai21labs = ai21labs;
            this.Mistral = mistral;
            this.Google = google;
            this.Cohere = cohere;
            this.Openai = openai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextembeddingsResponseModel" /> class.
        /// </summary>
        public TextembeddingsResponseModel()
        {
        }
    }
}