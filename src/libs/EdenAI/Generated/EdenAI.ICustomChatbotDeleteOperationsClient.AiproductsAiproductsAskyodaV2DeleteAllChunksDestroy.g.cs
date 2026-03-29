#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Delete All Chunks<br/>
        /// Delete all chunks from your project.<br/>
        /// This action is irreversible and will remove all data stored in your project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaDeleteResponse> AiproductsAiproductsAskyodaV2DeleteAllChunksDestroyAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}