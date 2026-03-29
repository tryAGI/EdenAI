
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// A dictionary representing a single conversation in the previous history. Must contain 'user' and 'assistant' fields.
    /// </summary>
    public sealed partial class AskLLMRequestHistoryItem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}