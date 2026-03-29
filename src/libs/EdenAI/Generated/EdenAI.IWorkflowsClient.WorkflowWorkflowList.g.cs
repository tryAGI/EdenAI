#nullable enable

namespace EdenAI
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List Workflows<br/>
        /// List all created workflows. <br/>
        /// NOTE: you can only create a workflow through our app
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.Workflow>> WorkflowWorkflowListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}