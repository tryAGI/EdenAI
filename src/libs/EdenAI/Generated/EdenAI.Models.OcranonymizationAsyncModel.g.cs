
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcranonymizationAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateai")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Privateai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyredact")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Readyredact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        /// <param name="privateai"></param>
        /// <param name="readyredact"></param>
        /// <param name="base64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcranonymizationAsyncModel(
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? privateai,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? readyredact,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? base64)
        {
            this.Privateai = privateai;
            this.Readyredact = readyredact;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        public OcranonymizationAsyncModel()
        {
        }

    }
}