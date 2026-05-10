
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlagiaDetectionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionCandidate>? Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlagiaDetectionItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="candidates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlagiaDetectionItem(
            string text,
            global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionCandidate>? candidates)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Candidates = candidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlagiaDetectionItem" /> class.
        /// </summary>
        public PlagiaDetectionItem()
        {
        }

    }
}