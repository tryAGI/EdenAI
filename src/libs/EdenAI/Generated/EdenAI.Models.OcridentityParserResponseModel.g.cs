
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcridentityParserResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinda")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Affinda { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Openai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Base64 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("klippa")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Klippa { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mindee")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Mindee { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcridentityParserResponseModel" /> class.
        /// </summary>
        /// <param name="affinda">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="base64">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="klippa">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mindee">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcridentityParserResponseModel(
            global::EdenAI.OcridentityParserIdentityParserDataClass? affinda,
            global::EdenAI.OcridentityParserIdentityParserDataClass? openai,
            global::EdenAI.OcridentityParserIdentityParserDataClass? amazon,
            global::EdenAI.OcridentityParserIdentityParserDataClass? base64,
            global::EdenAI.OcridentityParserIdentityParserDataClass? klippa,
            global::EdenAI.OcridentityParserIdentityParserDataClass? mindee,
            global::EdenAI.OcridentityParserIdentityParserDataClass? microsoft)
        {
            this.Affinda = affinda;
            this.Openai = openai;
            this.Amazon = amazon;
            this.Base64 = base64;
            this.Klippa = klippa;
            this.Mindee = mindee;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcridentityParserResponseModel" /> class.
        /// </summary>
        public OcridentityParserResponseModel()
        {
        }
    }
}