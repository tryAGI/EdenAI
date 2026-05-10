
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiospeechToTextAsyncSpeechToTextAsyncDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.SpeechDiarization Diarization { get; set; }

        /// <summary>
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_response")]
        public object? OriginalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.FinalStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinalStatusEnum FinalStatus { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiospeechToTextAsyncSpeechToTextAsyncDataClass" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="diarization"></param>
        /// <param name="id"></param>
        /// <param name="finalStatus"></param>
        /// <param name="originalResponse">
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="error">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiospeechToTextAsyncSpeechToTextAsyncDataClass(
            string text,
            global::EdenAI.SpeechDiarization diarization,
            string id,
            global::EdenAI.FinalStatusEnum finalStatus,
            object? originalResponse,
            object? error)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Diarization = diarization ?? throw new global::System.ArgumentNullException(nameof(diarization));
            this.OriginalResponse = originalResponse;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FinalStatus = finalStatus;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiospeechToTextAsyncSpeechToTextAsyncDataClass" /> class.
        /// </summary>
        public AudiospeechToTextAsyncSpeechToTextAsyncDataClass()
        {
        }

    }
}