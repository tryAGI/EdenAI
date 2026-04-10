#nullable enable

namespace EdenAI
{
    public partial interface IResourcesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ResourceUpdate> ResourcesResourcesPartialUpdateAsync(
            string resource,

            global::EdenAI.PatchedResourceUpdateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="requestResource"></param>
        /// <param name="data"></param>
        /// <param name="type">
        /// * `db` - Db<br/>
        /// * `bucket` - Bucket<br/>
        /// * `db_vector` - Db Vector<br/>
        /// * `ai` - Ai
        /// </param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ResourceUpdate> ResourcesResourcesPartialUpdateAsync(
            string resource,
            string? requestResource = default,
            object? data = default,
            global::EdenAI.TypeDe8Enum? type = default,
            string? provider = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}