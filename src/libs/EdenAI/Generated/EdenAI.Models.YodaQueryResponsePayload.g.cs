
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class YodaQueryResponsePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaQueryResponsePayload" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="pageContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public YodaQueryResponsePayload(
            object metadata,
            string pageContent)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PageContent = pageContent ?? throw new global::System.ArgumentNullException(nameof(pageContent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaQueryResponsePayload" /> class.
        /// </summary>
        public YodaQueryResponsePayload()
        {
        }

    }
}