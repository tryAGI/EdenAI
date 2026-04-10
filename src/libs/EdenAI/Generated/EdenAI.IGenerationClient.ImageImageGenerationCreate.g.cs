#nullable enable

namespace EdenAI
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Image generation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Resolution|Price|Billing unit|<br/>
        /// |----|----|-------|------|-----|------------|<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1024x1024`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`512x512`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`256x256`|0.016 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`512x512`|0.018 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`1024x1024`|0.02 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1024x1792`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1792x1024`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1024x1024`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`512x512`|0.018 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1024x1792`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1792x1024`|0.08 (per 1 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1024x1024`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|-|`v1Beta`|`1024x1024`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1152x896`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`896x1152`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1216x832`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1344x768`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`768x1344`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1536x640`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`640x1536`|15.0 (per 1000 image)|1 image<br/>
        /// |**replicate**|**anime-style**|`v1`|`1024x1024`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**anime-style**|`v1`|`256x256`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|-|`v1`|-|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`512x512`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**anime-style**|`v1`|`512x512`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`512x512`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`1024x1024`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`256x256`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`1024x1024`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`256x256`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**leonardo**|**Leonardo Phoenix**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Phoenix**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Lightning XL**|`v1`|`512x512`|0.011 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Lightning XL**|`v1`|`1024x1024`|0.012 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Anime XL**|`v1`|`512x512`|0.011 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Anime XL**|`v1`|`1024x1024`|0.012 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Kino XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Kino XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Vision XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Vision XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Diffusion XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Diffusion XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**AlbedoBase XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**AlbedoBase XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**SDXL 0.9**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**SDXL 0.9**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|-|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|-|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**minimax**|**image-01**|`v1`|-|0.0035 (per 1 image)|1 image<br/>
        /// |**minimax**|-|`v1`|-|0.0035 (per 1 image)|1 image<br/>
        /// |**bytedance**|**seedream-5-0-260128**|`v3`|-|0.035 (per 1 token)|1 token<br/>
        /// |**bytedance**|**seedream-4-0-250828**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedream-4-5-251128**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedream-3-0-t2i-250415**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=image-generation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`dall-e-3`|<br/>
        /// |**stabilityai**|`stable-diffusion-xl-1024-v1-0`|<br/>
        /// |**replicate**|`classic`|<br/>
        /// |**leonardo**|`Leonardo Phoenix`|<br/>
        /// |**minimax**|`image-01`|<br/>
        /// |**bytedance**|`seedream-3-0-t2i-250415`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ImagegenerationResponseModel> ImageImageGenerationCreateAsync(

            global::EdenAI.ImagegenerationGenerationRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image generation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Resolution|Price|Billing unit|<br/>
        /// |----|----|-------|------|-----|------------|<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1024x1024`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`512x512`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`256x256`|0.016 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`512x512`|0.018 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-2**|`v1Beta`|`1024x1024`|0.02 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1024x1792`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|**dall-e-3**|`v1Beta`|`1792x1024`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1024x1024`|0.04 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`512x512`|0.018 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1024x1792`|0.08 (per 1 image)|1 image<br/>
        /// |**openai**|-|`v1Beta`|`1792x1024`|0.08 (per 1 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1024x1024`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|-|`v1Beta`|`1024x1024`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1152x896`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`896x1152`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1216x832`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1344x768`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`768x1344`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`1536x640`|15.0 (per 1000 image)|1 image<br/>
        /// |**stabilityai**|**stable-diffusion-xl-1024-v1-0**|`v1Beta`|`640x1536`|15.0 (per 1000 image)|1 image<br/>
        /// |**replicate**|**anime-style**|`v1`|`1024x1024`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**anime-style**|`v1`|`256x256`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|-|`v1`|-|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`512x512`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**anime-style**|`v1`|`512x512`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`512x512`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`1024x1024`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**vintedois-diffusion**|`v1`|`256x256`|0.000225 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`1024x1024`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**replicate**|**classic**|`v1`|`256x256`|0.00115 (per 1 exec_time)|1 exec_time<br/>
        /// |**leonardo**|**Leonardo Phoenix**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Phoenix**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Lightning XL**|`v1`|`512x512`|0.011 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Lightning XL**|`v1`|`1024x1024`|0.012 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Anime XL**|`v1`|`512x512`|0.011 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Anime XL**|`v1`|`1024x1024`|0.012 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Kino XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Kino XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Vision XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Vision XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Diffusion XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**Leonardo Diffusion XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**AlbedoBase XL**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**AlbedoBase XL**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|**SDXL 0.9**|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|**SDXL 0.9**|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**leonardo**|-|`v1`|`512x512`|0.014 (per 1 image)|1 image<br/>
        /// |**leonardo**|-|`v1`|`1024x1024`|0.017 (per 1 image)|1 image<br/>
        /// |**minimax**|**image-01**|`v1`|-|0.0035 (per 1 image)|1 image<br/>
        /// |**minimax**|-|`v1`|-|0.0035 (per 1 image)|1 image<br/>
        /// |**bytedance**|**seedream-5-0-260128**|`v3`|-|0.035 (per 1 token)|1 token<br/>
        /// |**bytedance**|**seedream-4-0-250828**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedream-4-5-251128**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|-|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// |**bytedance**|**seedream-3-0-t2i-250415**|`v3`|-|0.03 (per 1 request)|1 request<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=image-generation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`dall-e-3`|<br/>
        /// |**stabilityai**|`stable-diffusion-xl-1024-v1-0`|<br/>
        /// |**replicate**|`classic`|<br/>
        /// |**leonardo**|`Leonardo Phoenix`|<br/>
        /// |**minimax**|`image-01`|<br/>
        /// |**bytedance**|`seedream-3-0-t2i-250415`|<br/>
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
        /// <param name="responseAsDict">
        /// Optional : When set to **true** (default), the response is an object of responses with providers names as keys :  <br/>
        ///                   ``` {"google" : { "status": "success", ... }, } ``` <br/>
        ///                 When set to **false** the response structure is a list of response objects :  <br/>
        ///                    ``` [{"status": "success", "provider": "google" ... }, ] ```. <br/>
        ///                   <br/>
        /// Default Value: true
        /// </param>
        /// <param name="attributesAsList">
        /// Optional : When set to **false** (default) the structure of the extracted items is list of objects having different attributes : <br/>
        ///      ```{'items': [{"attribute_1": "x1","attribute_2": "y2"}, ... ]}``` <br/>
        ///      When it is set to **true**, the response contains an object with each attribute as a list : <br/>
        ///      ```{ "attribute_1": ["x1","x2", ...], "attribute_2": [y1, y2, ...]}``` <br/>
        /// Default Value: false
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// Description of the desired image(s).
        /// </param>
        /// <param name="resolution">
        /// The image resolution (ex: 512x512, 1024x1024)
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ImagegenerationResponseModel> ImageImageGenerationCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string resolution,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            int? numImages = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}