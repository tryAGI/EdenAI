
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnonymizationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_boxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.AnonymizationBoundingBox BoundingBoxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationItem" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="confidence"></param>
        /// <param name="boundingBoxes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnonymizationItem(
            string kind,
            int confidence,
            global::EdenAI.AnonymizationBoundingBox boundingBoxes)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Confidence = confidence;
            this.BoundingBoxes = boundingBoxes ?? throw new global::System.ArgumentNullException(nameof(boundingBoxes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationItem" /> class.
        /// </summary>
        public AnonymizationItem()
        {
        }
    }
}