
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_text")]
        public string? AssistantText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest" /> class.
        /// </summary>
        /// <param name="userText"></param>
        /// <param name="assistantText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageRequest(
            string userText,
            string? assistantText)
        {
            this.UserText = userText ?? throw new global::System.ArgumentNullException(nameof(userText));
            this.AssistantText = assistantText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest" /> class.
        /// </summary>
        public MessageRequest()
        {
        }
    }
}