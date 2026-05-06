
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageexplicitContentResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Sentisight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarifai")]
        public global::EdenAI.ImageexplicitContentExplicitContentDataClass? Clarifai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageexplicitContentResponseModel" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="openai"></param>
        /// <param name="sentisight"></param>
        /// <param name="api4ai"></param>
        /// <param name="microsoft"></param>
        /// <param name="clarifai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageexplicitContentResponseModel(
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? google,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? amazon,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? openai,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? sentisight,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? api4ai,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? microsoft,
            global::EdenAI.ImageexplicitContentExplicitContentDataClass? clarifai)
        {
            this.Google = google;
            this.Amazon = amazon;
            this.Openai = openai;
            this.Sentisight = sentisight;
            this.Api4ai = api4ai;
            this.Microsoft = microsoft;
            this.Clarifai = clarifai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageexplicitContentResponseModel" /> class.
        /// </summary>
        public ImageexplicitContentResponseModel()
        {
        }
    }
}