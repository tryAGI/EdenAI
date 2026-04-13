
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextchatResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::EdenAI.TextchatChatDataClass? Replicate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groq")]
        public global::EdenAI.TextchatChatDataClass? Groq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextchatChatDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perplexityai")]
        public global::EdenAI.TextchatChatDataClass? Perplexityai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("together_ai")]
        public global::EdenAI.TextchatChatDataClass? TogetherAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextchatChatDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.TextchatChatDataClass? Anthropic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextchatChatDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextchatChatDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::EdenAI.TextchatChatDataClass? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.TextchatChatDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextchatChatDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepseek")]
        public global::EdenAI.TextchatChatDataClass? Deepseek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextchatChatDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextchatResponseModel" /> class.
        /// </summary>
        /// <param name="replicate"></param>
        /// <param name="groq"></param>
        /// <param name="amazon"></param>
        /// <param name="perplexityai"></param>
        /// <param name="togetherAi"></param>
        /// <param name="xai"></param>
        /// <param name="anthropic"></param>
        /// <param name="openai"></param>
        /// <param name="cohere"></param>
        /// <param name="meta"></param>
        /// <param name="mistral"></param>
        /// <param name="google"></param>
        /// <param name="deepseek"></param>
        /// <param name="microsoft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextchatResponseModel(
            global::EdenAI.TextchatChatDataClass? replicate,
            global::EdenAI.TextchatChatDataClass? groq,
            global::EdenAI.TextchatChatDataClass? amazon,
            global::EdenAI.TextchatChatDataClass? perplexityai,
            global::EdenAI.TextchatChatDataClass? togetherAi,
            global::EdenAI.TextchatChatDataClass? xai,
            global::EdenAI.TextchatChatDataClass? anthropic,
            global::EdenAI.TextchatChatDataClass? openai,
            global::EdenAI.TextchatChatDataClass? cohere,
            global::EdenAI.TextchatChatDataClass? meta,
            global::EdenAI.TextchatChatDataClass? mistral,
            global::EdenAI.TextchatChatDataClass? google,
            global::EdenAI.TextchatChatDataClass? deepseek,
            global::EdenAI.TextchatChatDataClass? microsoft)
        {
            this.Replicate = replicate;
            this.Groq = groq;
            this.Amazon = amazon;
            this.Perplexityai = perplexityai;
            this.TogetherAi = togetherAi;
            this.Xai = xai;
            this.Anthropic = anthropic;
            this.Openai = openai;
            this.Cohere = cohere;
            this.Meta = meta;
            this.Mistral = mistral;
            this.Google = google;
            this.Deepseek = deepseek;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextchatResponseModel" /> class.
        /// </summary>
        public TextchatResponseModel()
        {
        }
    }
}