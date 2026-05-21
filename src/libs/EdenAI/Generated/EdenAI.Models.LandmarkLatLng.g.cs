
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LandmarkLatLng
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Longitude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkLatLng" /> class.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LandmarkLatLng(
            int latitude,
            int longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarkLatLng" /> class.
        /// </summary>
        public LandmarkLatLng()
        {
        }

    }
}