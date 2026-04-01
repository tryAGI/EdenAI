
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideotextDetectionAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twelvelabs")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Twelvelabs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideotextDetectionAsyncModel" /> class.
        /// </summary>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="twelvelabs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideotextDetectionAsyncModel(
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? google,
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? amazon,
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? twelvelabs)
        {
            this.Google = google;
            this.Amazon = amazon;
            this.Twelvelabs = twelvelabs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideotextDetectionAsyncModel" /> class.
        /// </summary>
        public VideotextDetectionAsyncModel()
        {
        }
    }
}