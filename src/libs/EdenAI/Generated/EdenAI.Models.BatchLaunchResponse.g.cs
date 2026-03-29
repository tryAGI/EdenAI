
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchLaunchResponse
    {
        /// <summary>
        /// Job ID/name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Number of successfully launched requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_launched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbLaunched { get; set; }

        /// <summary>
        /// Number of failed_requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbFailed { get; set; }

        /// <summary>
        /// Total number of requests sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// if any requests failed, they will be shown in this list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EdenAI.BatchLaunchFailedRequest> FailedRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLaunchResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Job ID/name
        /// </param>
        /// <param name="nbLaunched">
        /// Number of successfully launched requests
        /// </param>
        /// <param name="nbFailed">
        /// Number of failed_requests
        /// </param>
        /// <param name="total">
        /// Total number of requests sent
        /// </param>
        /// <param name="failedRequests">
        /// if any requests failed, they will be shown in this list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchLaunchResponse(
            string jobId,
            int nbLaunched,
            int nbFailed,
            int total,
            global::System.Collections.Generic.IList<global::EdenAI.BatchLaunchFailedRequest> failedRequests)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.NbLaunched = nbLaunched;
            this.NbFailed = nbFailed;
            this.Total = total;
            this.FailedRequests = failedRequests ?? throw new global::System.ArgumentNullException(nameof(failedRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLaunchResponse" /> class.
        /// </summary>
        public BatchLaunchResponse()
        {
        }
    }
}