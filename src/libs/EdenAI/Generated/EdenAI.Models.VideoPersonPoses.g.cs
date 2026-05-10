
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoPersonPoses
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pitch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roll")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Roll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yaw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Yaw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPersonPoses" /> class.
        /// </summary>
        /// <param name="pitch"></param>
        /// <param name="roll"></param>
        /// <param name="yaw"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPersonPoses(
            int pitch,
            int roll,
            int yaw)
        {
            this.Pitch = pitch;
            this.Roll = roll;
            this.Yaw = yaw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPersonPoses" /> class.
        /// </summary>
        public VideoPersonPoses()
        {
        }

    }
}