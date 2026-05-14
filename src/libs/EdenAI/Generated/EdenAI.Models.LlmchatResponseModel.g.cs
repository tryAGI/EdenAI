
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
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.LlmchatChatDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.LlmchatChatDataClass? Xai { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("nebius")]
        public global::EdenAI.LlmchatChatDataClass? Nebius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::EdenAI.LlmchatChatDataClass? Replicate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("together_ai")]
        public global::EdenAI.LlmchatChatDataClass? TogetherAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepinfra")]
        public global::EdenAI.LlmchatChatDataClass? Deepinfra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cerebras")]
        public global::EdenAI.LlmchatChatDataClass? Cerebras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databricks")]
        public global::EdenAI.LlmchatChatDataClass? Databricks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashscope")]
        public global::EdenAI.LlmchatChatDataClass? Dashscope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("huggingface")]
        public global::EdenAI.LlmchatChatDataClass? Huggingface { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.LlmchatChatDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.LlmchatChatDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireworks_ai")]
        public global::EdenAI.LlmchatChatDataClass? FireworksAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iointelligence")]
        public global::EdenAI.LlmchatChatDataClass? Iointelligence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.LlmchatChatDataClass? Bytedance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ovhcloud")]
        public global::EdenAI.LlmchatChatDataClass? Ovhcloud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::EdenAI.LlmchatChatDataClass? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.LlmchatChatDataClass? Anthropic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.LlmchatChatDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudflare")]
        public global::EdenAI.LlmchatChatDataClass? Cloudflare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perplexityai")]
        public global::EdenAI.LlmchatChatDataClass? Perplexityai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groq")]
        public global::EdenAI.LlmchatChatDataClass? Groq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.LlmchatChatDataClass? Mistral { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="xai"></param>
        /// <param name="amazon"></param>
        /// <param name="minimax"></param>
        /// <param name="nebius"></param>
        /// <param name="replicate"></param>
        /// <param name="togetherAi"></param>
        /// <param name="deepinfra"></param>
        /// <param name="cerebras"></param>
        /// <param name="databricks"></param>
        /// <param name="dashscope"></param>
        /// <param name="huggingface"></param>
        /// <param name="google"></param>
        /// <param name="deepseek"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="microsoft"></param>
        /// <param name="fireworksAi"></param>
        /// <param name="iointelligence"></param>
        /// <param name="bytedance"></param>
        /// <param name="ovhcloud"></param>
        /// <param name="meta"></param>
        /// <param name="anthropic"></param>
        /// <param name="cohere"></param>
        /// <param name="cloudflare"></param>
        /// <param name="perplexityai"></param>
        /// <param name="groq"></param>
        /// <param name="mistral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmchatResponseModel(
            global::EdenAI.LlmchatChatDataClass? openai,
            global::EdenAI.LlmchatChatDataClass? xai,
            global::EdenAI.LlmchatChatDataClass? amazon,
            global::EdenAI.LlmchatChatDataClass? minimax,
            global::EdenAI.LlmchatChatDataClass? nebius,
            global::EdenAI.LlmchatChatDataClass? replicate,
            global::EdenAI.LlmchatChatDataClass? togetherAi,
            global::EdenAI.LlmchatChatDataClass? deepinfra,
            global::EdenAI.LlmchatChatDataClass? cerebras,
            global::EdenAI.LlmchatChatDataClass? databricks,
            global::EdenAI.LlmchatChatDataClass? dashscope,
            global::EdenAI.LlmchatChatDataClass? huggingface,
            global::EdenAI.LlmchatChatDataClass? google,
            global::EdenAI.LlmchatChatDataClass? deepseek,
            global::EdenAI.LlmchatChatDataClass? tenstorrent,
            global::EdenAI.LlmchatChatDataClass? microsoft,
            global::EdenAI.LlmchatChatDataClass? fireworksAi,
            global::EdenAI.LlmchatChatDataClass? iointelligence,
            global::EdenAI.LlmchatChatDataClass? bytedance,
            global::EdenAI.LlmchatChatDataClass? ovhcloud,
            global::EdenAI.LlmchatChatDataClass? meta,
            global::EdenAI.LlmchatChatDataClass? anthropic,
            global::EdenAI.LlmchatChatDataClass? cohere,
            global::EdenAI.LlmchatChatDataClass? cloudflare,
            global::EdenAI.LlmchatChatDataClass? perplexityai,
            global::EdenAI.LlmchatChatDataClass? groq,
            global::EdenAI.LlmchatChatDataClass? mistral)
        {
            this.Openai = openai;
            this.Xai = xai;
            this.Amazon = amazon;
            this.Minimax = minimax;
            this.Nebius = nebius;
            this.Replicate = replicate;
            this.TogetherAi = togetherAi;
            this.Deepinfra = deepinfra;
            this.Cerebras = cerebras;
            this.Databricks = databricks;
            this.Dashscope = dashscope;
            this.Huggingface = huggingface;
            this.Google = google;
            this.Deepseek = deepseek;
            this.Tenstorrent = tenstorrent;
            this.Microsoft = microsoft;
            this.FireworksAi = fireworksAi;
            this.Iointelligence = iointelligence;
            this.Bytedance = bytedance;
            this.Ovhcloud = ovhcloud;
            this.Meta = meta;
            this.Anthropic = anthropic;
            this.Cohere = cohere;
            this.Cloudflare = cloudflare;
            this.Perplexityai = perplexityai;
            this.Groq = groq;
            this.Mistral = mistral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatResponseModel" /> class.
        /// </summary>
        public LlmchatResponseModel()
        {
        }

    }
}