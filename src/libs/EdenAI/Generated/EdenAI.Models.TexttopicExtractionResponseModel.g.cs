
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TexttopicExtractionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Xai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TexttopicExtractionResponseModel" /> class.
        /// </summary>
        /// <param name="tenstorrent"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="xai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TexttopicExtractionResponseModel(
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? tenstorrent,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? google,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? openai,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? xai)
        {
            this.Tenstorrent = tenstorrent;
            this.Google = google;
            this.Openai = openai;
            this.Xai = xai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TexttopicExtractionResponseModel" /> class.
        /// </summary>
        public TexttopicExtractionResponseModel()
        {
        }
    }
}