#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Remove Bot Prompt<br/>
        /// Remove the bot prompt from your RAG project.<br/>
        ///  This endpoint removes the custom bot prompt from your project, effectively resetting the bot's personality to system defaults. This action cannot be undone, but you can always set a new bot prompt later.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2RemoveBotPromptDestroyAsync(
            global::System.Guid projectId,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}