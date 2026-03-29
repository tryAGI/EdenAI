#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Retrieve Token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CustomTokensList> UserUserCustomTokenRetrieveAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}