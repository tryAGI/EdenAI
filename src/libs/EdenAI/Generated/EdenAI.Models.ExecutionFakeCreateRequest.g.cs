
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionFakeCreateRequest
    {
        /// <summary>
        /// Webhook receiver should be a valid https URL (ex : https://your.listner.com/endpoint).             After the processing is done, the webhook endpoint will receive a POST request with the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_receiver")]
        public string? WebhookReceiver { get; set; }

        /// <summary>
        /// Json data that contains of additional parameters that will be sent back to the webhook receiver             (ex: api key for security or client's data ID to link the result internally).             Will only be used when webhook_receiver is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_webhook_parameters")]
        public object? UsersWebhookParameters { get; set; }

        /// <summary>
        /// If set to false the webhook will not contain the result data. Use if your webhook receiver has a request size limit.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_webhook_data")]
        public bool? SendWebhookData { get; set; }

        /// <summary>
        /// An example of an input parameter specified in the input node<br/>
        /// Default Value: https://example.com/public/invoice_123.pdf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("my_invoice")]
        public string? MyInvoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionFakeCreateRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionFakeCreateRequest(
            string? webhookReceiver,
            object? usersWebhookParameters,
            bool? sendWebhookData,
            string? myInvoice)
        {
            this.WebhookReceiver = webhookReceiver;
            this.UsersWebhookParameters = usersWebhookParameters;
            this.SendWebhookData = sendWebhookData;
            this.MyInvoice = myInvoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionFakeCreateRequest" /> class.
        /// </summary>
        public ExecutionFakeCreateRequest()
        {
        }
    }
}