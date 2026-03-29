
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideodeepfakeDetectionAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// <param name="sightengine">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
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