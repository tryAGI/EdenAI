#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotInfoOperationsClient
    {
        /// <summary>
        /// Retrieve Conversation Details
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ConversationDetail> AiproductsAiproductsAskyodaV2ConversationsRetrieveAsync(
            global::System.Guid conversationId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}