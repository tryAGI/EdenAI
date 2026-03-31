
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrcustomDocumentParsingAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracta")]
        public global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass? Extracta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrcustomDocumentParsingAsyncModel" /> class.
        /// </summary>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="extracta">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrcustomDocumentParsingAsyncModel(
            global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass? amazon,
            global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass? extracta)
        {
            this.Amazon = amazon;
            this.Extracta = extracta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrcustomDocumentParsingAsyncModel" /> class.
        /// </summary>
        public OcrcustomDocumentParsingAsyncModel()
        {
        }
    }
}