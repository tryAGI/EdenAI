
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
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TexttopicExtractionTopicExtractionDataClass? Openai { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TexttopicExtractionResponseModel" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TexttopicExtractionResponseModel(
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? xai,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? openai,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? tenstorrent,
            global::EdenAI.TexttopicExtractionTopicExtractionDataClass? google)
        {
            this.Xai = xai;
            this.Openai = openai;
            this.Tenstorrent = tenstorrent;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TexttopicExtractionResponseModel" /> class.
        /// </summary>
        public TexttopicExtractionResponseModel()
        {
        }

    }
}