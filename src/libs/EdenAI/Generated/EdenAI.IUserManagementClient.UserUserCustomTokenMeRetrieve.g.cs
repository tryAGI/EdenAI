#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Inspect the calling API key<br/>
        /// Return info about the API key used to authenticate *this* request — its<br/>
        /// label, masking, budget and remaining balance. The introspection counterpart<br/>
        /// to OpenRouter's ``GET /key``: authenticated BY the key itself (FeatureAuth),<br/>
        /// never by a session, and it can only ever see its own row. Key management<br/>
        /// (list/create/rotate/delete) lives on the session-only endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UserUserCustomTokenMeRetrieveAsync(
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inspect the calling API key<br/>
        /// Return info about the API key used to authenticate *this* request — its<br/>
        /// label, masking, budget and remaining balance. The introspection counterpart<br/>
        /// to OpenRouter's ``GET /key``: authenticated BY the key itself (FeatureAuth),<br/>
        /// never by a session, and it can only ever see its own row. Key management<br/>
        /// (list/create/rotate/delete) lives on the session-only endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse> UserUserCustomTokenMeRetrieveAsResponseAsync(
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}