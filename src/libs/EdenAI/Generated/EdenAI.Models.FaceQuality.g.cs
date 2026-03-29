
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Noise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exposure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Exposure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blur { get; set; }

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
        /// Initializes a new instance of the <see cref="FaceQuality" /> class.
        /// </summary>
        /// <param name="noise"></param>
        /// <param name="exposure"></param>
        /// <param name="blur"></param>
        /// <param name="brightness"></param>
        /// <param name="sharpness"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceQuality(
            int noise,
            int exposure,
            int blur,
            int brightness,
            int sharpness)
        {
            this.Noise = noise;
            this.Exposure = exposure;
            this.Blur = blur;
            this.Brightness = brightness;
            this.Sharpness = sharpness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceQuality" /> class.
        /// </summary>
        public FaceQuality()
        {
        }
    }
}