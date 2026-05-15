
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextkeywordExtractionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corticalio")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Corticalio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Emvista { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextkeywordExtractionResponseModel" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="oneai"></param>
        /// <param name="microsoft"></param>
        /// <param name="amazon"></param>
        /// <param name="xai"></param>
        /// <param name="corticalio"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="emvista"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextkeywordExtractionResponseModel(
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? openai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? oneai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? microsoft,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? amazon,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? xai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? corticalio,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? tenstorrent,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? emvista)
        {
            this.Openai = openai;
            this.Oneai = oneai;
            this.Microsoft = microsoft;
            this.Amazon = amazon;
            this.Xai = xai;
            this.Corticalio = corticalio;
            this.Tenstorrent = tenstorrent;
            this.Emvista = emvista;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextkeywordExtractionResponseModel" /> class.
        /// </summary>
        public TextkeywordExtractionResponseModel()
        {
        }

    }
}