#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUploadOperationsClient
    {
        /// <summary>
        /// Add Texts<br/>
        /// Add text data in your project, which will be stored as embeddings<br/>
        /// within your chosen database provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddTextCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddTextRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Texts<br/>
        /// Add text data in your project, which will be stored as embeddings<br/>
        /// within your chosen database provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="texts">
        /// LLM Query
        /// </param>
        /// <param name="metadata">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddTextCreateAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string> texts,
            global::System.Collections.Generic.IList<object>? metadata = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}