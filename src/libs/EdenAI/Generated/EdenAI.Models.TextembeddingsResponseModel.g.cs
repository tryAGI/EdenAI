
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextembeddingsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai21labs")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Ai21labs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iointelligence")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Iointelligence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jina")]
        public global::EdenAI.TextembeddingsEmbeddingsDataClass? Jina { get; set; }

        /// <summary>
        /// 
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
        /// <param name="ai21labs"></param>
        /// <param name="google"></param>
        /// <param name="cohere"></param>
        /// <param name="iointelligence"></param>
        /// <param name="mistral"></param>
        /// <param name="jina"></param>
        /// <param name="openai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextembeddingsResponseModel(
            global::EdenAI.TextembeddingsEmbeddingsDataClass? ai21labs,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? google,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? cohere,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? iointelligence,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? mistral,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? jina,
            global::EdenAI.TextembeddingsEmbeddingsDataClass? openai)
        {
            this.Ai21labs = ai21labs;
            this.Google = google;
            this.Cohere = cohere;
            this.Iointelligence = iointelligence;
            this.Mistral = mistral;
            this.Jina = jina;
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