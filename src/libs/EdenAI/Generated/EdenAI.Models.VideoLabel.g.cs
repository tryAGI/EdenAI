
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.Collections.Generic.IList<global::EdenAI.VideoLabelTimeStamp>? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::System.Collections.Generic.IList<string>? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::System.Collections.Generic.IList<global::EdenAI.VideoLabelBoundingBox>? BoundingBox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="confidence"></param>
        /// <param name="timestamp"></param>
        /// <param name="category"></param>
        /// <param name="boundingBox"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoLabel(
            string name,
            int confidence,
            global::System.Collections.Generic.IList<global::EdenAI.VideoLabelTimeStamp>? timestamp,
            global::System.Collections.Generic.IList<string>? category,
            global::System.Collections.Generic.IList<global::EdenAI.VideoLabelBoundingBox>? boundingBox)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Confidence = confidence;
            this.Timestamp = timestamp;
            this.Category = category;
            this.BoundingBox = boundingBox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoLabel" /> class.
        /// </summary>
        public VideoLabel()
        {
        }
    }
}