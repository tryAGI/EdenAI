
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageobjectDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Sentisight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarifai")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Clarifai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageobjectDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="amazon"></param>
        /// <param name="sentisight"></param>
        /// <param name="clarifai"></param>
        /// <param name="api4ai"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageobjectDetectionResponseModel(
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? microsoft,
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? amazon,
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? sentisight,
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? clarifai,
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? api4ai,
            global::EdenAI.ImageobjectDetectionObjectDetectionDataClass? google)
        {
            this.Microsoft = microsoft;
            this.Amazon = amazon;
            this.Sentisight = sentisight;
            this.Clarifai = clarifai;
            this.Api4ai = api4ai;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageobjectDetectionResponseModel" /> class.
        /// </summary>
        public ImageobjectDetectionResponseModel()
        {
        }
    }
}