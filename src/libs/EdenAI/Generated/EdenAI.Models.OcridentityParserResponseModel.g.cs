
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcridentityParserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinda")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Affinda { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("klippa")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Klippa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mindee")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Mindee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcridentityParserIdentityParserDataClass? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcridentityParserResponseModel" /> class.
        /// </summary>
        /// <param name="affinda"></param>
        /// <param name="klippa"></param>
        /// <param name="microsoft"></param>
        /// <param name="mindee"></param>
        /// <param name="openai"></param>
        /// <param name="amazon"></param>
        /// <param name="base64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcridentityParserResponseModel(
            global::EdenAI.OcridentityParserIdentityParserDataClass? affinda,
            global::EdenAI.OcridentityParserIdentityParserDataClass? klippa,
            global::EdenAI.OcridentityParserIdentityParserDataClass? microsoft,
            global::EdenAI.OcridentityParserIdentityParserDataClass? mindee,
            global::EdenAI.OcridentityParserIdentityParserDataClass? openai,
            global::EdenAI.OcridentityParserIdentityParserDataClass? amazon,
            global::EdenAI.OcridentityParserIdentityParserDataClass? base64)
        {
            this.Affinda = affinda;
            this.Klippa = klippa;
            this.Microsoft = microsoft;
            this.Mindee = mindee;
            this.Openai = openai;
            this.Amazon = amazon;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcridentityParserResponseModel" /> class.
        /// </summary>
        public OcridentityParserResponseModel()
        {
        }
    }
}