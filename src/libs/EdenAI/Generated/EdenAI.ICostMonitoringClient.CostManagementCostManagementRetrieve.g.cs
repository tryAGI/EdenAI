#nullable enable

namespace EdenAI
{
    public partial interface ICostMonitoringClient
    {
        /// <summary>
        /// Monitor Consumptions<br/>
        /// Returns aggregated consumption over time.<br/>
        /// Only `feature`, `subfeature`, `provider`, and `phase` are accepted as row filters; any other unknown query parameter returns 400.<br/>
        /// When called with a custom API key, results are automatically scoped to that token — the `user`, `token`, and `group_by=user` query parameters are not allowed and return 400/403.
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="groupBy"></param>
        /// <param name="provider"></param>
        /// <param name="ragProjectId"></param>
        /// <param name="step"></param>
        /// <param name="subfeature"></param>
        /// <param name="token"></param>
        /// <param name="user"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CostMonitoringResponse> CostManagementCostManagementRetrieveAsync(
            global::System.DateTime begin,
            global::System.DateTime end,
            int step,
            global::EdenAI.CostManagementCostManagementRetrieveGroupBy? groupBy = default,
            string? provider = default,
            global::System.Guid? ragProjectId = default,
            string? subfeature = default,
            string? token = default,
            string? user = default,
            global::System.Guid? workflowId = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}