
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideogenerationAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Bytedance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Minimax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="amazon"></param>
        /// <param name="bytedance"></param>
        /// <param name="openai"></param>
        /// <param name="minimax"></param>
        /// <param name="google"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideogenerationAsyncModel(
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? microsoft,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? amazon,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? bytedance,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? openai,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? minimax,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? google)
        {
            this.Microsoft = microsoft;
            this.Amazon = amazon;
            this.Bytedance = bytedance;
            this.Openai = openai;
            this.Minimax = minimax;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        public VideogenerationAsyncModel()
        {
        }
    }
}