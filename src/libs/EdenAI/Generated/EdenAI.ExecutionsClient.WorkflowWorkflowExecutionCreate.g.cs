
#nullable enable

namespace EdenAI
{
    public partial class ExecutionsClient
    {
        partial void PrepareWorkflowWorkflowExecutionCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid workflowId,
            global::EdenAI.ExecutionFakeCreateRequest request);
        partial void PrepareWorkflowWorkflowExecutionCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid workflowId,
            global::EdenAI.ExecutionFakeCreateRequest request);
        partial void ProcessWorkflowWorkflowExecutionCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessWorkflowWorkflowExecutionCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.ExecutionExampleSuccessCreate> WorkflowWorkflowExecutionCreateAsync(
            global::System.Guid workflowId,

            global::EdenAI.ExecutionFakeCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareWorkflowWorkflowExecutionCreateArguments(
                httpClient: HttpClient,
                workflowId: ref workflowId,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/workflow/{workflowId}/execution/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareWorkflowWorkflowExecutionCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workflowId: workflowId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessWorkflowWorkflowExecutionCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessWorkflowWorkflowExecutionCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::EdenAI.ExecutionExampleSuccessCreate.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::EdenAI.ExecutionExampleSuccessCreate.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.ExecutionExampleSuccessCreate> WorkflowWorkflowExecutionCreateAsync(
            global::System.Guid workflowId,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            string? myInvoice = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.ExecutionFakeCreateRequest
            {
                WebhookReceiver = webhookReceiver,
                UsersWebhookParameters = usersWebhookParameters,
                SendWebhookData = sendWebhookData,
                MyInvoice = myInvoice,
            };

            return await WorkflowWorkflowExecutionCreateAsync(
                workflowId: workflowId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}