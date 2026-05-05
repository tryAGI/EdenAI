#nullable enable

namespace EdenAI
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Get an Execution by ID<br/>
        /// An Execution represents the process of running a workflow with specific input data. It tracks the workflow's progress, providing a unique id, a status (e.g., pending, running, completed), and a result once the execution is finished. You can retrieve an Execution by its id to monitor its status or access its result after completion
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ExecutionExampleSuccessCreate> WorkflowWorkflowExecutionRetrieveAsync(
            global::System.Guid executionId,
            global::System.Guid workflowId,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an Execution by ID<br/>
        /// An Execution represents the process of running a workflow with specific input data. It tracks the workflow's progress, providing a unique id, a status (e.g., pending, running, completed), and a result once the execution is finished. You can retrieve an Execution by its id to monitor its status or access its result after completion
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.ExecutionExampleSuccessCreate>> WorkflowWorkflowExecutionRetrieveAsResponseAsync(
            global::System.Guid executionId,
            global::System.Guid workflowId,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}