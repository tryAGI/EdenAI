
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmchatResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.LlmchatChatDataClass? Minimax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.LlmchatChatDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nebius")]
        public global::EdenAI.LlmchatChatDataClass? Nebius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ovhcloud")]
        public global::EdenAI.LlmchatChatDataClass? Ovhcloud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.LlmchatChatDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iointelligence")]
        public global::EdenAI.LlmchatChatDataClass? Iointelligence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashscope")]
        public global::EdenAI.LlmchatChatDataClass? Dashscope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cerebras")]
        public global::EdenAI.LlmchatChatDataClass? Cerebras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.LlmchatChatDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databricks")]
        public global::EdenAI.LlmchatChatDataClass? Databricks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.LlmchatChatDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.LlmchatChatDataClass? Anthropic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::EdenAI.LlmchatChatDataClass? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("together_ai")]
        public global::EdenAI.LlmchatChatDataClass? TogetherAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.LlmchatChatDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groq")]
        public global::EdenAI.LlmchatChatDataClass? Groq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepinfra")]
        public global::EdenAI.LlmchatChatDataClass? Deepinfra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.LlmchatChatDataClass? Bytedance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::EdenAI.LlmchatChatDataClass? Replicate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireworks_ai")]
        public global::EdenAI.LlmchatChatDataClass? FireworksAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudflare")]
        public global::EdenAI.LlmchatChatDataClass? Cloudflare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.LlmchatChatDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepseek")]
        public global::EdenAI.LlmchatChatDataClass? Deepseek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.LlmchatChatDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.LlmchatChatDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perplexityai")]
        public global::EdenAI.LlmchatChatDataClass? Perplexityai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        /// <param name="minimax"></param>
        /// <param name="mistral"></param>
        /// <param name="nebius"></param>
        /// <param name="ovhcloud"></param>
        /// <param name="cohere"></param>
        /// <param name="iointelligence"></param>
        /// <param name="dashscope"></param>
        /// <param name="cerebras"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="databricks"></param>
        /// <param name="microsoft"></param>
        /// <param name="anthropic"></param>
        /// <param name="meta"></param>
        /// <param name="togetherAi"></param>
        /// <param name="xai"></param>
        /// <param name="groq"></param>
        /// <param name="deepinfra"></param>
        /// <param name="bytedance"></param>
        /// <param name="replicate"></param>
        /// <param name="fireworksAi"></param>
        /// <param name="cloudflare"></param>
        /// <param name="google"></param>
        /// <param name="deepseek"></param>
        /// <param name="openai"></param>
        /// <param name="amazon"></param>
        /// <param name="perplexityai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmchatResponseModel(
            global::EdenAI.LlmchatChatDataClass? minimax,
            global::EdenAI.LlmchatChatDataClass? mistral,
            global::EdenAI.LlmchatChatDataClass? nebius,
            global::EdenAI.LlmchatChatDataClass? ovhcloud,
            global::EdenAI.LlmchatChatDataClass? cohere,
            global::EdenAI.LlmchatChatDataClass? iointelligence,
            global::EdenAI.LlmchatChatDataClass? dashscope,
            global::EdenAI.LlmchatChatDataClass? cerebras,
            global::EdenAI.LlmchatChatDataClass? tenstorrent,
            global::EdenAI.LlmchatChatDataClass? databricks,
            global::EdenAI.LlmchatChatDataClass? microsoft,
            global::EdenAI.LlmchatChatDataClass? anthropic,
            global::EdenAI.LlmchatChatDataClass? meta,
            global::EdenAI.LlmchatChatDataClass? togetherAi,
            global::EdenAI.LlmchatChatDataClass? xai,
            global::EdenAI.LlmchatChatDataClass? groq,
            global::EdenAI.LlmchatChatDataClass? deepinfra,
            global::EdenAI.LlmchatChatDataClass? bytedance,
            global::EdenAI.LlmchatChatDataClass? replicate,
            global::EdenAI.LlmchatChatDataClass? fireworksAi,
            global::EdenAI.LlmchatChatDataClass? cloudflare,
            global::EdenAI.LlmchatChatDataClass? google,
            global::EdenAI.LlmchatChatDataClass? deepseek,
            global::EdenAI.LlmchatChatDataClass? openai,
            global::EdenAI.LlmchatChatDataClass? amazon,
            global::EdenAI.LlmchatChatDataClass? perplexityai)
        {
            this.Minimax = minimax;
            this.Mistral = mistral;
            this.Nebius = nebius;
            this.Ovhcloud = ovhcloud;
            this.Cohere = cohere;
            this.Iointelligence = iointelligence;
            this.Dashscope = dashscope;
            this.Cerebras = cerebras;
            this.Tenstorrent = tenstorrent;
            this.Databricks = databricks;
            this.Microsoft = microsoft;
            this.Anthropic = anthropic;
            this.Meta = meta;
            this.TogetherAi = togetherAi;
            this.Xai = xai;
            this.Groq = groq;
            this.Deepinfra = deepinfra;
            this.Bytedance = bytedance;
            this.Replicate = replicate;
            this.FireworksAi = fireworksAi;
            this.Cloudflare = cloudflare;
            this.Google = google;
            this.Deepseek = deepseek;
            this.Openai = openai;
            this.Amazon = amazon;
            this.Perplexityai = perplexityai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        public LlmchatResponseModel()
        {
        }
    }
}