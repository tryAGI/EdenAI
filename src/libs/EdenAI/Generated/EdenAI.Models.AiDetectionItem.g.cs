
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiDetectionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AiScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_score_detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AiScoreDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="prediction"></param>
        /// <param name="aiScore"></param>
        /// <param name="aiScoreDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiDetectionItem(
            string text,
            string prediction,
            int aiScore,
            int aiScoreDetail)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Prediction = prediction ?? throw new global::System.ArgumentNullException(nameof(prediction));
            this.AiScore = aiScore;
            this.AiScoreDetail = aiScoreDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionItem" /> class.
        /// </summary>
        public AiDetectionItem()
        {
        }

    }
}