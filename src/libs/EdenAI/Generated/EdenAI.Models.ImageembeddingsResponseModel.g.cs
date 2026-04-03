
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageembeddingsResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImageembeddingsEmbeddingsDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alephalpha")]
        public global::EdenAI.ImageembeddingsEmbeddingsDataClass? Alephalpha { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImageembeddingsEmbeddingsDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageembeddingsResponseModel" /> class.
        /// </summary>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="alephalpha">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageembeddingsResponseModel(
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? amazon,
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? alephalpha,
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? google)
        {
            this.Amazon = amazon;
            this.Alephalpha = alephalpha;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageembeddingsResponseModel" /> class.
        /// </summary>
        public ImageembeddingsResponseModel()
        {
        }
    }
}