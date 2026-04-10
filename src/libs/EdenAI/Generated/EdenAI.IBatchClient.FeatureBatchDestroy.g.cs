#nullable enable

namespace EdenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Delete Batch Job<br/>
        /// Api view with custom pagination method to return paginated response from any queryset
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="name"></param>
        /// <param name="subfeature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task FeatureBatchDestroyAsync(
            string feature,
            string name,
            string subfeature,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}