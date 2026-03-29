
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Entity
    {
        /// <summary>
        /// Recognized Entity type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Text corresponding to the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.EntitySentimentEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.EntitySentimentEnum Sentiment { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_offset")]
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        public int? EndOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="type">
        /// Recognized Entity type
        /// </param>
        /// <param name="text">
        /// Text corresponding to the entity
        /// </param>
        /// <param name="sentiment"></param>
        /// <param name="beginOffset">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endOffset">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Entity(
            string type,
            string text,
            global::EdenAI.EntitySentimentEnum sentiment,
            int? beginOffset,
            int? endOffset)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Sentiment = sentiment;
            this.BeginOffset = beginOffset;
            this.EndOffset = endOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        public Entity()
        {
        }
    }
}