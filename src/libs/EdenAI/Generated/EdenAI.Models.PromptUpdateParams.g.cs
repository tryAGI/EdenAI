
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
    /// #### Example<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "temperature": 0.7,<br/>
    ///   "max_tokens": 100<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class PromptUpdateParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}