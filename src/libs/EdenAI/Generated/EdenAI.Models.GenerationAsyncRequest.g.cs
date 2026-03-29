
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationAsyncRequest
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
        /// The text prompt that describes the content and style of the video you want to generate. Be specific and detailed to guide the AI in creating your desired video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Length of the generated video in seconds. Minimum duration is 1 second. If not specified, the video will default to 6 seconds.<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Frames per second (FPS) of the generated video. Determines the smoothness of the video motion. Default is 24 FPS, which is standard for most video content. Minimum value is 1 FPS.<br/>
        /// Default Value: 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Video resolution in the format 'width x height' (e.g., '1280x720'). Default resolution is 1280x720 (720p). Ensure the format is exactly 'width x height' with a lowercase 'x'.<br/>
        /// Default Value: 1280x720
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public string? Dimension { get; set; }

        /// <summary>
        /// Random seed value that initializes the noise for the generation process. Use this to create consistent or unique variations of your video:<br/>
        /// - Range: 0 to 2,147,483,646<br/>
        /// - Default: 12<br/>
        /// - Changing the seed while keeping other parameters constant will produce a different video that still matches your prompt<br/>
        /// - Useful for exploring multiple creative variations of the same concept<br/>
        /// Default Value: 12
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationAsyncRequest" /> class.
        /// </summary>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="text">
        /// The text prompt that describes the content and style of the video you want to generate. Be specific and detailed to guide the AI in creating your desired video.
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
        /// <param name="file">
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </param>
        /// <param name="filename">
        /// Initial keyframe image for the video. Upload a single JPEG or PNG file that will serve as the starting point for video generation. This image will influence the style, composition, and initial scene of the generated video.
        /// </param>
        /// <param name="duration">
        /// Length of the generated video in seconds. Minimum duration is 1 second. If not specified, the video will default to 6 seconds.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="fps">
        /// Frames per second (FPS) of the generated video. Determines the smoothness of the video motion. Default is 24 FPS, which is standard for most video content. Minimum value is 1 FPS.<br/>
        /// Default Value: 24
        /// </param>
        /// <param name="dimension">
        /// Video resolution in the format 'width x height' (e.g., '1280x720'). Default resolution is 1280x720 (720p). Ensure the format is exactly 'width x height' with a lowercase 'x'.<br/>
        /// Default Value: 1280x720
        /// </param>
        /// <param name="seed">
        /// Random seed value that initializes the noise for the generation process. Use this to create consistent or unique variations of your video:<br/>
        /// - Range: 0 to 2,147,483,646<br/>
        /// - Default: 12<br/>
        /// - Changing the seed while keeping other parameters constant will produce a different video that still matches your prompt<br/>
        /// - Useful for exploring multiple creative variations of the same concept<br/>
        /// Default Value: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationAsyncRequest(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings,
            global::System.Collections.Generic.IList<string>? fallbackProviders,
            bool? showOriginalResponse,
            string? webhookReceiver,
            object? usersWebhookParameters,
            bool? sendWebhookData,
            bool? showBase64,
            byte[]? file,
            string? filename,
            int? duration,
            int? fps,
            string? dimension,
            int? seed)
        {
            this.Settings = settings;
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.FallbackProviders = fallbackProviders;
            this.ShowOriginalResponse = showOriginalResponse;
            this.WebhookReceiver = webhookReceiver;
            this.UsersWebhookParameters = usersWebhookParameters;
            this.SendWebhookData = sendWebhookData;
            this.ShowBase64 = showBase64;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.File = file;
            this.Filename = filename;
            this.Duration = duration;
            this.Fps = fps;
            this.Dimension = dimension;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationAsyncRequest" /> class.
        /// </summary>
        public GenerationAsyncRequest()
        {
        }
    }
}