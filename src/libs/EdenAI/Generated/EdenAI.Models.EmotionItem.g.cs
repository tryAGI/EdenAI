
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// This class is used in EmotionAnalysisDataClass to list emotion analysed.<br/>
    /// Args:<br/>
    ///     - emotion (EmotionEnum): emotion of the text<br/>
    ///     - emotion_score (float): score of the emotion
    /// </summary>
    public sealed partial class EmotionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmotionScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionItem" /> class.
        /// </summary>
        /// <param name="emotion"></param>
        /// <param name="emotionScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmotionItem(
            string emotion,
            int emotionScore)
        {
            this.Emotion = emotion ?? throw new global::System.ArgumentNullException(nameof(emotion));
            this.EmotionScore = emotionScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionItem" /> class.
        /// </summary>
        public EmotionItem()
        {
        }
    }
}