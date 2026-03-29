
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechDiarization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_speakers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSpeakers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::EdenAI.SpeechDiarizationEntry>? Entries { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechDiarization" /> class.
        /// </summary>
        /// <param name="totalSpeakers"></param>
        /// <param name="entries"></param>
        /// <param name="errorMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechDiarization(
            int totalSpeakers,
            global::System.Collections.Generic.IList<global::EdenAI.SpeechDiarizationEntry>? entries,
            string? errorMessage)
        {
            this.TotalSpeakers = totalSpeakers;
            this.Entries = entries;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechDiarization" /> class.
        /// </summary>
        public SpeechDiarization()
        {
        }
    }
}