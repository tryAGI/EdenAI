
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideologoDetectionAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twelvelabs")]
        public global::EdenAI.VideologoDetectionAsyncLogoDetectionAsyncDataClass? Twelvelabs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideologoDetectionAsyncLogoDetectionAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideologoDetectionAsyncModel" /> class.
        /// </summary>
        /// <param name="twelvelabs"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideologoDetectionAsyncModel(
            global::EdenAI.VideologoDetectionAsyncLogoDetectionAsyncDataClass? twelvelabs,
            global::EdenAI.VideologoDetectionAsyncLogoDetectionAsyncDataClass? google)
        {
            this.Twelvelabs = twelvelabs;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideologoDetectionAsyncModel" /> class.
        /// </summary>
        public VideologoDetectionAsyncModel()
        {
        }
    }
}