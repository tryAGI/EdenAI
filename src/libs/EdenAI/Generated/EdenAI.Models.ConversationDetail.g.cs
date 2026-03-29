
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationDetail
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::EdenAI.Message> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDetail" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="messages">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationDetail(
            string? name,
            global::System.Guid id = default!,
            global::System.Collections.Generic.IList<global::EdenAI.Message> messages = default!)
        {
            this.Id = id;
            this.Name = name;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDetail" /> class.
        /// </summary>
        public ConversationDetail()
        {
        }
    }
}