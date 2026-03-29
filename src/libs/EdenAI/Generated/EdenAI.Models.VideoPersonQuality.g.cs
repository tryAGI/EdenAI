
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoPersonQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brightness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Brightness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sharpness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPersonQuality" /> class.
        /// </summary>
        /// <param name="brightness"></param>
        /// <param name="sharpness"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPersonQuality(
            int brightness,
            int sharpness)
        {
            this.Brightness = brightness;
            this.Sharpness = sharpness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPersonQuality" /> class.
        /// </summary>
        public VideoPersonQuality()
        {
        }
    }
}