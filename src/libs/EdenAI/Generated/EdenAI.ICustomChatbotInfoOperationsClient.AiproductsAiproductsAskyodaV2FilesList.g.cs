#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.AiProductFile>> AiproductsAiproductsAskyodaV2FilesListAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}