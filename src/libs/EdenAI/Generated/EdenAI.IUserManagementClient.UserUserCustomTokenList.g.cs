#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// List Tokens
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.CustomTokensList>> UserUserCustomTokenListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}