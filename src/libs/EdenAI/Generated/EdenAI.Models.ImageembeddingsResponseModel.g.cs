
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageembeddingsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alephalpha")]
        public global::EdenAI.ImageembeddingsEmbeddingsDataClass? Alephalpha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImageembeddingsEmbeddingsDataClass? Amazon { get; set; }

        /// <summary>
        /// 
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
        /// <param name="alephalpha"></param>
        /// <param name="amazon"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageembeddingsResponseModel(
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? alephalpha,
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? amazon,
            global::EdenAI.ImageembeddingsEmbeddingsDataClass? google)
        {
            this.Alephalpha = alephalpha;
            this.Amazon = amazon;
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