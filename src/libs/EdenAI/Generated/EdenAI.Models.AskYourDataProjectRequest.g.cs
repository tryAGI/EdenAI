
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AskYourDataProjectRequest
    {
        /// <summary>
        /// The credential resource name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// The asset sub_resource name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        public string? Asset { get; set; }

        /// <summary>
        /// Default Value: amazon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_provider")]
        public string? OcrProvider { get; set; }

        /// <summary>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_provider")]
        public string? SpeechToTextProvider { get; set; }

        /// <summary>
        /// Select a default LLM provider to use in your project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        public string? LlmProvider { get; set; }

        /// <summary>
        /// Select a default Model for LLM provider to use in your project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_separators")]
        public global::System.Collections.Generic.IList<string>? ChunkSeparators { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Database Collection Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Database Provider<br/>
        /// * `qdrant` - qdrant<br/>
        /// * `supabase` - supabase<br/>
        /// Default Value: qdrant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.DbProviderEnumJsonConverter))]
        public global::EdenAI.DbProviderEnum? DbProvider { get; set; }

        /// <summary>
        /// Select an embedding provider to use in your search database. Leave empty for default.<br/>
        /// * `openai` - openai<br/>
        /// * `cohere` - cohere<br/>
        /// * `google` - google<br/>
        /// * `mistral` - mistral<br/>
        /// * `jina` - jina
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.EmbeddingsProviderEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.EmbeddingsProviderEnum EmbeddingsProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AskYourDataProjectRequest" /> class.
        /// </summary>
        /// <param name="projectName">
        /// Project name
        /// </param>
        /// <param name="collectionName">
        /// Database Collection Name
        /// </param>
        /// <param name="embeddingsProvider">
        /// Select an embedding provider to use in your search database. Leave empty for default.<br/>
        /// * `openai` - openai<br/>
        /// * `cohere` - cohere<br/>
        /// * `google` - google<br/>
        /// * `mistral` - mistral<br/>
        /// * `jina` - jina
        /// </param>
        /// <param name="credential">
        /// The credential resource name
        /// </param>
        /// <param name="asset">
        /// The asset sub_resource name
        /// </param>
        /// <param name="ocrProvider">
        /// Default Value: amazon
        /// </param>
        /// <param name="speechToTextProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="llmProvider">
        /// Select a default LLM provider to use in your project.
        /// </param>
        /// <param name="llmModel">
        /// Select a default Model for LLM provider to use in your project
        /// </param>
        /// <param name="chunkSize"></param>
        /// <param name="chunkSeparators"></param>
        /// <param name="dbProvider">
        /// Database Provider<br/>
        /// * `qdrant` - qdrant<br/>
        /// * `supabase` - supabase<br/>
        /// Default Value: qdrant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AskYourDataProjectRequest(
            string projectName,
            string collectionName,
            global::EdenAI.EmbeddingsProviderEnum embeddingsProvider,
            string? credential,
            string? asset,
            string? ocrProvider,
            string? speechToTextProvider,
            string? llmProvider,
            string? llmModel,
            int? chunkSize,
            global::System.Collections.Generic.IList<string>? chunkSeparators,
            global::EdenAI.DbProviderEnum? dbProvider)
        {
            this.Credential = credential;
            this.Asset = asset;
            this.OcrProvider = ocrProvider;
            this.SpeechToTextProvider = speechToTextProvider;
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.ChunkSize = chunkSize;
            this.ChunkSeparators = chunkSeparators;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.DbProvider = dbProvider;
            this.EmbeddingsProvider = embeddingsProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AskYourDataProjectRequest" /> class.
        /// </summary>
        public AskYourDataProjectRequest()
        {
        }

    }
}