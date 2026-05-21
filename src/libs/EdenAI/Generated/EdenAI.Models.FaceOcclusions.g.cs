
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceOcclusions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_occluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EyeOccluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forehead_occluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForeheadOccluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_occluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MouthOccluded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceOcclusions" /> class.
        /// </summary>
        /// <param name="eyeOccluded"></param>
        /// <param name="foreheadOccluded"></param>
        /// <param name="mouthOccluded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceOcclusions(
            bool eyeOccluded,
            bool foreheadOccluded,
            bool mouthOccluded)
        {
            this.EyeOccluded = eyeOccluded;
            this.ForeheadOccluded = foreheadOccluded;
            this.MouthOccluded = mouthOccluded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceOcclusions" /> class.
        /// </summary>
        public FaceOcclusions()
        {
        }

    }
}