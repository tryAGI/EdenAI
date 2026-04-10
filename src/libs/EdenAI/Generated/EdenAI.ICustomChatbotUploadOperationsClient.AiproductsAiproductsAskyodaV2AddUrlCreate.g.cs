#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUploadOperationsClient
    {
        /// <summary>
        /// Add Urls<br/>
        /// Add a list of URLs into your projects,<br/>
        /// they will be processed and stored as text embeddings within your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddUrlCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddUrlRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Urls<br/>
        /// Add a list of URLs into your projects,<br/>
        /// they will be processed and stored as text embeddings within your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="urls">
        /// Add multiple urls into the database, it loads all the text from HTML webpages into a document format.
        /// </param>
        /// <param name="jsRender">
        /// Enable JavaScript rendering for the provided URLs.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddUrlCreateAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string> urls,
            global::System.Collections.Generic.IList<bool>? jsRender = default,
            global::System.Collections.Generic.IList<object>? metadata = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}