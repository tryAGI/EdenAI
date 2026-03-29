
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class YodaQueryResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.YodaQueryResponsePayload Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaQueryResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="score"></param>
        /// <param name="payload"></param>
        /// <param name="vector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public YodaQueryResponseItem(
            global::System.Guid id,
            int version,
            int score,
            global::EdenAI.YodaQueryResponsePayload payload,
            object vector)
        {
            this.Id = id;
            this.Version = version;
            this.Score = score;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaQueryResponseItem" /> class.
        /// </summary>
        public YodaQueryResponseItem()
        {
        }
    }
}