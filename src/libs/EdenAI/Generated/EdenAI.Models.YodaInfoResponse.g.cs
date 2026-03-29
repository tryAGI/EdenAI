
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class YodaInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingsProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CollectionSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaInfoResponse" /> class.
        /// </summary>
        /// <param name="dbProvider"></param>
        /// <param name="embeddingsProvider"></param>
        /// <param name="llmProvider"></param>
        /// <param name="llmModel"></param>
        /// <param name="collectionSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public YodaInfoResponse(
            string dbProvider,
            string embeddingsProvider,
            string llmProvider,
            string llmModel,
            int collectionSize)
        {
            this.DbProvider = dbProvider ?? throw new global::System.ArgumentNullException(nameof(dbProvider));
            this.EmbeddingsProvider = embeddingsProvider ?? throw new global::System.ArgumentNullException(nameof(embeddingsProvider));
            this.LlmProvider = llmProvider ?? throw new global::System.ArgumentNullException(nameof(llmProvider));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
            this.CollectionSize = collectionSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaInfoResponse" /> class.
        /// </summary>
        public YodaInfoResponse()
        {
        }
    }
}