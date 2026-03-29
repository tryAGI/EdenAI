#nullable enable

namespace EdenAI
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Delete a Workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task WorkflowWorkflowDestroyAsync(
            global::System.Guid workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}