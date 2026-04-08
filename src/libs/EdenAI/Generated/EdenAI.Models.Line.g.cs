
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Line of a document<br/>
    /// Attributes:<br/>
    ///     text (str): Text detected in the line<br/>
    ///     bounding_boxes (Sequence[BoundingBox]): Bounding boxes of the words in the line<br/>
    ///     words (Sequence[Word]): List of words of the line<br/>
    ///     confidence (float): Confidence of the line
    /// </summary>
    public sealed partial class Line
    {
        /// <summary>
        /// Text detected in the line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// List of words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::EdenAI.Word>? Words { get; set; }

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
        public global::EdenAI.BoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// Confidence of the line
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
        /// Initializes a new instance of the <see cref="Line" /> class.
        /// </summary>
        /// <param name="text">
        /// Text detected in the line
        /// </param>
        /// <param name="confidence">
        /// Confidence of the line
        /// </param>
        /// <param name="words">
        /// List of words
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Line(
            string text,
            int confidence,
            global::System.Collections.Generic.IList<global::EdenAI.Word>? words,
            global::EdenAI.BoundingBox? boundingBox)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words;
            this.BoundingBox = boundingBox;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line" /> class.
        /// </summary>
        public Line()
        {
        }
    }
}