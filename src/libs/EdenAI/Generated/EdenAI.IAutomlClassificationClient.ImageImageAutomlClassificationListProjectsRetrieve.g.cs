#nullable enable

namespace EdenAI
{
    public partial interface IAutomlClassificationClient
    {
        /// <summary>
        /// Automl Classification - List Projects<br/>
        /// List Automl Classification Projects
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutomlClassificationListProjectsResponse> ImageImageAutomlClassificationListProjectsRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}