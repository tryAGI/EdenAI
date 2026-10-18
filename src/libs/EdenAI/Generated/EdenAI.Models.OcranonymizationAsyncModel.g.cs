
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
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Base64 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limina")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Limina { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyredact")]
        public global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? Readyredact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        /// <param name="base64"></param>
        /// <param name="limina"></param>
        /// <param name="readyredact"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcranonymizationAsyncModel(
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? base64,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? limina,
            global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass? readyredact)
        {
            this.Base64 = base64;
            this.Limina = limina;
            this.Readyredact = readyredact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcranonymizationAsyncModel" /> class.
        /// </summary>
        public OcranonymizationAsyncModel()
        {
        }

    }
}