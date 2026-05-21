#nullable enable

namespace EdenAI
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Retrieve a Workflow<br/>
        /// Get workflow Content (JSON representation)
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.Workflow> WorkflowWorkflowRetrieveAsync(
            global::System.Guid workflowId,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a Workflow<br/>
        /// Get workflow Content (JSON representation)
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.Workflow>> WorkflowWorkflowRetrieveAsResponseAsync(
            global::System.Guid workflowId,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}