#nullable enable

namespace EdenAI
{
    public partial interface ILogoDetectionClient
    {
        /// <summary>
        /// Logo Detection<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|-|`v1`|1.5 (per 1000 file)|1 file<br/>
        /// |**microsoft**|-|`v3.2`|1.0 (per 1000 file)|1 file<br/>
        /// |**api4ai**|-|`v1.0.0`|0.25 (per 1000 file)|1 file<br/>
        /// |**api4ai**|**v1**|`v1.0.0`|0.25 (per 1000 file)|1 file<br/>
        /// |**api4ai**|**v2**|`v1.0.0`|2.5 (per 1000 file)|1 file<br/>
        /// |**clarifai**|-|`8.0.0`|2.0 (per 1000 file)|1 file<br/>
        /// |**openai**|-|`v1`|24.0 (per 1000 file)|1 file<br/>
        /// |**openai**|**gpt-4o**|`v1`|24.0 (per 1000 file)|1 file<br/>
        /// |**openai**|**gpt-4-turbo**|`v1`|48.0 (per 1000 file)|1 file<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=image-logo_detection' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**api4ai**|`v1`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ImagelogoDetectionResponseModel> ImageImageLogoDetectionCreateAsync(

            global::EdenAI.ImagelogoDetectionLogoDetectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Logo Detection<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**google**|-|`v1`|1.5 (per 1000 file)|1 file<br/>
        /// |**microsoft**|-|`v3.2`|1.0 (per 1000 file)|1 file<br/>
        /// |**api4ai**|-|`v1.0.0`|0.25 (per 1000 file)|1 file<br/>
        /// |**api4ai**|**v1**|`v1.0.0`|0.25 (per 1000 file)|1 file<br/>
        /// |**api4ai**|**v2**|`v1.0.0`|2.5 (per 1000 file)|1 file<br/>
        /// |**clarifai**|-|`8.0.0`|2.0 (per 1000 file)|1 file<br/>
        /// |**openai**|-|`v1`|24.0 (per 1000 file)|1 file<br/>
        /// |**openai**|**gpt-4o**|`v1`|24.0 (per 1000 file)|1 file<br/>
        /// |**openai**|**gpt-4-turbo**|`v1`|48.0 (per 1000 file)|1 file<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=image-logo_detection' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**api4ai**|`v1`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
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
        global::System.Threading.Tasks.Task<global::EdenAI.ImagelogoDetectionResponseModel> ImageImageLogoDetectionCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}