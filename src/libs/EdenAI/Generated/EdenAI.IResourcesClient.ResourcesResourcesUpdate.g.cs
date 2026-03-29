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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ResourceUpdate> ResourcesResourcesUpdateAsync(
            string resource,

            global::EdenAI.ResourceUpdateRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ResourceUpdate> ResourcesResourcesUpdateAsync(
            string resource,
            string requestResource,
            object data,
            global::EdenAI.TypeDe8Enum type,
            string provider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}