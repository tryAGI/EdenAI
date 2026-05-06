
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiospeechToTextAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gladia")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Gladia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symbl")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Symbl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faker")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Faker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assembly")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Assembly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voxist")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Voxist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepgram")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Deepgram { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voci")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Voci { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechmatics")]
        public global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? Speechmatics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiospeechToTextAsyncModel" /> class.
        /// </summary>
        /// <param name="gladia"></param>
        /// <param name="symbl"></param>
        /// <param name="google"></param>
        /// <param name="faker"></param>
        /// <param name="assembly"></param>
        /// <param name="microsoft"></param>
        /// <param name="voxist"></param>
        /// <param name="oneai"></param>
        /// <param name="deepgram"></param>
        /// <param name="openai"></param>
        /// <param name="voci"></param>
        /// <param name="amazon"></param>
        /// <param name="speechmatics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiospeechToTextAsyncModel(
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? gladia,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? symbl,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? google,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? faker,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? assembly,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? microsoft,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? voxist,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? oneai,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? deepgram,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? openai,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? voci,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? amazon,
            global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass? speechmatics)
        {
            this.Gladia = gladia;
            this.Symbl = symbl;
            this.Google = google;
            this.Faker = faker;
            this.Assembly = assembly;
            this.Microsoft = microsoft;
            this.Voxist = voxist;
            this.Oneai = oneai;
            this.Deepgram = deepgram;
            this.Openai = openai;
            this.Voci = voci;
            this.Amazon = amazon;
            this.Speechmatics = speechmatics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiospeechToTextAsyncModel" /> class.
        /// </summary>
        public AudiospeechToTextAsyncModel()
        {
        }
    }
}