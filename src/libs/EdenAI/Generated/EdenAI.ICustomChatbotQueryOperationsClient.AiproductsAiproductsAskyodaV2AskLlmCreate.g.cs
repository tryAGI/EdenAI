#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotQueryOperationsClient
    {
        /// <summary>
        /// Ask LLM<br/>
        /// Retrieve a list of search query responses and compare them to your<br/>
        /// input. Provide a query, and in return, receive scores for the most relevant items from your project,<br/>
        /// ranked by their proximity to your query.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaQueryResponse> AiproductsAiproductsAskyodaV2AskLlmCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AskLLMRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask LLM<br/>
        /// Retrieve a list of search query responses and compare them to your<br/>
        /// input. Provide a query, and in return, receive scores for the most relevant items from your project,<br/>
        /// ranked by their proximity to your query.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaQueryResponse>> AiproductsAiproductsAskyodaV2AskLlmCreateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.AskLLMRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask LLM<br/>
        /// Retrieve a list of search query responses and compare them to your<br/>
        /// input. Provide a query, and in return, receive scores for the most relevant items from your project,<br/>
        /// ranked by their proximity to your query.
        /// </summary>
        /// <param name="projectId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaQueryResponse> AiproductsAiproductsAskyodaV2AskLlmCreateAsync(
            global::System.Guid projectId,
            string query,
            string? llmProvider = default,
            string? llmModel = default,
            int? k = default,
            global::System.Collections.Generic.IList<object>? history = default,
            string? chatbotGlobalAction = default,
            object? filterDocuments = default,
            double? minScore = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Guid? conversationId = default,
            bool? useReranking = default,
            int? topN = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}