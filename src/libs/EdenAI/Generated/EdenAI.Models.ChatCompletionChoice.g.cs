
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoice
    {
        /// <summary>
        /// The index of this completion choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ChatMessage Message { get; set; }

        /// <summary>
        /// The reason the completion finished: 'stop', 'length', 'tool_calls', 'content_filter', or 'function_call'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of this completion choice
        /// </param>
        /// <param name="message"></param>
        /// <param name="finishReason">
        /// The reason the completion finished: 'stop', 'length', 'tool_calls', 'content_filter', or 'function_call'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChoice(
            int index,
            global::EdenAI.ChatMessage message,
            string finishReason)
        {
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        public ChatCompletionChoice()
        {
        }
    }
}