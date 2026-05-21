
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionContentCreate
    {
        /// <summary>
        /// * `success` - Success<br/>
        /// * `failed` - Failed<br/>
        /// * `processing` - Processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.ExecutionContentCreateStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ExecutionContentCreateStatusEnum Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_node_executed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastNodeExecuted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionContentCreate" /> class.
        /// </summary>
        /// <param name="status">
        /// * `success` - Success<br/>
        /// * `failed` - Failed<br/>
        /// * `processing` - Processing
        /// </param>
        /// <param name="results"></param>
        /// <param name="lastNodeExecuted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionContentCreate(
            global::EdenAI.ExecutionContentCreateStatusEnum status,
            object results,
            string lastNodeExecuted)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.LastNodeExecuted = lastNodeExecuted ?? throw new global::System.ArgumentNullException(nameof(lastNodeExecuted));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionContentCreate" /> class.
        /// </summary>
        public ExecutionContentCreate()
        {
        }

    }
}