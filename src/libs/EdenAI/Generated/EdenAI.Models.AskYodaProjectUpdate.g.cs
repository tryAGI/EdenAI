
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AskYodaProjectUpdate
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AskYodaProjectUpdate" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AskYodaProjectUpdate(
            string? ocrProvider,
            string? speechToTextProvider,
            string? llmProvider,
            string? llmModel,
            int? chunkSize,
            global::System.Collections.Generic.IList<string>? chunkSeparators)
        {
            this.OcrProvider = ocrProvider;
            this.SpeechToTextProvider = speechToTextProvider;
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.ChunkSize = chunkSize;
            this.ChunkSeparators = chunkSeparators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AskYodaProjectUpdate" /> class.
        /// </summary>
        public AskYodaProjectUpdate()
        {
        }
    }
}