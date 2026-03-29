#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUpdateOperationsClient
    {
        /// <summary>
        /// Update Conversation Name
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ConversationDetail> AiproductsAiproductsAskyodaV2ConversationsPartialUpdateAsync(
            global::System.Guid conversationId,
            global::System.Guid projectId,

            global::EdenAI.PatchedConversationDetailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Conversation Name
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ConversationDetail> AiproductsAiproductsAskyodaV2ConversationsPartialUpdateAsync(
            global::System.Guid conversationId,
            global::System.Guid projectId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}