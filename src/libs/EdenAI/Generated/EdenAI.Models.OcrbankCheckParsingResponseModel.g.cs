
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrbankCheckParsingResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("veryfi")]
        public global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? Veryfi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? Base64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mindee")]
        public global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? Mindee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracta")]
        public global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? Extracta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrbankCheckParsingResponseModel" /> class.
        /// </summary>
        /// <param name="veryfi"></param>
        /// <param name="base64"></param>
        /// <param name="mindee"></param>
        /// <param name="extracta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrbankCheckParsingResponseModel(
            global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? veryfi,
            global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? base64,
            global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? mindee,
            global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass? extracta)
        {
            this.Veryfi = veryfi;
            this.Base64 = base64;
            this.Mindee = mindee;
            this.Extracta = extracta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrbankCheckParsingResponseModel" /> class.
        /// </summary>
        public OcrbankCheckParsingResponseModel()
        {
        }
    }
}