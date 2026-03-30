
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrdataExtractionResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrdataExtractionDataExtractionDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcrdataExtractionDataExtractionDataClass? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrdataExtractionResponseModel" /> class.
        /// </summary>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="base64">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrdataExtractionResponseModel(
            global::EdenAI.OcrdataExtractionDataExtractionDataClass? amazon,
            global::EdenAI.OcrdataExtractionDataExtractionDataClass? base64)
        {
            this.Amazon = amazon;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrdataExtractionResponseModel" /> class.
        /// </summary>
        public OcrdataExtractionResponseModel()
        {
        }
    }
}