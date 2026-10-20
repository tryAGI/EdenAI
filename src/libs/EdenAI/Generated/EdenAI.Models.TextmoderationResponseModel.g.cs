
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
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.TextmoderationModerationDataClass? Google { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextmoderationModerationDataClass? Microsoft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ovhcloud")]
        public global::EdenAI.TextmoderationModerationDataClass? Ovhcloud { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationResponseModel" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="google"></param>
        /// <param name="microsoft"></param>
        /// <param name="ovhcloud"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextmoderationResponseModel(
            global::EdenAI.TextmoderationModerationDataClass? openai,
            global::EdenAI.TextmoderationModerationDataClass? google,
            global::EdenAI.TextmoderationModerationDataClass? microsoft,
            global::EdenAI.TextmoderationModerationDataClass? ovhcloud)
        {
            this.Openai = openai;
            this.Google = google;
            this.Microsoft = microsoft;
            this.Ovhcloud = ovhcloud;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationResponseModel" /> class.
        /// </summary>
        public TextmoderationResponseModel()
        {
        }

    }
}