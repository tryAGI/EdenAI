
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagefaceDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarifai")]
        public global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? Clarifai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="api4ai"></param>
        /// <param name="amazon"></param>
        /// <param name="clarifai"></param>
        /// <param name="google"></param>
        /// <param name="microsoft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagefaceDetectionResponseModel(
            global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? api4ai,
            global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? amazon,
            global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? clarifai,
            global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? google,
            global::EdenAI.ImagefaceDetectionFaceDetectionDataClass? microsoft)
        {
            this.Api4ai = api4ai;
            this.Amazon = amazon;
            this.Clarifai = clarifai;
            this.Google = google;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceDetectionResponseModel" /> class.
        /// </summary>
        public ImagefaceDetectionResponseModel()
        {
        }
    }
}