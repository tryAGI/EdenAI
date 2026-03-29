
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlagiaDetectionCandidate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plagia_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlagiaScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plagiarized_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlagiarizedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlagiaDetectionCandidate" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="plagiaScore"></param>
        /// <param name="prediction"></param>
        /// <param name="plagiarizedText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlagiaDetectionCandidate(
            string url,
            int plagiaScore,
            string prediction,
            string plagiarizedText)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PlagiaScore = plagiaScore;
            this.Prediction = prediction ?? throw new global::System.ArgumentNullException(nameof(prediction));
            this.PlagiarizedText = plagiarizedText ?? throw new global::System.ArgumentNullException(nameof(plagiarizedText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlagiaDetectionCandidate" /> class.
        /// </summary>
        public PlagiaDetectionCandidate()
        {
        }
    }
}