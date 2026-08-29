#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Rotate a Token's secret<br/>
        /// Rotate a key's secret in place: same key (name, id, budget, guardrail),<br/>
        /// brand-new ``sk-eden`` value. The old value stops working immediately; the new<br/>
        /// one is returned exactly once. Operates on real ``Token`` rows only — a legacy<br/>
        /// primary/sandbox key (a JWT in a ``User`` column) is regenerated via<br/>
        /// MigrateLegacyKey instead. Mutating, so the session access token is required —<br/>
        /// no API key can rotate itself or others.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UserUserCustomTokenRotateCreateAsync(
            string name,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a Token's secret<br/>
        /// Rotate a key's secret in place: same key (name, id, budget, guardrail),<br/>
        /// brand-new ``sk-eden`` value. The old value stops working immediately; the new<br/>
        /// one is returned exactly once. Operates on real ``Token`` rows only — a legacy<br/>
        /// primary/sandbox key (a JWT in a ``User`` column) is regenerated via<br/>
        /// MigrateLegacyKey instead. Mutating, so the session access token is required —<br/>
        /// no API key can rotate itself or others.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse> UserUserCustomTokenRotateCreateAsResponseAsync(
            string name,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}