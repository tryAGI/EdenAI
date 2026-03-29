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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task ResourcesResourcesAssetDestroyAsync(
            string asset,
            string resource,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}