
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AskLLMRequest
    {
        /// <summary>
        /// Enter your question or query about the data. The large language model (LLM) will provide a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Select a provider for the large language model for processing. Leave empty for default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        public string? LlmProvider { get; set; }

        /// <summary>
        /// Specify the model to use for language processing. Leave empty for default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// How many results chunk you want to return<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public int? K { get; set; }

        /// <summary>
        /// A list containing all the previous conversations between the user and the chatbot AI. Each item in the list should be a dictionary with two keys: 'user' and 'assistant'.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<object>? History { get; set; }

        /// <summary>
        /// A system message that helps set the behavior of the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatbot_global_action")]
        public string? ChatbotGlobalAction { get; set; }

        /// <summary>
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_documents")]
        public object? FilterDocuments { get; set; }

        /// <summary>
        /// A minimum score threshold for the model to consider a chunk as a valid response. Higher values mean the model will be more conservative and only return chunks that are more similar to the query. Lower values mean the model will be more open to returning chunks that are less similar to the query.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_score")]
        public double? MinScore { get; set; }

        /// <summary>
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public global::System.Guid? ConversationId { get; set; }

        /// <summary>
        /// Activate/deactivate the reranking. This is experimental.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_reranking")]
        public bool? UseReranking { get; set; }

        /// <summary>
        /// The number of documents returned by the reranker (experimental)<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AskLLMRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Enter your question or query about the data. The large language model (LLM) will provide a response.
        /// </param>
        /// <param name="llmProvider">
        /// Select a provider for the large language model for processing. Leave empty for default.
        /// </param>
        /// <param name="llmModel">
        /// Specify the model to use for language processing. Leave empty for default.
        /// </param>
        /// <param name="k">
        /// How many results chunk you want to return<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="history">
        /// A list containing all the previous conversations between the user and the chatbot AI. Each item in the list should be a dictionary with two keys: 'user' and 'assistant'.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="chatbotGlobalAction">
        /// A system message that helps set the behavior of the assistant.
        /// </param>
        /// <param name="filterDocuments">
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="minScore">
        /// A minimum score threshold for the model to consider a chunk as a valid response. Higher values mean the model will be more conservative and only return chunks that are more similar to the query. Lower values mean the model will be more open to returning chunks that are less similar to the query.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="useReranking">
        /// Activate/deactivate the reranking. This is experimental.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topN">
        /// The number of documents returned by the reranker (experimental)<br/>
        /// Default Value: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AskLLMRequest(
            string query,
            string? llmProvider,
            string? llmModel,
            int? k,
            global::System.Collections.Generic.IList<object>? history,
            string? chatbotGlobalAction,
            object? filterDocuments,
            double? minScore,
            double? temperature,
            int? maxTokens,
            global::System.Guid? conversationId,
            bool? useReranking,
            int? topN)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.K = k;
            this.History = history;
            this.ChatbotGlobalAction = chatbotGlobalAction;
            this.FilterDocuments = filterDocuments;
            this.MinScore = minScore;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ConversationId = conversationId;
            this.UseReranking = useReranking;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AskLLMRequest" /> class.
        /// </summary>
        public AskLLMRequest()
        {
        }
    }
}