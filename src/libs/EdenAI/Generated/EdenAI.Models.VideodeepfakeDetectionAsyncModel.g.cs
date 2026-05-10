
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideodeepfakeDetectionAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sightengine")]
        public global::EdenAI.VideodeepfakeDetectionAsyncDeepfakeDetectionAsyncDataClass? Sightengine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideodeepfakeDetectionAsyncModel" /> class.
        /// </summary>
        /// <param name="sightengine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideodeepfakeDetectionAsyncModel(
            global::EdenAI.VideodeepfakeDetectionAsyncDeepfakeDetectionAsyncDataClass? sightengine)
        {
            this.Sightengine = sightengine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideodeepfakeDetectionAsyncModel" /> class.
        /// </summary>
        public VideodeepfakeDetectionAsyncModel()
        {
        }

    }
}