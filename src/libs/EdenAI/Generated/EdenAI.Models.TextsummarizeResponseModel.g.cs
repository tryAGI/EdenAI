
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextsummarizeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meaningcloud")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Meaningcloud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Anthropic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alephalpha")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Alephalpha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writesonic")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Writesonic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Emvista { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsummarizeResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="xai"></param>
        /// <param name="meaningcloud"></param>
        /// <param name="cohere"></param>
        /// <param name="anthropic"></param>
        /// <param name="alephalpha"></param>
        /// <param name="writesonic"></param>
        /// <param name="openai"></param>
        /// <param name="oneai"></param>
        /// <param name="emvista"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextsummarizeResponseModel(
            global::EdenAI.TextsummarizeSummarizeDataClass? microsoft,
            global::EdenAI.TextsummarizeSummarizeDataClass? xai,
            global::EdenAI.TextsummarizeSummarizeDataClass? meaningcloud,
            global::EdenAI.TextsummarizeSummarizeDataClass? cohere,
            global::EdenAI.TextsummarizeSummarizeDataClass? anthropic,
            global::EdenAI.TextsummarizeSummarizeDataClass? alephalpha,
            global::EdenAI.TextsummarizeSummarizeDataClass? writesonic,
            global::EdenAI.TextsummarizeSummarizeDataClass? openai,
            global::EdenAI.TextsummarizeSummarizeDataClass? oneai,
            global::EdenAI.TextsummarizeSummarizeDataClass? emvista)
        {
            this.Microsoft = microsoft;
            this.Xai = xai;
            this.Meaningcloud = meaningcloud;
            this.Cohere = cohere;
            this.Anthropic = anthropic;
            this.Alephalpha = alephalpha;
            this.Writesonic = writesonic;
            this.Openai = openai;
            this.Oneai = oneai;
            this.Emvista = emvista;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsummarizeResponseModel" /> class.
        /// </summary>
        public TextsummarizeResponseModel()
        {
        }
    }
}