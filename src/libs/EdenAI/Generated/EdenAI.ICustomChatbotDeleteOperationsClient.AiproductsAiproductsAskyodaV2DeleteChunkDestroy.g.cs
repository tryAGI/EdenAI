#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Delete Chunk<br/>
        /// Delete one or multiple chunks from your project. <br/>
        /// You can delete a single chunk by providing it ID either as a query parameter or in the request body. <br/>
        /// For bulk deletion, provide a list of chunk IDs in the request body.<br/>
        /// Examples:<br/>
        /// - Single chunk deletion (query parameter): DELETE /chunks?id=chunk123<br/>
        /// - Single chunk deletion (body): {"id": "chunk123"}<br/>
        /// - Bulk deletion: {"ids": ["chunk123", "chunk456", "chunk789"]}
        /// </summary>
        /// <param name="chunkIds"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaDeleteResponse> AiproductsAiproductsAskyodaV2DeleteChunkDestroyAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string>? chunkIds = default,
            string? id = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}