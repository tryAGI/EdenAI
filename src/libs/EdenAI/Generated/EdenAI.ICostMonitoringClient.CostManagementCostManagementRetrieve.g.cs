#nullable enable

namespace EdenAI
{
    public partial interface ICostMonitoringClient
    {
        /// <summary>
        /// Monitor Consumptions<br/>
        /// Returns aggregated consumption over time.<br/>
        /// Only `feature`, `subfeature`, `provider`, and `phase` are accepted as row filters; any other unknown query parameter returns 400.<br/>
        /// Results are scoped by the caller's role: an organization owner or a member with members:manage sees the whole organization and may narrow with `user`, `token` or `group_by=user`; a regular member always sees only their own consumption and receives 403 if it sends `user` or `group_by=user`.<br/>
        /// `token` matches by key NAME, not by key identity. Names are unique per user and only among non-revoked keys, so a name shared by several members of the organization aggregates all of them, and a name reused after a rotation also includes the rotated-out key's history. Use `base_token` to select consumption not attributed to any key.
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
        /// <summary>
        /// Monitor Consumptions<br/>
        /// Returns aggregated consumption over time.<br/>
        /// Only `feature`, `subfeature`, `provider`, and `phase` are accepted as row filters; any other unknown query parameter returns 400.<br/>
        /// Results are scoped by the caller's role: an organization owner or a member with members:manage sees the whole organization and may narrow with `user`, `token` or `group_by=user`; a regular member always sees only their own consumption and receives 403 if it sends `user` or `group_by=user`.<br/>
        /// `token` matches by key NAME, not by key identity. Names are unique per user and only among non-revoked keys, so a name shared by several members of the organization aggregates all of them, and a name reused after a rotation also includes the rotated-out key's history. Use `base_token` to select consumption not attributed to any key.
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
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.CostMonitoringResponse>> CostManagementCostManagementRetrieveAsResponseAsync(
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