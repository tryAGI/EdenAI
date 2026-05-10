
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// * `succeeded` - Status Succeeded<br/>
        /// * `failed` - Status Failed<br/>
        /// * `finished` - Status Finished<br/>
        /// * `processing` - Status Processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.Status889EnumJsonConverter))]
        public global::EdenAI.Status889Enum? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        public string Feature { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("subfeature")]
        public string Subfeature { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        public int TotalRequests { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_processing")]
        public int NbProcessing { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_succeeded")]
        public int NbSucceeded { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_failed")]
        public int NbFailed { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_response_url")]
        public string GetResponseUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchList" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="status">
        /// * `succeeded` - Status Succeeded<br/>
        /// * `failed` - Status Failed<br/>
        /// * `finished` - Status Finished<br/>
        /// * `processing` - Status Processing
        /// </param>
        /// <param name="feature">
        /// Included only in responses
        /// </param>
        /// <param name="subfeature">
        /// Included only in responses
        /// </param>
        /// <param name="totalRequests">
        /// Included only in responses
        /// </param>
        /// <param name="nbProcessing">
        /// Included only in responses
        /// </param>
        /// <param name="nbSucceeded">
        /// Included only in responses
        /// </param>
        /// <param name="nbFailed">
        /// Included only in responses
        /// </param>
        /// <param name="getResponseUrl">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchList(
            string? name,
            global::EdenAI.Status889Enum? status,
            string feature = default!,
            string subfeature = default!,
            int totalRequests = default!,
            int nbProcessing = default!,
            int nbSucceeded = default!,
            int nbFailed = default!,
            string getResponseUrl = default!)
        {
            this.Name = name;
            this.Status = status;
            this.Feature = feature;
            this.Subfeature = subfeature;
            this.TotalRequests = totalRequests;
            this.NbProcessing = nbProcessing;
            this.NbSucceeded = nbSucceeded;
            this.NbFailed = nbFailed;
            this.GetResponseUrl = getResponseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchList" /> class.
        /// </summary>
        public BatchList()
        {
        }

    }
}