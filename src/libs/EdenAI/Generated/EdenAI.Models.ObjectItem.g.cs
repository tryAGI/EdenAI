
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int XMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int XMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int YMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int YMax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectItem" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="confidence"></param>
        /// <param name="xMin"></param>
        /// <param name="xMax"></param>
        /// <param name="yMin"></param>
        /// <param name="yMax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectItem(
            string label,
            int confidence,
            int xMin,
            int xMax,
            int yMin,
            int yMax)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Confidence = confidence;
            this.XMin = xMin;
            this.XMax = xMax;
            this.YMin = yMin;
            this.YMax = yMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectItem" /> class.
        /// </summary>
        public ObjectItem()
        {
        }
    }
}