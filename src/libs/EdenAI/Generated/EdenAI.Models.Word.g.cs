
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Word of a document<br/>
    /// Attributes:<br/>
    ///     text (str): Text detected in the word<br/>
    ///     bounding_boxes (Sequence[BoundingBox]): Bounding boxes of the words in the word<br/>
    ///     confidence (float): Confidence score of the word
    /// </summary>
    public sealed partial class Word
    {
        /// <summary>
        /// Text detected in the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

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
        /// Confidence score of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        /// <param name="text">
        /// Text detected in the word
        /// </param>
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
        /// <param name="confidence">
        /// Confidence score of the word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Word(
            string text,
            global::EdenAI.BoundingBox boundingBox,
            int confidence)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        public Word()
        {
        }
    }
}