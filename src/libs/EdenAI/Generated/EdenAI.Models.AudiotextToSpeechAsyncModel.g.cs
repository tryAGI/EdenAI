
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiotextToSpeechAsyncModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lovoai")]
        public global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? Lovoai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechAsyncModel" /> class.
        /// </summary>
        /// <param name="lovoai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amazon">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiotextToSpeechAsyncModel(
            global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? lovoai,
            global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? amazon)
        {
            this.Lovoai = lovoai;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechAsyncModel" /> class.
        /// </summary>
        public AudiotextToSpeechAsyncModel()
        {
        }
    }
}