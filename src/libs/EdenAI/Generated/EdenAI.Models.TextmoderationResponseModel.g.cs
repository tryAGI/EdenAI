
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextmoderationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextmoderationModerationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextmoderationModerationDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextmoderationModerationDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationResponseModel" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextmoderationResponseModel(
            global::EdenAI.TextmoderationModerationDataClass? openai,
            global::EdenAI.TextmoderationModerationDataClass? microsoft,
            global::EdenAI.TextmoderationModerationDataClass? google)
        {
            this.Openai = openai;
            this.Microsoft = microsoft;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationResponseModel" /> class.
        /// </summary>
        public TextmoderationResponseModel()
        {
        }
    }
}