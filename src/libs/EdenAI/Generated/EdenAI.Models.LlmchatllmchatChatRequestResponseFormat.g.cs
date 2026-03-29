
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Specify the desired response format for the completion. <br/>
    /// **Example**:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "response_format": {<br/>
    ///     "type": "json_object",<br/>
    ///     "schema": {...}<br/>
    ///   }<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class LlmchatllmchatChatRequestResponseFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}