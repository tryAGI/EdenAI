
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagelogoDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smartclick")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Smartclick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Anthropic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarifai")]
        public global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? Clarifai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagelogoDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="smartclick"></param>
        /// <param name="google"></param>
        /// <param name="api4ai"></param>
        /// <param name="microsoft"></param>
        /// <param name="anthropic"></param>
        /// <param name="openai"></param>
        /// <param name="clarifai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagelogoDetectionResponseModel(
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? smartclick,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? google,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? api4ai,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? microsoft,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? anthropic,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? openai,
            global::EdenAI.ImagelogoDetectionLogoDetectionDataClass? clarifai)
        {
            this.Smartclick = smartclick;
            this.Google = google;
            this.Api4ai = api4ai;
            this.Microsoft = microsoft;
            this.Anthropic = anthropic;
            this.Openai = openai;
            this.Clarifai = clarifai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagelogoDetectionResponseModel" /> class.
        /// </summary>
        public ImagelogoDetectionResponseModel()
        {
        }

    }
}