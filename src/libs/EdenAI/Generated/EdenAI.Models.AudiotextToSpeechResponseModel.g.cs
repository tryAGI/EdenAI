
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiotextToSpeechResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepgram")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Deepgram { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevenlabs")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Elevenlabs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lovoai")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Lovoai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechResponseModel" /> class.
        /// </summary>
        /// <param name="deepgram"></param>
        /// <param name="openai"></param>
        /// <param name="google"></param>
        /// <param name="amazon"></param>
        /// <param name="elevenlabs"></param>
        /// <param name="microsoft"></param>
        /// <param name="lovoai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiotextToSpeechResponseModel(
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? deepgram,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? openai,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? google,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? amazon,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? elevenlabs,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? microsoft,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? lovoai)
        {
            this.Deepgram = deepgram;
            this.Openai = openai;
            this.Google = google;
            this.Amazon = amazon;
            this.Elevenlabs = elevenlabs;
            this.Microsoft = microsoft;
            this.Lovoai = lovoai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechResponseModel" /> class.
        /// </summary>
        public AudiotextToSpeechResponseModel()
        {
        }

    }
}