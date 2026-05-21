
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextAsyncRequest
    {
        /// <summary>
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Providers { get; set; }

        /// <summary>
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_providers")]
        public global::System.Collections.Generic.IList<string>? FallbackProviders { get; set; }

        /// <summary>
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_original_response")]
        public bool? ShowOriginalResponse { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_base_64")]
        public bool? ShowBase64 { get; set; }

        /// <summary>
        /// Parameters specific to the provider that you want to send along the request.<br/>
        /// it should take a *provider* name as key and an object of parameters as value.<br/>
        /// Example:<br/>
        ///     {<br/>
        ///       "deepgram": {<br/>
        ///         "filler_words": true,<br/>
        ///         "smart_format": true,<br/>
        ///         "callback": "https://webhook.site/0000"<br/>
        ///       },<br/>
        ///       "assembly": {<br/>
        ///         "webhook_url": "https://webhook.site/0000"<br/>
        ///       }<br/>
        ///     }<br/>
        /// Please refer to the documentation of each provider to see which parameters to send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_params")]
        public string? ProviderParams { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Language code expected (ex: en, fr)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Number of speakers in the file audio<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public int? Speakers { get; set; }

        /// <summary>
        /// Boolean value to specify weather or not the service will filter profanity and replace inappropriate words with a series of asterisks<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity_filter")]
        public bool? ProfanityFilter { get; set; }

        /// <summary>
        /// List of words or composed words to be detected by the speech to text engine. (Ex: Word, Mike, Draw, Los Angeles,...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary")]
        public string? CustomVocabulary { get; set; }

        /// <summary>
        /// Boolean value to specify weather to convert the audio/video file to wav format to be accepted by a majority of the providers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_to_wav")]
        public bool? ConvertToWav { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextAsyncRequest" /> class.
        /// </summary>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
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
        /// <param name="providerParams">
        /// Parameters specific to the provider that you want to send along the request.<br/>
        /// it should take a *provider* name as key and an object of parameters as value.<br/>
        /// Example:<br/>
        ///     {<br/>
        ///       "deepgram": {<br/>
        ///         "filler_words": true,<br/>
        ///         "smart_format": true,<br/>
        ///         "callback": "https://webhook.site/0000"<br/>
        ///       },<br/>
        ///       "assembly": {<br/>
        ///         "webhook_url": "https://webhook.site/0000"<br/>
        ///       }<br/>
        ///     }<br/>
        /// Please refer to the documentation of each provider to see which parameters to send.
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
        /// <param name="language">
        /// Language code expected (ex: en, fr)
        /// </param>
        /// <param name="speakers">
        /// Number of speakers in the file audio<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="profanityFilter">
        /// Boolean value to specify weather or not the service will filter profanity and replace inappropriate words with a series of asterisks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabulary">
        /// List of words or composed words to be detected by the speech to text engine. (Ex: Word, Mike, Draw, Los Angeles,...)
        /// </param>
        /// <param name="convertToWav">
        /// Boolean value to specify weather to convert the audio/video file to wav format to be accepted by a majority of the providers<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextAsyncRequest(
            global::System.Collections.Generic.IList<string> providers,
            string? settings,
            global::System.Collections.Generic.IList<string>? fallbackProviders,
            bool? showOriginalResponse,
            string? webhookReceiver,
            object? usersWebhookParameters,
            bool? sendWebhookData,
            bool? showBase64,
            string? providerParams,
            byte[]? file,
            string? filename,
            string? fileUrl,
            string? language,
            int? speakers,
            bool? profanityFilter,
            string? customVocabulary,
            bool? convertToWav)
        {
            this.Settings = settings;
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.FallbackProviders = fallbackProviders;
            this.ShowOriginalResponse = showOriginalResponse;
            this.WebhookReceiver = webhookReceiver;
            this.UsersWebhookParameters = usersWebhookParameters;
            this.SendWebhookData = sendWebhookData;
            this.ShowBase64 = showBase64;
            this.ProviderParams = providerParams;
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
            this.Language = language;
            this.Speakers = speakers;
            this.ProfanityFilter = profanityFilter;
            this.CustomVocabulary = customVocabulary;
            this.ConvertToWav = convertToWav;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextAsyncRequest" /> class.
        /// </summary>
        public SpeechToTextAsyncRequest()
        {
        }

    }
}