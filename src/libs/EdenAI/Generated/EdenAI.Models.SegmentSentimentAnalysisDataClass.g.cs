
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// This class is used in SentimentAnalysisDataClass to describe each segment analyzed.<br/>
    /// Args:<br/>
    ///     - segment (str): The segment analyzed<br/>
    ///     - sentiment (Literal['Positve', 'Negative', 'Neutral']) (Case is ignore): Sentiment of segment<br/>
    ///     - sentiment_rate (float between 0 and 1): Rate of sentiment
    /// </summary>
    public sealed partial class SegmentSentimentAnalysisDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Segment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.SentimentEbfEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.SentimentEbfEnum Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentimentRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSentimentAnalysisDataClass" /> class.
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="sentiment"></param>
        /// <param name="sentimentRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentSentimentAnalysisDataClass(
            string segment,
            global::EdenAI.SentimentEbfEnum sentiment,
            int sentimentRate)
        {
            this.Segment = segment ?? throw new global::System.ArgumentNullException(nameof(segment));
            this.Sentiment = sentiment;
            this.SentimentRate = sentimentRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSentimentAnalysisDataClass" /> class.
        /// </summary>
        public SegmentSentimentAnalysisDataClass()
        {
        }
    }
}