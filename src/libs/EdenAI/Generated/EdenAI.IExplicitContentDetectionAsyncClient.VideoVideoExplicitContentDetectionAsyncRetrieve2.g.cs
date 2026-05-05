#nullable enable

namespace EdenAI
{
    public partial interface IExplicitContentDetectionAsyncClient
    {
        /// <summary>
        /// Video Explicit Content Detection Get Job Results<br/>
        /// Get the status and results of an async job given its ID.
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="responseAsDict">
        /// Default Value: true
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
        global::System.Threading.Tasks.Task<global::EdenAI.AsyncvideoexplicitContentDetectionAsyncResponseModel> VideoVideoExplicitContentDetectionAsyncRetrieve2Async(
            string publicId,
            bool? responseAsDict = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Explicit Content Detection Get Job Results<br/>
        /// Get the status and results of an async job given its ID.
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="responseAsDict">
        /// Default Value: true
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
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.AsyncvideoexplicitContentDetectionAsyncResponseModel>> VideoVideoExplicitContentDetectionAsyncRetrieve2AsResponseAsync(
            string publicId,
            bool? responseAsDict = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}