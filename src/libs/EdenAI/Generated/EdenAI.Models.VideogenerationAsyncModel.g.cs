
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
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Minimax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Bytedance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        /// <param name="minimax"></param>
        /// <param name="amazon"></param>
        /// <param name="microsoft"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="bytedance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideogenerationAsyncModel(
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? minimax,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? amazon,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? microsoft,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? google,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? openai,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? bytedance)
        {
            this.Minimax = minimax;
            this.Amazon = amazon;
            this.Microsoft = microsoft;
            this.Google = google;
            this.Openai = openai;
            this.Bytedance = bytedance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        public VideogenerationAsyncModel()
        {
        }
    }
}