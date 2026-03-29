#nullable enable

namespace EdenAI
{
    public partial interface ITextDetectionAsyncClient
    {
        /// <summary>
        /// Text Detection Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3`|0.1 (per 60 seconde)|60 seconde<br/>
        /// |**google**|`Video intelligence v1`|0.15 (per 60 seconde)|1 seconde<br/>
        /// |**twelvelabs**|`v1.1.2`|0.067 (per 60 seconde)|60 seconde<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoTextDetectionAsyncCreateAsync(

            global::EdenAI.AsyncVideoAnalysisRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text Detection Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3`|0.1 (per 60 seconde)|60 seconde<br/>
        /// |**google**|`Video intelligence v1`|0.15 (per 60 seconde)|1 seconde<br/>
        /// |**twelvelabs**|`v1.1.2`|0.067 (per 60 seconde)|60 seconde<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </param>
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
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="file">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="filename">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="fileUrl">
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoTextDetectionAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}