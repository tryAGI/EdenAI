
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideogenerationAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Bytedance { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Minimax { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Openai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        /// <param name="bytedance">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="minimax">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideogenerationAsyncModel(
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? bytedance,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? minimax,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? microsoft,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? amazon,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? google,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? openai)
        {
            this.Bytedance = bytedance;
            this.Minimax = minimax;
            this.Microsoft = microsoft;
            this.Amazon = amazon;
            this.Google = google;
            this.Openai = openai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        public VideogenerationAsyncModel()
        {
        }
    }
}