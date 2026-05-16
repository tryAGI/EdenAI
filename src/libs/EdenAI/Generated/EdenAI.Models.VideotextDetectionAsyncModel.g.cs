
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideotextDetectionAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twelvelabs")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Twelvelabs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideotextDetectionAsyncModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="twelvelabs"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideotextDetectionAsyncModel(
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? amazon,
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? twelvelabs,
            global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass? google)
        {
            this.Amazon = amazon;
            this.Twelvelabs = twelvelabs;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideotextDetectionAsyncModel" /> class.
        /// </summary>
        public VideotextDetectionAsyncModel()
        {
        }

    }
}