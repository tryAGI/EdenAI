
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextkeywordExtractionResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Oneai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Emvista { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Openai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Xai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corticalio")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Corticalio { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextkeywordExtractionResponseModel" /> class.
        /// </summary>
        /// <param name="oneai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="emvista">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tenstorrent">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="xai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="corticalio">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextkeywordExtractionResponseModel(
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? oneai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? emvista,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? openai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? tenstorrent,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? xai,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? microsoft,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? corticalio,
            global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass? amazon)
        {
            this.Oneai = oneai;
            this.Emvista = emvista;
            this.Openai = openai;
            this.Tenstorrent = tenstorrent;
            this.Xai = xai;
            this.Microsoft = microsoft;
            this.Corticalio = corticalio;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextkeywordExtractionResponseModel" /> class.
        /// </summary>
        public TextkeywordExtractionResponseModel()
        {
        }
    }
}