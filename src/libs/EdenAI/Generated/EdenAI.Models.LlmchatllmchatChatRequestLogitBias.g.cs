
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Modify the likelihood of specific tokens appearing in the response. <br/>
    /// A dictionary where keys are token IDs and values are bias scores. <br/>
    /// **Example**:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "logit_bias": {<br/>
    ///     "50256": -100,  # Reduce probability of end-of-text token<br/>
    ///     "15": 5  # Slightly increase probability of a specific token<br/>
    ///   }<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class LlmchatllmchatChatRequestLogitBias
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}