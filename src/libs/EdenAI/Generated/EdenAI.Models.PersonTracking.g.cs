
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonTracking
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
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::EdenAI.PersonAttributes? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landmarks")]
        public global::EdenAI.PersonLandmarks? Landmarks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poses")]
        public global::EdenAI.VideoPersonPoses? Poses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::EdenAI.VideoPersonQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.VideoTrackingBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonTracking" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="boundingBox"></param>
        /// <param name="attributes"></param>
        /// <param name="landmarks"></param>
        /// <param name="poses"></param>
        /// <param name="quality"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonTracking(
            int offset,
            global::EdenAI.VideoTrackingBoundingBox boundingBox,
            global::EdenAI.PersonAttributes? attributes,
            global::EdenAI.PersonLandmarks? landmarks,
            global::EdenAI.VideoPersonPoses? poses,
            global::EdenAI.VideoPersonQuality? quality)
        {
            this.Offset = offset;
            this.Attributes = attributes;
            this.Landmarks = landmarks;
            this.Poses = poses;
            this.Quality = quality;
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonTracking" /> class.
        /// </summary>
        public PersonTracking()
        {
        }

    }
}