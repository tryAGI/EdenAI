
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTextRequest
    {
        /// <summary>
        /// LLM Query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Texts { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<object>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTextRequest" /> class.
        /// </summary>
        /// <param name="texts">
        /// LLM Query
        /// </param>
        /// <param name="metadata">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTextRequest(
            global::System.Collections.Generic.IList<string> texts,
            global::System.Collections.Generic.IList<object>? metadata)
        {
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTextRequest" /> class.
        /// </summary>
        public AddTextRequest()
        {
        }
    }
}