
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcranonymizationAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Base64 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyredact")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Readyredact { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateai")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Privateai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        /// <param name="base64">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="readyredact">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="privateai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcranonymizationAsyncModel(
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? base64,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? readyredact,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? privateai)
        {
            this.Base64 = base64;
            this.Readyredact = readyredact;
            this.Privateai = privateai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        public OcranonymizationAsyncModel()
        {
        }
    }
}