
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<global::EdenAI.ObjectFrame>? Frames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTrack" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="confidence"></param>
        /// <param name="frames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectTrack(
            string description,
            int confidence,
            global::System.Collections.Generic.IList<global::EdenAI.ObjectFrame>? frames)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Confidence = confidence;
            this.Frames = frames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTrack" /> class.
        /// </summary>
        public ObjectTrack()
        {
        }
    }
}