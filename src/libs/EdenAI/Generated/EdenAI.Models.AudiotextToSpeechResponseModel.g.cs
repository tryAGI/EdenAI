
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiotextToSpeechResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Openai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevenlabs")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Elevenlabs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Amazon { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepgram")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Deepgram { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? Google { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// <param name="openai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="elevenlabs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="deepgram">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="google">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lovoai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiotextToSpeechResponseModel(
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? openai,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? elevenlabs,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? microsoft,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? amazon,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? deepgram,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? google,
            global::EdenAI.AudiotextToSpeechTextToSpeechDataClass? lovoai)
        {
            this.Openai = openai;
            this.Elevenlabs = elevenlabs;
            this.Microsoft = microsoft;
            this.Amazon = amazon;
            this.Deepgram = deepgram;
            this.Google = google;
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