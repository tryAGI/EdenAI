#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2FilesDestroyAsync(
            global::System.Guid fileId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}