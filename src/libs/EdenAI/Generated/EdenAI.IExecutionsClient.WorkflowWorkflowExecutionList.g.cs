#nullable enable

namespace EdenAI
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// List Executions
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PaginatedExecutionListList> WorkflowWorkflowExecutionListAsync(
            global::System.Guid workflowId,
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}