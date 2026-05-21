
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LandmarkLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lat_lng")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.LandmarkLatLng LatLng { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkLocation" /> class.
        /// </summary>
        /// <param name="latLng"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LandmarkLocation(
            global::EdenAI.LandmarkLatLng latLng)
        {
            this.LatLng = latLng ?? throw new global::System.ArgumentNullException(nameof(latLng));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkLocation" /> class.
        /// </summary>
        public LandmarkLocation()
        {
        }

    }
}