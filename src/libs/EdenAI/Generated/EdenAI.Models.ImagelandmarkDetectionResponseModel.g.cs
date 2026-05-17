
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagelandmarkDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagelandmarkDetectionLandmarkDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImagelandmarkDetectionLandmarkDetectionDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagelandmarkDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagelandmarkDetectionResponseModel(
            global::EdenAI.ImagelandmarkDetectionLandmarkDetectionDataClass? microsoft,
            global::EdenAI.ImagelandmarkDetectionLandmarkDetectionDataClass? google)
        {
            this.Microsoft = microsoft;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagelandmarkDetectionResponseModel" /> class.
        /// </summary>
        public ImagelandmarkDetectionResponseModel()
        {
        }

    }
}