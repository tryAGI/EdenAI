
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagedeepfakeDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resemble")]
        public global::EdenAI.ImagedeepfakeDetectionDeepfakeDetectionDataClass? Resemble { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sightengine")]
        public global::EdenAI.ImagedeepfakeDetectionDeepfakeDetectionDataClass? Sightengine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagedeepfakeDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="resemble"></param>
        /// <param name="sightengine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagedeepfakeDetectionResponseModel(
            global::EdenAI.ImagedeepfakeDetectionDeepfakeDetectionDataClass? resemble,
            global::EdenAI.ImagedeepfakeDetectionDeepfakeDetectionDataClass? sightengine)
        {
            this.Resemble = resemble;
            this.Sightengine = sightengine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagedeepfakeDetectionResponseModel" /> class.
        /// </summary>
        public ImagedeepfakeDetectionResponseModel()
        {
        }

    }
}