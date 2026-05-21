
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Optional dictionary for audio-related parameters or metadata. <br/>
    /// **Example**:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "audio": {<br/>
    ///     "language": "en-US",<br/>
    ///     "transcription_format": "srt"<br/>
    ///   }<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class LlmchatllmchatChatRequestAudio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}