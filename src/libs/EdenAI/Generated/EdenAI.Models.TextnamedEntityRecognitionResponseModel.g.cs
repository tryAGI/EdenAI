
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextnamedEntityRecognitionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextnamedEntityRecognitionResponseModel" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="oneai"></param>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="microsoft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextnamedEntityRecognitionResponseModel(
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? xai,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? openai,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? tenstorrent,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? oneai,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? google,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? amazon,
            global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass? microsoft)
        {
            this.Xai = xai;
            this.Openai = openai;
            this.Tenstorrent = tenstorrent;
            this.Oneai = oneai;
            this.Google = google;
            this.Amazon = amazon;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextnamedEntityRecognitionResponseModel" /> class.
        /// </summary>
        public TextnamedEntityRecognitionResponseModel()
        {
        }
    }
}