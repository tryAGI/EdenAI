
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrocrTablesAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrTablesAsyncModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrocrTablesAsyncModel(
            global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? amazon,
            global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? microsoft,
            global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass? google)
        {
            this.Amazon = amazon;
            this.Microsoft = microsoft;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrTablesAsyncModel" /> class.
        /// </summary>
        public OcrocrTablesAsyncModel()
        {
        }

    }
}