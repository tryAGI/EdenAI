
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoobjectTrackingAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideoobjectTrackingAsyncObjectTrackingAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoobjectTrackingAsyncModel" /> class.
        /// </summary>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoobjectTrackingAsyncModel(
            global::EdenAI.VideoobjectTrackingAsyncObjectTrackingAsyncDataClass? google)
        {
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoobjectTrackingAsyncModel" /> class.
        /// </summary>
        public VideoobjectTrackingAsyncModel()
        {
        }
    }
}