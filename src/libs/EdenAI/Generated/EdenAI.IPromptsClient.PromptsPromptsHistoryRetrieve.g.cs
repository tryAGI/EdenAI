#nullable enable

namespace EdenAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get Prompt History
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PromptHistory> PromptsPromptsHistoryRetrieveAsync(
            int id,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}