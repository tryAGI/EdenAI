#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// Get File
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AiProductFile> AiproductsAiproductsAskyodaV2FilesRetrieveAsync(
            global::System.Guid fileId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}