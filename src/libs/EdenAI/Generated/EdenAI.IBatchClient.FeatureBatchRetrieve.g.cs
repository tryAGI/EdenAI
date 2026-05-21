#nullable enable

namespace EdenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Job Result<br/>
        /// Return paginated response of requests with their status and their<br/>
        /// responses if the request succeeded or errror if failed
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="name2"></param>
        /// <param name="page"></param>
        /// <param name="publicId"></param>
        /// <param name="status"></param>
        /// <param name="subfeature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PaginatedBatchResponse> FeatureBatchRetrieveAsync(
            string feature,
            string name,
            string subfeature,
            string? name2 = default,
            int? page = default,
            int? publicId = default,
            global::EdenAI.FeatureBatchRetrieveStatus? status = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Batch Job Result<br/>
        /// Return paginated response of requests with their status and their<br/>
        /// responses if the request succeeded or errror if failed
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="name2"></param>
        /// <param name="page"></param>
        /// <param name="publicId"></param>
        /// <param name="status"></param>
        /// <param name="subfeature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.PaginatedBatchResponse>> FeatureBatchRetrieveAsResponseAsync(
            string feature,
            string name,
            string subfeature,
            string? name2 = default,
            int? page = default,
            int? publicId = default,
            global::EdenAI.FeatureBatchRetrieveStatus? status = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}