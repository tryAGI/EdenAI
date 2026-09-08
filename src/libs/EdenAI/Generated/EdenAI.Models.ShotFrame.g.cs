
#nullable enable

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShotFrame
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeOffset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimeOffset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeOffset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTimeOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotFrame" /> class.
        /// </summary>
        /// <param name="startTimeOffset"></param>
        /// <param name="endTimeOffset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShotFrame(
            double startTimeOffset,
            double endTimeOffset)
        {
            this.StartTimeOffset = startTimeOffset;
            this.EndTimeOffset = endTimeOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotFrame" /> class.
        /// </summary>
        public ShotFrame()
        {
        }

    }
}