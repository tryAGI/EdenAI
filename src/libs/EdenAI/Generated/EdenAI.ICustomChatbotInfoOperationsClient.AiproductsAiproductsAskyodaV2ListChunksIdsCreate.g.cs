#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// List Check IDs<br/>
        /// Retrieve a list of all chunk IDs stored in your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaListChunksIdsResponse> AiproductsAiproductsAskyodaV2ListChunksIdsCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.ListChunkRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Check IDs<br/>
        /// Retrieve a list of all chunk IDs stored in your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.YodaListChunksIdsResponse>> AiproductsAiproductsAskyodaV2ListChunksIdsCreateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.ListChunkRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Check IDs<br/>
        /// Retrieve a list of all chunk IDs stored in your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filterDocuments">
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="limit">
        /// Specifies the maximum number of chunk IDs to return. Defaults to 10 if not provided.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="withPayload">
        /// If set to True, includes the full payload of each chunk in the response. By default, only chunk IDs are returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaListChunksIdsResponse> AiproductsAiproductsAskyodaV2ListChunksIdsCreateAsync(
            global::System.Guid projectId,
            object? filterDocuments = default,
            int? limit = default,
            bool? withPayload = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}