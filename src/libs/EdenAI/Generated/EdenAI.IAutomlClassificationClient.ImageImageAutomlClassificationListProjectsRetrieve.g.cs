#nullable enable

namespace EdenAI
{
    public partial interface IAutomlClassificationClient
    {
        /// <summary>
        /// Automl Classification - List Projects<br/>
        /// List Automl Classification Projects
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutomlClassificationListProjectsResponse> ImageImageAutomlClassificationListProjectsRetrieveAsync(
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}