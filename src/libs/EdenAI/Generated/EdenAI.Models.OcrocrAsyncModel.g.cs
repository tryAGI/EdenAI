
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrocrAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.OcrocrAsyncOcrAsyncDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrocrAsyncOcrAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.OcrocrAsyncOcrAsyncDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mistral")]
        public global::EdenAI.OcrocrAsyncOcrAsyncDataClass? Mistral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcrocrAsyncOcrAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrAsyncModel" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="oneai"></param>
        /// <param name="mistral"></param>
        /// <param name="microsoft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrocrAsyncModel(
            global::EdenAI.OcrocrAsyncOcrAsyncDataClass? google,
            global::EdenAI.OcrocrAsyncOcrAsyncDataClass? amazon,
            global::EdenAI.OcrocrAsyncOcrAsyncDataClass? oneai,
            global::EdenAI.OcrocrAsyncOcrAsyncDataClass? mistral,
            global::EdenAI.OcrocrAsyncOcrAsyncDataClass? microsoft)
        {
            this.Google = google;
            this.Amazon = amazon;
            this.Oneai = oneai;
            this.Mistral = mistral;
            this.Microsoft = microsoft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrAsyncModel" /> class.
        /// </summary>
        public OcrocrAsyncModel()
        {
        }
    }
}