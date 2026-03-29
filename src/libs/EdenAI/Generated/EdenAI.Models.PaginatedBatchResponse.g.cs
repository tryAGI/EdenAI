
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedBatchResponse
    {
        /// <summary>
        /// Total requests made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastPage { get; set; }

        /// <summary>
        /// Number of requests per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("From")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_page_url")]
        public string? PrevPageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_url")]
        public string? NextPageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EdenAI.BatchResponseRequest> Requests { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.DateTime Updated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedBatchResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total requests made
        /// </param>
        /// <param name="currentPage">
        /// Current page number
        /// </param>
        /// <param name="lastPage"></param>
        /// <param name="perPage">
        /// Number of requests per page
        /// </param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requests"></param>
        /// <param name="prevPageUrl"></param>
        /// <param name="nextPageUrl"></param>
        /// <param name="status">
        /// * `succeeded` - Status Succeeded<br/>
        /// * `failed` - Status Failed<br/>
        /// * `finished` - Status Finished<br/>
        /// * `processing` - Status Processing
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedBatchResponse(
            int total,
            int currentPage,
            int lastPage,
            int perPage,
            int from,
            int to,
            global::System.Collections.Generic.IList<global::EdenAI.BatchResponseRequest> requests,
            string? prevPageUrl,
            string? nextPageUrl,
            global::EdenAI.Status889Enum? status,
            global::System.DateTime created = default!,
            global::System.DateTime updated = default!)
        {
            this.Total = total;
            this.CurrentPage = currentPage;
            this.LastPage = lastPage;
            this.PerPage = perPage;
            this.From = from;
            this.To = to;
            this.PrevPageUrl = prevPageUrl;
            this.NextPageUrl = nextPageUrl;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Status = status;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedBatchResponse" /> class.
        /// </summary>
        public PaginatedBatchResponse()
        {
        }
    }
}