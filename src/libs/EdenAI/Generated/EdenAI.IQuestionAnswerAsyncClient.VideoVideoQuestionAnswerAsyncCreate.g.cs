#nullable enable

namespace EdenAI
{
    public partial interface IQuestionAnswerAsyncClient
    {
        /// <summary>
        /// Question Answer Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1Beta`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|-|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1Beta`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-flash-lite-preview**|`v1Beta`|1.5e-06 (per 1 token)|None token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-question_answer_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoQuestionAnswerAsyncCreateAsync(

            global::EdenAI.QuestionAnswerAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Question Answer Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1Beta`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|-|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1Beta`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-flash-lite-preview**|`v1Beta`|1.5e-06 (per 1 token)|None token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-question_answer_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> VideoVideoQuestionAnswerAsyncCreateAsResponseAsync(

            global::EdenAI.QuestionAnswerAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Question Answer Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1Beta`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|-|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1Beta`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-flash-lite-preview**|`v1Beta`|1.5e-06 (per 1 token)|None token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-question_answer_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
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
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.
        /// </param>
        /// <param name="text">
        /// Question about the video
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoQuestionAnswerAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
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
            double? temperature = default,
            int? maxTokens = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Question Answer Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1Beta`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|-|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1Beta`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-flash-lite-preview**|`v1Beta`|1.5e-06 (per 1 token)|None token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-question_answer_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        /// To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        /// Default Value: []
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        /// When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
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
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.
        /// </param>
        /// <param name="text">
        /// Question about the video
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoQuestionAnswerAsyncCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? fileUrl = default,
            double? temperature = default,
            int? maxTokens = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Question Answer Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1Beta`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|-|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1Beta`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3.1-flash-lite-preview**|`v1Beta`|1.5e-06 (per 1 token)|None token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1Beta`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1Beta`|0.3 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-question_answer_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        /// To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        /// Default Value: []
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        /// When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
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
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.
        /// </param>
        /// <param name="text">
        /// Question about the video
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> VideoVideoQuestionAnswerAsyncCreateAsResponseAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? showOriginalResponse = default,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            bool? showBase64 = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? fileUrl = default,
            double? temperature = default,
            int? maxTokens = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}