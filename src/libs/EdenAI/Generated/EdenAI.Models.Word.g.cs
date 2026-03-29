
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
        /// Bounding boxes of the words in the word
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
        /// Bounding boxes of the words in the word
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