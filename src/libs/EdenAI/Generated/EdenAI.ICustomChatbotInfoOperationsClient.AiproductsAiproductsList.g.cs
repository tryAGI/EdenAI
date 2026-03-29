#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// List Projects
        /// </summary>
        /// <param name="projectType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.AIProject>> AiproductsAiproductsListAsync(
            string? projectType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}