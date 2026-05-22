
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagequestionAnswerResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alephalpha")]
        public global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? Alephalpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagequestionAnswerResponseModel" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="alephalpha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagequestionAnswerResponseModel(
            global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? google,
            global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? openai,
            global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass? alephalpha)
        {
            this.Google = google;
            this.Openai = openai;
            this.Alephalpha = alephalpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagequestionAnswerResponseModel" /> class.
        /// </summary>
        public ImagequestionAnswerResponseModel()
        {
        }

    }
}