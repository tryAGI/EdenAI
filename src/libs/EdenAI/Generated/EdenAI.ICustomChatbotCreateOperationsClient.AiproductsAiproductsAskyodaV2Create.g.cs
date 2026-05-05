#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotCreateOperationsClient
    {
        /// <summary>
        /// Create Project<br/>
        /// Allows you to create a new Ask YODA project with specified details.<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Embedding Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`text-embedding-3-large`|<br/>
        /// |**cohere**|`embed-multilingual-v3.0`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**mistral**|`mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaCreateProjectResponse> AiproductsAiproductsAskyodaV2CreateAsync(

            global::EdenAI.AskYourDataProjectRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Allows you to create a new Ask YODA project with specified details.<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Embedding Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`text-embedding-3-large`|<br/>
        /// |**cohere**|`embed-multilingual-v3.0`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**mistral**|`mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaCreateProjectResponse>> AiproductsAiproductsAskyodaV2CreateAsResponseAsync(

            global::EdenAI.AskYourDataProjectRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Allows you to create a new Ask YODA project with specified details.<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Embedding Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`text-embedding-3-large`|<br/>
        /// |**cohere**|`embed-multilingual-v3.0`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**mistral**|`mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
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
        /// <param name="projectName">
        /// Project name
        /// </param>
        /// <param name="collectionName">
        /// Database Collection Name
        /// </param>
        /// <param name="dbProvider">
        /// Database Provider<br/>
        /// * `qdrant` - qdrant<br/>
        /// * `supabase` - supabase<br/>
        /// Default Value: qdrant
        /// </param>
        /// <param name="embeddingsProvider">
        /// Select an embedding provider to use in your search database. Leave empty for default.<br/>
        /// * `openai` - openai<br/>
        /// * `cohere` - cohere<br/>
        /// * `google` - google<br/>
        /// * `mistral` - mistral<br/>
        /// * `jina` - jina
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaCreateProjectResponse> AiproductsAiproductsAskyodaV2CreateAsync(
            string projectName,
            string collectionName,
            global::EdenAI.EmbeddingsProviderEnum embeddingsProvider,
            string? credential = default,
            string? asset = default,
            string? ocrProvider = default,
            string? speechToTextProvider = default,
            string? llmProvider = default,
            string? llmModel = default,
            int? chunkSize = default,
            global::System.Collections.Generic.IList<string>? chunkSeparators = default,
            global::EdenAI.DbProviderEnum? dbProvider = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}