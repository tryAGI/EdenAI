
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoFace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.VideoBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceAttributes Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landmarks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.LandmarksVideo Landmarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFace" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="boundingBox"></param>
        /// <param name="attributes"></param>
        /// <param name="landmarks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFace(
            int offset,
            global::EdenAI.VideoBoundingBox boundingBox,
            global::EdenAI.FaceAttributes attributes,
            global::EdenAI.LandmarksVideo landmarks)
        {
            this.Offset = offset;
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Landmarks = landmarks ?? throw new global::System.ArgumentNullException(nameof(landmarks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFace" /> class.
        /// </summary>
        public VideoFace()
        {
        }
    }
}