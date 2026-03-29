
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolResultRequest
    {
        /// <summary>
        /// the id of the `tool_call` used to generate result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// the result of your function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolResultRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// the id of the `tool_call` used to generate result
        /// </param>
        /// <param name="result">
        /// the result of your function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatToolResultRequest(
            string id,
            string result)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolResultRequest" /> class.
        /// </summary>
        public ChatToolResultRequest()
        {
        }
    }
}