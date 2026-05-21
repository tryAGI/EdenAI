#nullable enable

namespace EdenAI
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search - get image<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**sentisight**|`v3.3.1`|free|-<br/>
        /// |**nyckel**|`v1.0.0`|free|-<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="attributesAsList">
        /// Default Value: false
        /// </param>
        /// <param name="fallbackProviders">
        /// Default Value: []
        /// </param>
        /// <param name="imageName"></param>
        /// <param name="providers"></param>
        /// <param name="responseAsDict">
        /// Default Value: true
        /// </param>
        /// <param name="settings">
        /// Default Value: {}
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ImagesearchResponseModel> ImageImageSearchGetImageRetrieveAsync(
            string imageName,
            global::System.Collections.Generic.IList<string> providers,
            bool? attributesAsList = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            string? settings = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search - get image<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**sentisight**|`v3.3.1`|free|-<br/>
        /// |**nyckel**|`v1.0.0`|free|-<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="attributesAsList">
        /// Default Value: false
        /// </param>
        /// <param name="fallbackProviders">
        /// Default Value: []
        /// </param>
        /// <param name="imageName"></param>
        /// <param name="providers"></param>
        /// <param name="responseAsDict">
        /// Default Value: true
        /// </param>
        /// <param name="settings">
        /// Default Value: {}
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.ImagesearchResponseModel>> ImageImageSearchGetImageRetrieveAsResponseAsync(
            string imageName,
            global::System.Collections.Generic.IList<string> providers,
            bool? attributesAsList = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            string? settings = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}