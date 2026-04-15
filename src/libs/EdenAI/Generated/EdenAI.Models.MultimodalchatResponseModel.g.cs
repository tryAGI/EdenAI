
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalchatResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.MultimodalchatChatDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.MultimodalchatChatDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.MultimodalchatChatDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.MultimodalchatChatDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.MultimodalchatChatDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.MultimodalchatChatDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.MultimodalchatChatDataClass? Anthropic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalchatResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="mistral"></param>
        /// <param name="amazon"></param>
        /// <param name="xai"></param>
        /// <param name="anthropic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalchatResponseModel(
            global::EdenAI.MultimodalchatChatDataClass? microsoft,
            global::EdenAI.MultimodalchatChatDataClass? google,
            global::EdenAI.MultimodalchatChatDataClass? openai,
            global::EdenAI.MultimodalchatChatDataClass? mistral,
            global::EdenAI.MultimodalchatChatDataClass? amazon,
            global::EdenAI.MultimodalchatChatDataClass? xai,
            global::EdenAI.MultimodalchatChatDataClass? anthropic)
        {
            this.Microsoft = microsoft;
            this.Google = google;
            this.Openai = openai;
            this.Mistral = mistral;
            this.Amazon = amazon;
            this.Xai = xai;
            this.Anthropic = anthropic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalchatResponseModel" /> class.
        /// </summary>
        public MultimodalchatResponseModel()
        {
        }
    }
}