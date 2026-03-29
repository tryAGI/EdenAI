#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// View to delete an AI project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsDeleteDestroyAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}