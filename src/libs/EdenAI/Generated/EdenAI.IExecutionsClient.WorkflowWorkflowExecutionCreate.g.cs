#nullable enable

namespace EdenAI
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Create an Execution<br/>
        /// Launch a workflow Execution.<br/>
        /// if you set `input` in your workflow, you will need to launch the execution with these inputs as parameters<br/>
        /// For example if you set a file_url as input with name "my_invoice", your request body will look like this:<br/>
        ///     { my_invoice: "https://example.com/public/invoice_123.pdf" }<br/>
        ///     
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ExecutionExampleSuccessCreate> WorkflowWorkflowExecutionCreateAsync(
            global::System.Guid workflowId,

            global::EdenAI.ExecutionFakeCreateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Execution<br/>
        /// Launch a workflow Execution.<br/>
        /// if you set `input` in your workflow, you will need to launch the execution with these inputs as parameters<br/>
        /// For example if you set a file_url as input with name "my_invoice", your request body will look like this:<br/>
        ///     { my_invoice: "https://example.com/public/invoice_123.pdf" }<br/>
        ///     
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="webhookReceiver">
        /// Webhook receiver should be a valid https URL (ex : https://your.listner.com/endpoint).             After the processing is done, the webhook endpoint will receive a POST request with the result.
        /// </param>
        /// <param name="usersWebhookParameters">
        /// Json data that contains of additional parameters that will be sent back to the webhook receiver             (ex: api key for security or client's data ID to link the result internally).             Will only be used when webhook_receiver is set.
        /// </param>
        /// <param name="sendWebhookData">
        /// If set to false the webhook will not contain the result data. Use if your webhook receiver has a request size limit.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="myInvoice">
        /// An example of an input parameter specified in the input node<br/>
        /// Default Value: https://example.com/public/invoice_123.pdf
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ExecutionExampleSuccessCreate> WorkflowWorkflowExecutionCreateAsync(
            global::System.Guid workflowId,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            string? myInvoice = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}