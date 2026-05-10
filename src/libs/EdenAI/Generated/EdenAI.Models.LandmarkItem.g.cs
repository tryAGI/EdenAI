
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LandmarkItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::System.Collections.Generic.IList<global::EdenAI.LandmarkVertice>? BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<global::EdenAI.LandmarkLocation>? Locations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkItem" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="confidence"></param>
        /// <param name="boundingBox"></param>
        /// <param name="locations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LandmarkItem(
            string description,
            int confidence,
            global::System.Collections.Generic.IList<global::EdenAI.LandmarkVertice>? boundingBox,
            global::System.Collections.Generic.IList<global::EdenAI.LandmarkLocation>? locations)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Confidence = confidence;
            this.BoundingBox = boundingBox;
            this.Locations = locations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkItem" /> class.
        /// </summary>
        public LandmarkItem()
        {
        }

    }
}