
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoquestionAnswerResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideoquestionAnswerQuestionAnswerDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideoquestionAnswerQuestionAnswerDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoquestionAnswerResponseModel" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoquestionAnswerResponseModel(
            global::EdenAI.VideoquestionAnswerQuestionAnswerDataClass? google,
            global::EdenAI.VideoquestionAnswerQuestionAnswerDataClass? amazon)
        {
            this.Google = google;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoquestionAnswerResponseModel" /> class.
        /// </summary>
        public VideoquestionAnswerResponseModel()
        {
        }
    }
}