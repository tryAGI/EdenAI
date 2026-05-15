
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrocrResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcrocrOcrDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.OcrocrOcrDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.OcrocrOcrDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.OcrocrOcrDataClass? Sentisight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrocrOcrDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.OcrocrOcrDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarifai")]
        public global::EdenAI.OcrocrOcrDataClass? Clarifai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcrocrOcrDataClass? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
        /// <param name="mistral"></param>
        /// <param name="sentisight"></param>
        /// <param name="amazon"></param>
        /// <param name="api4ai"></param>
        /// <param name="clarifai"></param>
        /// <param name="base64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrocrResponseModel(
            global::EdenAI.OcrocrOcrDataClass? microsoft,
            global::EdenAI.OcrocrOcrDataClass? google,
            global::EdenAI.OcrocrOcrDataClass? mistral,
            global::EdenAI.OcrocrOcrDataClass? sentisight,
            global::EdenAI.OcrocrOcrDataClass? amazon,
            global::EdenAI.OcrocrOcrDataClass? api4ai,
            global::EdenAI.OcrocrOcrDataClass? clarifai,
            global::EdenAI.OcrocrOcrDataClass? base64)
        {
            this.Microsoft = microsoft;
            this.Google = google;
            this.Mistral = mistral;
            this.Sentisight = sentisight;
            this.Amazon = amazon;
            this.Api4ai = api4ai;
            this.Clarifai = clarifai;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrResponseModel" /> class.
        /// </summary>
        public OcrocrResponseModel()
        {
        }

    }
}