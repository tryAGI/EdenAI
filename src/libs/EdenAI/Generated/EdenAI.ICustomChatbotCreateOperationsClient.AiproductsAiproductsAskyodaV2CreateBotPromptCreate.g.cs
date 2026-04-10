#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotCreateOperationsClient
    {
        /// <summary>
        /// Create Bot Profile<br/>
        /// Create a default bot prompt for your RAG project.<br/>
        /// The bot prompt serves as the default system message or personality definition for your RAG-powered chatbot. This prompt helps define how your bot should interact with users and what context it should consider when processing queries.
        /// </summary>
        /// <param name="fileUrls"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="params"></param>
        /// <param name="projectId"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2CreateBotPromptCreateAsync(
            string model,
            string name,
            global::System.Guid projectId,
            string text,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            object? @params = default,
            string? systemPrompt = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}