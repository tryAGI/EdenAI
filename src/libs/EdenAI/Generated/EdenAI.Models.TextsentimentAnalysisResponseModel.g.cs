
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextsentimentAnalysisResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenstorrent")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Tenstorrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Emvista { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sapling")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Sapling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ibm")]
        public global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? Ibm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsentimentAnalysisResponseModel" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="tenstorrent"></param>
        /// <param name="emvista"></param>
        /// <param name="oneai"></param>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="sapling"></param>
        /// <param name="amazon"></param>
        /// <param name="ibm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextsentimentAnalysisResponseModel(
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? xai,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? tenstorrent,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? emvista,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? oneai,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? microsoft,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? google,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? openai,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? sapling,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? amazon,
            global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass? ibm)
        {
            this.Xai = xai;
            this.Tenstorrent = tenstorrent;
            this.Emvista = emvista;
            this.Oneai = oneai;
            this.Microsoft = microsoft;
            this.Google = google;
            this.Openai = openai;
            this.Sapling = sapling;
            this.Amazon = amazon;
            this.Ibm = ibm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextsentimentAnalysisResponseModel" /> class.
        /// </summary>
        public TextsentimentAnalysisResponseModel()
        {
        }

    }
}