
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrfinancialParserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracta")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Extracta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("veryfi")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Veryfi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tabscanner")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Tabscanner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Base64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mindee")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Mindee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataleon")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Dataleon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagledoc")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Eagledoc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("klippa")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Klippa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinda")]
        public global::EdenAI.OcrfinancialParserFinancialParserDataClass? Affinda { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrfinancialParserResponseModel" /> class.
        /// </summary>
        /// <param name="extracta"></param>
        /// <param name="veryfi"></param>
        /// <param name="tabscanner"></param>
        /// <param name="base64"></param>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="openai"></param>
        /// <param name="mindee"></param>
        /// <param name="dataleon"></param>
        /// <param name="eagledoc"></param>
        /// <param name="klippa"></param>
        /// <param name="microsoft"></param>
        /// <param name="affinda"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrfinancialParserResponseModel(
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? extracta,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? veryfi,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? tabscanner,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? base64,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? google,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? amazon,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? openai,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? mindee,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? dataleon,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? eagledoc,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? klippa,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? microsoft,
            global::EdenAI.OcrfinancialParserFinancialParserDataClass? affinda)
        {
            this.Extracta = extracta;
            this.Veryfi = veryfi;
            this.Tabscanner = tabscanner;
            this.Base64 = base64;
            this.Google = google;
            this.Amazon = amazon;
            this.Openai = openai;
            this.Mindee = mindee;
            this.Dataleon = dataleon;
            this.Eagledoc = eagledoc;
            this.Klippa = klippa;
            this.Microsoft = microsoft;
            this.Affinda = affinda;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrfinancialParserResponseModel" /> class.
        /// </summary>
        public OcrfinancialParserResponseModel()
        {
        }
    }
}