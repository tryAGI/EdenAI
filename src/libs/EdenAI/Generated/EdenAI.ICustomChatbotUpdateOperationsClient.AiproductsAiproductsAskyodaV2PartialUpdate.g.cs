#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUpdateOperationsClient
    {
        /// <summary>
        /// Update Bot Prompt<br/>
        /// Update the bot prompt for your RAG project using an existing prompt.<br/>
        /// This endpoint allows you to change the current bot prompt to a different existing prompt.
        /// </summary>
        /// <param name="fileUrls"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="params"></param>
        /// <param name="projectId"></param>
        /// <param name="promptName"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2PartialUpdateAsync(
            string model,
            string name,
            global::System.Guid projectId,
            string promptName,
            string text,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            object? @params = default,
            string? systemPrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}