
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrresumeParserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hireability")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Hireability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("senseloaf")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Senseloaf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinda")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Affinda { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("klippa")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Klippa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracta")]
        public global::EdenAI.OcrresumeParserResumeParserDataClass? Extracta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrresumeParserResponseModel" /> class.
        /// </summary>
        /// <param name="hireability"></param>
        /// <param name="senseloaf"></param>
        /// <param name="affinda"></param>
        /// <param name="klippa"></param>
        /// <param name="openai"></param>
        /// <param name="extracta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrresumeParserResponseModel(
            global::EdenAI.OcrresumeParserResumeParserDataClass? hireability,
            global::EdenAI.OcrresumeParserResumeParserDataClass? senseloaf,
            global::EdenAI.OcrresumeParserResumeParserDataClass? affinda,
            global::EdenAI.OcrresumeParserResumeParserDataClass? klippa,
            global::EdenAI.OcrresumeParserResumeParserDataClass? openai,
            global::EdenAI.OcrresumeParserResumeParserDataClass? extracta)
        {
            this.Hireability = hireability;
            this.Senseloaf = senseloaf;
            this.Affinda = affinda;
            this.Klippa = klippa;
            this.Openai = openai;
            this.Extracta = extracta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrresumeParserResponseModel" /> class.
        /// </summary>
        public OcrresumeParserResponseModel()
        {
        }
    }
}