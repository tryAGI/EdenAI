
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Options for web search integration. <br/>
    ///         **Example**:<br/>
    ///         ```json<br/>
    ///         web_search_options={<br/>
    ///             "search_context_size": "medium"  # Options: "low", "medium", "high"<br/>
    ///         }<br/>
    ///         ```
    /// </summary>
    public sealed partial class GenerateRequestWebSearchOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}