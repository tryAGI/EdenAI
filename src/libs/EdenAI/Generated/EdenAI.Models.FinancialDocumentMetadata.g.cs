
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialDocumentMetadata
    {
        /// <summary>
        /// Index of the detected document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        public int? DocumentIndex { get; set; }

        /// <summary>
        /// Page number within the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_page_number")]
        public int? DocumentPageNumber { get; set; }

        /// <summary>
        /// Type or category of the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialDocumentMetadata" /> class.
        /// </summary>
        /// <param name="documentIndex">
        /// Index of the detected document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="documentPageNumber">
        /// Page number within the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="documentType">
        /// Type or category of the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialDocumentMetadata(
            int? documentIndex,
            int? documentPageNumber,
            string? documentType)
        {
            this.DocumentIndex = documentIndex;
            this.DocumentPageNumber = documentPageNumber;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialDocumentMetadata" /> class.
        /// </summary>
        public FinancialDocumentMetadata()
        {
        }

    }
}