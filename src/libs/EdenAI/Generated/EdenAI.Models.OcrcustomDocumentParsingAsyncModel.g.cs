
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrcustomDocumentParsingAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
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
        /// <param name="amazon"></param>
        /// <param name="extracta"></param>
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