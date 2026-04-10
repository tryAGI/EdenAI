#nullable enable

namespace EdenAI
{
    public partial interface ICostMonitoringClient
    {
        /// <summary>
        /// Monitor Consumptions
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="provider"></param>
        /// <param name="ragProjectId"></param>
        /// <param name="step"></param>
        /// <param name="subfeature"></param>
        /// <param name="token"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CostMonitoringResponse> CostManagementCostManagementRetrieveAsync(
            global::System.DateTime begin,
            global::System.DateTime end,
            int step,
            string? provider = default,
            global::System.Guid? ragProjectId = default,
            string? subfeature = default,
            string? token = default,
            global::System.Guid? workflowId = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}