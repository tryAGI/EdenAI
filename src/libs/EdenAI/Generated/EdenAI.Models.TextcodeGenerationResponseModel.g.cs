
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextcodeGenerationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextcodeGenerationCodeGenerationDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextcodeGenerationCodeGenerationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextcodeGenerationCodeGenerationDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextcodeGenerationResponseModel" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextcodeGenerationResponseModel(
            global::EdenAI.TextcodeGenerationCodeGenerationDataClass? xai,
            global::EdenAI.TextcodeGenerationCodeGenerationDataClass? openai,
            global::EdenAI.TextcodeGenerationCodeGenerationDataClass? google)
        {
            this.Xai = xai;
            this.Openai = openai;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextcodeGenerationResponseModel" /> class.
        /// </summary>
        public TextcodeGenerationResponseModel()
        {
        }

    }
}