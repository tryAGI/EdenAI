#nullable enable

namespace EdenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Launch Batch Job<br/>
        /// Launch a async Batch job, given a job name that will be used as its id.<br/>
        /// Each request should have the same parameters as you would normally pass to a feature.<br/>
        /// You can also pass an optional paramater `name` to help better identify each requests you send.<br/>
        /// Example with `text`/`sentiment_analysis`:<br/>
        /// ```json<br/>
        /// "requests": [<br/>
        ///     {<br/>
        ///         "text": "It's -25 outside and I am so hot.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google,amazon"<br/>
        ///     },<br/>
        ///     {<br/>
        ///         "name": "mixed",<br/>
        ///         "text": "Overall I am satisfied with my experience at Amazon, but two areas of major improvement needed.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// ### Limitations:<br/>
        /// You can have up to `5` concurrent running Jobs &amp; input up to `500` requests per Batch<br/>
        ///         <br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Features&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Feature Name|Subfeature Name|<br/>
        /// |------------|---------------|<br/>
        /// |`translation`|`language_detection`|<br/>
        /// |`image`|`face_detection`|<br/>
        /// |`text`|`chat`|<br/>
        /// |`ocr`|`receipt_parser`|<br/>
        /// |`image`|`anonymization`|<br/>
        /// |`audio`|`text_to_speech`|<br/>
        /// |`translation`|`document_translation`|<br/>
        /// |`image`|`logo_detection`|<br/>
        /// |`image`|`landmark_detection`|<br/>
        /// |`image`|`background_removal`|<br/>
        /// |`text`|`topic_extraction`|<br/>
        /// |`text`|`embeddings`|<br/>
        /// |`text`|`custom_classification`|<br/>
        /// |`text`|`anonymization`|<br/>
        /// |`text`|`summarize`|<br/>
        /// |`text`|`custom_named_entity_recognition`|<br/>
        /// |`text`|`generation`|<br/>
        /// |`text`|`code_generation`|<br/>
        /// |`text`|`moderation`|<br/>
        /// |`image`|`generation`|<br/>
        /// |`translation`|`automatic_translation`|<br/>
        /// |`text`|`search`|<br/>
        /// |`text`|`spell_check`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`ocr`|`identity_parser`|<br/>
        /// |`image`|`explicit_content`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`text`|`question_answer`|<br/>
        /// |`text`|`keyword_extraction`|<br/>
        /// |`text`|`named_entity_recognition`|<br/>
        /// |`text`|`syntax_analysis`|<br/>
        /// |`text`|`sentiment_analysis`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.BatchLaunchResponse> FeatureBatchCreateAsync(
            string feature,
            string name,
            string subfeature,

            global::EdenAI.BatchRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Launch Batch Job<br/>
        /// Launch a async Batch job, given a job name that will be used as its id.<br/>
        /// Each request should have the same parameters as you would normally pass to a feature.<br/>
        /// You can also pass an optional paramater `name` to help better identify each requests you send.<br/>
        /// Example with `text`/`sentiment_analysis`:<br/>
        /// ```json<br/>
        /// "requests": [<br/>
        ///     {<br/>
        ///         "text": "It's -25 outside and I am so hot.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google,amazon"<br/>
        ///     },<br/>
        ///     {<br/>
        ///         "name": "mixed",<br/>
        ///         "text": "Overall I am satisfied with my experience at Amazon, but two areas of major improvement needed.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// ### Limitations:<br/>
        /// You can have up to `5` concurrent running Jobs &amp; input up to `500` requests per Batch<br/>
        ///         <br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Features&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Feature Name|Subfeature Name|<br/>
        /// |------------|---------------|<br/>
        /// |`translation`|`language_detection`|<br/>
        /// |`image`|`face_detection`|<br/>
        /// |`text`|`chat`|<br/>
        /// |`ocr`|`receipt_parser`|<br/>
        /// |`image`|`anonymization`|<br/>
        /// |`audio`|`text_to_speech`|<br/>
        /// |`translation`|`document_translation`|<br/>
        /// |`image`|`logo_detection`|<br/>
        /// |`image`|`landmark_detection`|<br/>
        /// |`image`|`background_removal`|<br/>
        /// |`text`|`topic_extraction`|<br/>
        /// |`text`|`embeddings`|<br/>
        /// |`text`|`custom_classification`|<br/>
        /// |`text`|`anonymization`|<br/>
        /// |`text`|`summarize`|<br/>
        /// |`text`|`custom_named_entity_recognition`|<br/>
        /// |`text`|`generation`|<br/>
        /// |`text`|`code_generation`|<br/>
        /// |`text`|`moderation`|<br/>
        /// |`image`|`generation`|<br/>
        /// |`translation`|`automatic_translation`|<br/>
        /// |`text`|`search`|<br/>
        /// |`text`|`spell_check`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`ocr`|`identity_parser`|<br/>
        /// |`image`|`explicit_content`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`text`|`question_answer`|<br/>
        /// |`text`|`keyword_extraction`|<br/>
        /// |`text`|`named_entity_recognition`|<br/>
        /// |`text`|`syntax_analysis`|<br/>
        /// |`text`|`sentiment_analysis`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.BatchLaunchResponse>> FeatureBatchCreateAsResponseAsync(
            string feature,
            string name,
            string subfeature,

            global::EdenAI.BatchRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Launch Batch Job<br/>
        /// Launch a async Batch job, given a job name that will be used as its id.<br/>
        /// Each request should have the same parameters as you would normally pass to a feature.<br/>
        /// You can also pass an optional paramater `name` to help better identify each requests you send.<br/>
        /// Example with `text`/`sentiment_analysis`:<br/>
        /// ```json<br/>
        /// "requests": [<br/>
        ///     {<br/>
        ///         "text": "It's -25 outside and I am so hot.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google,amazon"<br/>
        ///     },<br/>
        ///     {<br/>
        ///         "name": "mixed",<br/>
        ///         "text": "Overall I am satisfied with my experience at Amazon, but two areas of major improvement needed.",<br/>
        ///         "language": "en",<br/>
        ///         "providers": "google"<br/>
        ///     },<br/>
        ///     ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// ### Limitations:<br/>
        /// You can have up to `5` concurrent running Jobs &amp; input up to `500` requests per Batch<br/>
        ///         <br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Features&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Feature Name|Subfeature Name|<br/>
        /// |------------|---------------|<br/>
        /// |`translation`|`language_detection`|<br/>
        /// |`image`|`face_detection`|<br/>
        /// |`text`|`chat`|<br/>
        /// |`ocr`|`receipt_parser`|<br/>
        /// |`image`|`anonymization`|<br/>
        /// |`audio`|`text_to_speech`|<br/>
        /// |`translation`|`document_translation`|<br/>
        /// |`image`|`logo_detection`|<br/>
        /// |`image`|`landmark_detection`|<br/>
        /// |`image`|`background_removal`|<br/>
        /// |`text`|`topic_extraction`|<br/>
        /// |`text`|`embeddings`|<br/>
        /// |`text`|`custom_classification`|<br/>
        /// |`text`|`anonymization`|<br/>
        /// |`text`|`summarize`|<br/>
        /// |`text`|`custom_named_entity_recognition`|<br/>
        /// |`text`|`generation`|<br/>
        /// |`text`|`code_generation`|<br/>
        /// |`text`|`moderation`|<br/>
        /// |`image`|`generation`|<br/>
        /// |`translation`|`automatic_translation`|<br/>
        /// |`text`|`search`|<br/>
        /// |`text`|`spell_check`|<br/>
        /// |`image`|`object_detection`|<br/>
        /// |`ocr`|`identity_parser`|<br/>
        /// |`image`|`explicit_content`|<br/>
        /// |`ocr`|`invoice_parser`|<br/>
        /// |`ocr`|`resume_parser`|<br/>
        /// |`audio`|`speech_to_text_async`|<br/>
        /// |`ocr`|`ocr_tables_async`|<br/>
        /// |`video`|`text_detection_async`|<br/>
        /// |`text`|`question_answer`|<br/>
        /// |`text`|`keyword_extraction`|<br/>
        /// |`text`|`named_entity_recognition`|<br/>
        /// |`text`|`syntax_analysis`|<br/>
        /// |`text`|`sentiment_analysis`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="webhookReceiver"></param>
        /// <param name="usersWebhookParameters">
        /// Json data that contains of additional parameters that will be sent back to the webhook receiver             (ex: api key for security or client's data ID to link the result internally).             Will only be used when webhook_receiver is set.
        /// </param>
        /// <param name="sendWebhookData">
        /// If set to false the webhook will not contain the result data. Use if your webhook receiver has a request size limit.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requests"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.BatchLaunchResponse> FeatureBatchCreateAsync(
            string feature,
            string name,
            string subfeature,
            global::System.Collections.Generic.IList<object> requests,
            string? webhookReceiver = default,
            object? usersWebhookParameters = default,
            bool? sendWebhookData = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}