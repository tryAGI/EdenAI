
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomDocumentParsingAsyncItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.CustomDocumentParsingAsyncBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDocumentParsingAsyncItem" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="value"></param>
        /// <param name="query"></param>
        /// <param name="boundingBox"></param>
        /// <param name="page"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDocumentParsingAsyncItem(
            int confidence,
            string value,
            string query,
            global::EdenAI.CustomDocumentParsingAsyncBoundingBox boundingBox,
            int page)
        {
            this.Confidence = confidence;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDocumentParsingAsyncItem" /> class.
        /// </summary>
        public CustomDocumentParsingAsyncItem()
        {
        }

    }
}