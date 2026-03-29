#nullable enable

namespace EdenAI
{
    public partial interface IResourcesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="resource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AssetUpdate> ResourcesResourcesAssetUpdateAsync(
            string asset,
            string resource,

            global::EdenAI.AssetUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="resource"></param>
        /// <param name="subResource"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AssetUpdate> ResourcesResourcesAssetUpdateAsync(
            string asset,
            string resource,
            string subResource,
            object data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}