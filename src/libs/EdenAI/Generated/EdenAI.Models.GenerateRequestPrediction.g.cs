
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Optional field for storing prediction-related information. <br/>
    /// Flexible dictionary to capture model's predictive metadata. <br/>
    /// **Example**:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "prediction": {<br/>
    ///     "confidence_score": 0.85,<br/>
    ///     "top_prediction": "response_category"<br/>
    ///   }<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class GenerateRequestPrediction
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}