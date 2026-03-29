#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotDeleteOperationsClient
    {
        /// <summary>
        /// Delete Conversation
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2ConversationsDestroyAsync(
            global::System.Guid conversationId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}