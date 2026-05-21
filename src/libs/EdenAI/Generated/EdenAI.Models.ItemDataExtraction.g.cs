
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemDataExtraction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Bounding box of a word in the image<br/>
        /// Attributes:<br/>
        ///     left (float): Left coordinate of the bounding box<br/>
        ///     top (float): Top coordinate of the bounding box<br/>
        ///     width (float): Width of the bounding box<br/>
        ///     height (float): Height of the bounding box<br/>
        ///     text (str): Text detected in the bounding box<br/>
        /// Constructor:<br/>
        ///     from_json (classmethod): Create a new instance of BoundingBox from a JSON object<br/>
        ///     from_normalized_vertices (classmethod): Create a new instance of BoundingBox from normalized vertices<br/>
        ///     unknown (classmethod): Return a invalid bouding_box with all field filled with `-1`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDataExtraction" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="boundingBox">
        /// Bounding box of a word in the image<br/>
        /// Attributes:<br/>
        ///     left (float): Left coordinate of the bounding box<br/>
        ///     top (float): Top coordinate of the bounding box<br/>
        ///     width (float): Width of the bounding box<br/>
        ///     height (float): Height of the bounding box<br/>
        ///     text (str): Text detected in the bounding box<br/>
        /// Constructor:<br/>
        ///     from_json (classmethod): Create a new instance of BoundingBox from a JSON object<br/>
        ///     from_normalized_vertices (classmethod): Create a new instance of BoundingBox from normalized vertices<br/>
        ///     unknown (classmethod): Return a invalid bouding_box with all field filled with `-1`
        /// </param>
        /// <param name="confidenceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemDataExtraction(
            string key,
            object value,
            global::EdenAI.BoundingBox boundingBox,
            int confidenceScore)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDataExtraction" /> class.
        /// </summary>
        public ItemDataExtraction()
        {
        }

    }
}