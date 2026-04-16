
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudiotextToSpeechAsyncModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lovoai")]
        public global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? Lovoai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechAsyncModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="lovoai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudiotextToSpeechAsyncModel(
            global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? amazon,
            global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass? lovoai)
        {
            this.Amazon = amazon;
            this.Lovoai = lovoai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudiotextToSpeechAsyncModel" /> class.
        /// </summary>
        public AudiotextToSpeechAsyncModel()
        {
        }
    }
}