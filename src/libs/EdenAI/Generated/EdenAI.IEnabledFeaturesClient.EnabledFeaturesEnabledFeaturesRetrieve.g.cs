#nullable enable

namespace EdenAI
{
    public partial interface IEnabledFeaturesClient
    {
        /// <summary>
        /// List all enabled features.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task EnabledFeaturesEnabledFeaturesRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}