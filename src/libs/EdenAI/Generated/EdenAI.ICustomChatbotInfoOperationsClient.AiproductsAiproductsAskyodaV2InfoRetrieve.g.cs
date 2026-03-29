#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// Get info<br/>
        /// Retrieve details about your project within your Ask YODA project,<br/>
        /// including the total number of items stored in your project collection and default models
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.YodaInfoResponse> AiproductsAiproductsAskyodaV2InfoRetrieveAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}