
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Optional params override. If not provided, the default params in the prompt will be used<br/>
    /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
    /// #### Example<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "temperature": 0.7,<br/>
    ///   "max_tokens": 100<br/>
    /// }<br/>
    /// ```<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class PromptCallRequestParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}