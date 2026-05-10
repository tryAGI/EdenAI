
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Additional configuration for streaming responses. <br/>
    /// **Example**:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "stream_options": {<br/>
    ///     "include_usage": true<br/>
    ///   }<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class LlmchatllmchatChatRequestStreamOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}