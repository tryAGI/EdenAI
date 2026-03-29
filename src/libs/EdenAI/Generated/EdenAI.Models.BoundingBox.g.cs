
#nullable enable

namespace EdenAI
{
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
    public sealed partial class BoundingBox
    {
        /// <summary>
        /// Left coordinate of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Left { get; set; }

        /// <summary>
        /// Top coordinate of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Top { get; set; }

        /// <summary>
        /// Width of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        /// <param name="left">
        /// Left coordinate of the bounding box
        /// </param>
        /// <param name="top">
        /// Top coordinate of the bounding box
        /// </param>
        /// <param name="width">
        /// Width of the bounding box
        /// </param>
        /// <param name="height">
        /// Height of the bounding box
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoundingBox(
            int left,
            int top,
            int width,
            int height)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        public BoundingBox()
        {
        }
    }
}