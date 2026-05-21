#nullable enable

namespace EdenAI
{
    public partial interface IGenerationAsyncClient
    {
        /// <summary>
        /// Generation Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-reel-v1:1**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|**amazon.nova-reel-v1:0**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|-|`boto3`|0.5 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-2.3**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-02**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|-|`v1`|0.56 (per 1 request)|1 request<br/>
        /// |**minimax**|**S2V-01**|`v1`|0.65 (per 1 request)|1 request<br/>
        /// |**minimax**|**T2V/I2V-01-Director**|`v1`|0.43 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedance-1-0-pro-250528**|`v3`|0.62 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**bytedance**|**seedance-1-0-lite-t2v-250428**|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**google**|**veo-3.1-generate-preview**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-generate-001**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-fast-generate-001**|`v1Beta`|0.15 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1Beta`|3.6 (per 1 request)|1 request<br/>
        /// |**openai**|-|`v1`|5.0 (per 1 request)|1 request<br/>
        /// |**openai**|**sora-2**|`v1`|0.1 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-generation_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-reel-v1:1`|<br/>
        /// |**minimax**|`MiniMax-Hailuo-2.3`|<br/>
        /// |**bytedance**|`seedance-1-0-pro-250528`|<br/>
        /// |**google**|`veo-3.1-generate-preview`|<br/>
        /// |**openai**|`sora-2`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoGenerationAsyncCreateAsync(

            global::EdenAI.GenerationAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generation Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-reel-v1:1**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|**amazon.nova-reel-v1:0**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|-|`boto3`|0.5 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-2.3**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-02**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|-|`v1`|0.56 (per 1 request)|1 request<br/>
        /// |**minimax**|**S2V-01**|`v1`|0.65 (per 1 request)|1 request<br/>
        /// |**minimax**|**T2V/I2V-01-Director**|`v1`|0.43 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedance-1-0-pro-250528**|`v3`|0.62 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**bytedance**|**seedance-1-0-lite-t2v-250428**|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**google**|**veo-3.1-generate-preview**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-generate-001**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-fast-generate-001**|`v1Beta`|0.15 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1Beta`|3.6 (per 1 request)|1 request<br/>
        /// |**openai**|-|`v1`|5.0 (per 1 request)|1 request<br/>
        /// |**openai**|**sora-2**|`v1`|0.1 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-generation_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-reel-v1:1`|<br/>
        /// |**minimax**|`MiniMax-Hailuo-2.3`|<br/>
        /// |**bytedance**|`seedance-1-0-pro-250528`|<br/>
        /// |**google**|`veo-3.1-generate-preview`|<br/>
        /// |**openai**|`sora-2`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.LaunchAsyncJobResponse>> VideoVideoGenerationAsyncCreateAsResponseAsync(

            global::EdenAI.GenerationAsyncRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generation Launch Job<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-reel-v1:1**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|**amazon.nova-reel-v1:0**|`boto3`|0.08 (per 1 seconde)|1 seconde<br/>
        /// |**amazon**|-|`boto3`|0.5 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-2.3**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|**MiniMax-Hailuo-02**|`v1`|0.28 (per 1 request)|1 request<br/>
        /// |**minimax**|-|`v1`|0.56 (per 1 request)|1 request<br/>
        /// |**minimax**|**S2V-01**|`v1`|0.65 (per 1 request)|1 request<br/>
        /// |**minimax**|**T2V/I2V-01-Director**|`v1`|0.43 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedance-1-0-pro-250528**|`v3`|0.62 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**bytedance**|**seedance-1-0-lite-t2v-250428**|`v3`|1.8 (per 1000000 token)|1 token<br/>
        /// |**google**|**veo-3.1-generate-preview**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-generate-001**|`v1Beta`|0.4 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**veo-3.0-fast-generate-001**|`v1Beta`|0.15 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1Beta`|3.6 (per 1 request)|1 request<br/>
        /// |**openai**|-|`v1`|5.0 (per 1 request)|1 request<br/>
        /// |**openai**|**sora-2**|`v1`|0.1 (per 1 seconde)|1 seconde<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=video-generation_async' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-reel-v1:1`|<br/>
        /// |**minimax**|`MiniMax-Hailuo-2.3`|<br/>
        /// |**bytedance**|`seedance-1-0-pro-250528`|<br/>
        /// |**google**|`veo-3.1-generate-preview`|<br/>
        /// |**openai**|`sora-2`|<br/>
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
        /// <param name="text">
        /// The text prompt that describes the content and style of the video you want to generate. Be specific and detailed to guide the AI in creating your desired video.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.LaunchAsyncJobResponse> VideoVideoGenerationAsyncCreateAsync(
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
            int? duration = default,
            int? fps = default,
            string? dimension = default,
            int? seed = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}