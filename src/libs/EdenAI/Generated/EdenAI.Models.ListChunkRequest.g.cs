
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListChunkRequest
    {
        /// <summary>
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_documents")]
        public object? FilterDocuments { get; set; }

        /// <summary>
        /// Specifies the maximum number of chunk IDs to return. Defaults to 10 if not provided.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// If set to True, includes the full payload of each chunk in the response. By default, only chunk IDs are returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public bool? WithPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChunkRequest" /> class.
        /// </summary>
        /// <param name="filterDocuments">
        /// Filter uploaded documents based on their metadata. Specify key-value pairs where the key represents the metadata field and the value is the desired metadata value. Please ensure that the provided metadata keys are available in your database.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="limit">
        /// Specifies the maximum number of chunk IDs to return. Defaults to 10 if not provided.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="withPayload">
        /// If set to True, includes the full payload of each chunk in the response. By default, only chunk IDs are returned.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListChunkRequest(
            object? filterDocuments,
            int? limit,
            bool? withPayload)
        {
            this.FilterDocuments = filterDocuments;
            this.Limit = limit;
            this.WithPayload = withPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChunkRequest" /> class.
        /// </summary>
        public ListChunkRequest()
        {
        }
    }
}