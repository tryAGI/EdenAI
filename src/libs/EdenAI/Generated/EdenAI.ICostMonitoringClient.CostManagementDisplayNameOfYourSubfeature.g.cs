#nullable enable

namespace EdenAI
{
    public partial interface ICostMonitoringClient
    {
        /// <summary>
        /// My Credits<br/>
        /// Get you current credits
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CreditsSerializer> CostManagementDisplayNameOfYourSubfeatureAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}