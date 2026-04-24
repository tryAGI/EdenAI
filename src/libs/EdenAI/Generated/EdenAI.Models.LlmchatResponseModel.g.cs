
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
        [global::System.Text.Json.Serialization.JsonPropertyName("deepseek")]
        public global::EdenAI.LlmchatChatDataClass? Deepseek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cerebras")]
        public global::EdenAI.LlmchatChatDataClass? Cerebras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.LlmchatChatDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.LlmchatChatDataClass? Openai { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("iointelligence")]
        public global::EdenAI.LlmchatChatDataClass? Iointelligence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("huggingface")]
        public global::EdenAI.LlmchatChatDataClass? Huggingface { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.LlmchatChatDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepinfra")]
        public global::EdenAI.LlmchatChatDataClass? Deepinfra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.LlmchatChatDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ovhcloud")]
        public global::EdenAI.LlmchatChatDataClass? Ovhcloud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::EdenAI.LlmchatChatDataClass? Replicate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.LlmchatChatDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashscope")]
        public global::EdenAI.LlmchatChatDataClass? Dashscope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perplexityai")]
        public global::EdenAI.LlmchatChatDataClass? Perplexityai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireworks_ai")]
        public global::EdenAI.LlmchatChatDataClass? FireworksAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.LlmchatChatDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudflare")]
        public global::EdenAI.LlmchatChatDataClass? Cloudflare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nebius")]
        public global::EdenAI.LlmchatChatDataClass? Nebius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("together_ai")]
        public global::EdenAI.LlmchatChatDataClass? TogetherAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groq")]
        public global::EdenAI.LlmchatChatDataClass? Groq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.LlmchatChatDataClass? Bytedance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::EdenAI.LlmchatChatDataClass? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.LlmchatChatDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.LlmchatChatDataClass? Minimax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.LlmchatChatDataClass? Anthropic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        /// <param name="deepseek"></param>
        /// <param name="cerebras"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="databricks"></param>
        /// <param name="iointelligence"></param>
        /// <param name="huggingface"></param>
        /// <param name="xai"></param>
        /// <param name="deepinfra"></param>
        /// <param name="cohere"></param>
        /// <param name="ovhcloud"></param>
        /// <param name="replicate"></param>
        /// <param name="mistral"></param>
        /// <param name="dashscope"></param>
        /// <param name="perplexityai"></param>
        /// <param name="fireworksAi"></param>
        /// <param name="microsoft"></param>
        /// <param name="cloudflare"></param>
        /// <param name="nebius"></param>
        /// <param name="togetherAi"></param>
        /// <param name="groq"></param>
        /// <param name="bytedance"></param>
        /// <param name="meta"></param>
        /// <param name="amazon"></param>
        /// <param name="minimax"></param>
        /// <param name="anthropic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmchatResponseModel(
            global::EdenAI.LlmchatChatDataClass? deepseek,
            global::EdenAI.LlmchatChatDataClass? cerebras,
            global::EdenAI.LlmchatChatDataClass? google,
            global::EdenAI.LlmchatChatDataClass? openai,
            global::EdenAI.LlmchatChatDataClass? tenstorrent,
            global::EdenAI.LlmchatChatDataClass? databricks,
            global::EdenAI.LlmchatChatDataClass? iointelligence,
            global::EdenAI.LlmchatChatDataClass? huggingface,
            global::EdenAI.LlmchatChatDataClass? xai,
            global::EdenAI.LlmchatChatDataClass? deepinfra,
            global::EdenAI.LlmchatChatDataClass? cohere,
            global::EdenAI.LlmchatChatDataClass? ovhcloud,
            global::EdenAI.LlmchatChatDataClass? replicate,
            global::EdenAI.LlmchatChatDataClass? mistral,
            global::EdenAI.LlmchatChatDataClass? dashscope,
            global::EdenAI.LlmchatChatDataClass? perplexityai,
            global::EdenAI.LlmchatChatDataClass? fireworksAi,
            global::EdenAI.LlmchatChatDataClass? microsoft,
            global::EdenAI.LlmchatChatDataClass? cloudflare,
            global::EdenAI.LlmchatChatDataClass? nebius,
            global::EdenAI.LlmchatChatDataClass? togetherAi,
            global::EdenAI.LlmchatChatDataClass? groq,
            global::EdenAI.LlmchatChatDataClass? bytedance,
            global::EdenAI.LlmchatChatDataClass? meta,
            global::EdenAI.LlmchatChatDataClass? amazon,
            global::EdenAI.LlmchatChatDataClass? minimax,
            global::EdenAI.LlmchatChatDataClass? anthropic)
        {
            this.Deepseek = deepseek;
            this.Cerebras = cerebras;
            this.Google = google;
            this.Openai = openai;
            this.Tenstorrent = tenstorrent;
            this.Databricks = databricks;
            this.Iointelligence = iointelligence;
            this.Huggingface = huggingface;
            this.Xai = xai;
            this.Deepinfra = deepinfra;
            this.Cohere = cohere;
            this.Ovhcloud = ovhcloud;
            this.Replicate = replicate;
            this.Mistral = mistral;
            this.Dashscope = dashscope;
            this.Perplexityai = perplexityai;
            this.FireworksAi = fireworksAi;
            this.Microsoft = microsoft;
            this.Cloudflare = cloudflare;
            this.Nebius = nebius;
            this.TogetherAi = togetherAi;
            this.Groq = groq;
            this.Bytedance = bytedance;
            this.Meta = meta;
            this.Amazon = amazon;
            this.Minimax = minimax;
            this.Anthropic = anthropic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        public LlmchatResponseModel()
        {
        }
    }
}