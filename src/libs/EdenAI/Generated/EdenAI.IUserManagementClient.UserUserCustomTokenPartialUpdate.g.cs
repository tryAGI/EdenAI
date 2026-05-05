#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Update Token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CustomTokenUpdate> UserUserCustomTokenPartialUpdateAsync(
            string name,

            global::EdenAI.PatchedCustomTokenUpdateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.CustomTokenUpdate>> UserUserCustomTokenPartialUpdateAsResponseAsync(
            string name,

            global::EdenAI.PatchedCustomTokenUpdateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="balance">
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </param>
        /// <param name="expireTime"></param>
        /// <param name="activeBalance">
        /// Weither to use the balance field or not.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CustomTokenUpdate> UserUserCustomTokenPartialUpdateAsync(
            string name,
            double? balance = default,
            global::System.DateTime? expireTime = default,
            bool? activeBalance = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}