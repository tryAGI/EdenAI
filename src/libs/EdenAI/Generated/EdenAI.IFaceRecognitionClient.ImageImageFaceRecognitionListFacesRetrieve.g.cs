#nullable enable

namespace EdenAI
{
    public partial interface IFaceRecognitionClient
    {
        /// <summary>
        /// Face Recognition - List Faces<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Version|Price|Billing unit|<br/>
        /// |----|-------|-----|------------|<br/>
        /// |**amazon**|`boto3 1.26.8`|free|-<br/>
        /// |**facepp**|`v3`|0.1 (per 1000 request)|1 request<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="attributesAsList">
        /// Default Value: false
        /// </param>
        /// <param name="fallbackProviders">
        /// Default Value: []
        /// </param>
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
        global::System.Threading.Tasks.Task<global::EdenAI.ImagefaceRecognitionResponseModel> ImageImageFaceRecognitionListFacesRetrieveAsync(
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