
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
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Amazon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pixverse")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Pixverse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Bytedance { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Minimax { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pruna")]
        public global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? Pruna { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="pixverse"></param>
        /// <param name="bytedance"></param>
        /// <param name="google"></param>
        /// <param name="openai"></param>
        /// <param name="minimax"></param>
        /// <param name="microsoft"></param>
        /// <param name="pruna"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideogenerationAsyncModel(
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? amazon,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? pixverse,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? bytedance,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? google,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? openai,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? minimax,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? microsoft,
            global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass? pruna)
        {
            this.Amazon = amazon;
            this.Pixverse = pixverse;
            this.Bytedance = bytedance;
            this.Google = google;
            this.Openai = openai;
            this.Minimax = minimax;
            this.Microsoft = microsoft;
            this.Pruna = pruna;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideogenerationAsyncModel" /> class.
        /// </summary>
        public VideogenerationAsyncModel()
        {
        }

    }
}