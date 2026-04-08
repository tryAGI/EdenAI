
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextsummarizeResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Xai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Emvista { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writesonic")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Writesonic { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meaningcloud")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Meaningcloud { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Oneai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Cohere { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alephalpha")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Alephalpha { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Openai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        public global::EdenAI.TextsummarizeSummarizeDataClass? Anthropic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsummarizeResponseModel" /> class.
        /// </summary>
        /// <param name="xai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="emvista">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="writesonic">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="meaningcloud">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="oneai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cohere">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="alephalpha">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="anthropic">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextsummarizeResponseModel(
            global::EdenAI.TextsummarizeSummarizeDataClass? xai,
            global::EdenAI.TextsummarizeSummarizeDataClass? emvista,
            global::EdenAI.TextsummarizeSummarizeDataClass? writesonic,
            global::EdenAI.TextsummarizeSummarizeDataClass? meaningcloud,
            global::EdenAI.TextsummarizeSummarizeDataClass? oneai,
            global::EdenAI.TextsummarizeSummarizeDataClass? cohere,
            global::EdenAI.TextsummarizeSummarizeDataClass? microsoft,
            global::EdenAI.TextsummarizeSummarizeDataClass? alephalpha,
            global::EdenAI.TextsummarizeSummarizeDataClass? openai,
            global::EdenAI.TextsummarizeSummarizeDataClass? anthropic)
        {
            this.Xai = xai;
            this.Emvista = emvista;
            this.Writesonic = writesonic;
            this.Meaningcloud = meaningcloud;
            this.Oneai = oneai;
            this.Cohere = cohere;
            this.Microsoft = microsoft;
            this.Alephalpha = alephalpha;
            this.Openai = openai;
            this.Anthropic = anthropic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsummarizeResponseModel" /> class.
        /// </summary>
        public TextsummarizeResponseModel()
        {
        }
    }
}