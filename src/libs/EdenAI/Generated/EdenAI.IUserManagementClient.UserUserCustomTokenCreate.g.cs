#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Create new Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.CustomTokensCreate> UserUserCustomTokenCreateAsync(

            global::EdenAI.CustomTokensCreateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new Token
        /// </summary>
        /// <param name="name">
        /// The token name
        /// </param>
        /// <param name="tokenType">
        /// * `sandbox_api_token` - Sandbox<br/>
        /// * `api_token` - Back
        /// </param>
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
        global::System.Threading.Tasks.Task<global::EdenAI.CustomTokensCreate> UserUserCustomTokenCreateAsync(
            string name,
            global::EdenAI.TokenTypeEnum? tokenType = default,
            string? balance = default,
            global::System.DateTime? expireTime = default,
            bool? activeBalance = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}