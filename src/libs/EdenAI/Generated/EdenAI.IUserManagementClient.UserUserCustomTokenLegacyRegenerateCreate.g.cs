#nullable enable

namespace EdenAI
{
    public partial interface IUserManagementClient
    {
        /// <summary>
        /// Regenerate a legacy primary/sandbox key<br/>
        /// Regenerate a legacy primary/sandbox key — a JWT stored in a ``User`` column,<br/>
        /// not a ``Token`` row — as a real hashed ``sk-eden`` custom key.<br/>
        /// Nulls the ``User`` column, which revokes the old JWT immediately in BOTH<br/>
        /// services (edenai-back matches the column in ``auth.py``; aifeatures re-checks<br/>
        /// it against the column on every request), and mints a new key returned exactly<br/>
        /// once. The new key's name defaults to "Production"/"Sandbox" (auto-suffixed to<br/>
        /// "Production 2" etc. if that name is already taken) and may be overridden in the<br/>
        /// body. Session-only and NOT quota-gated — migrating an existing key is never<br/>
        /// blocked, even at the custom-key cap. The old key can't authorize its own<br/>
        /// replacement.
        /// </summary>
        /// <param name="legacyType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UserUserCustomTokenLegacyRegenerateCreateAsync(
            string legacyType,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate a legacy primary/sandbox key<br/>
        /// Regenerate a legacy primary/sandbox key — a JWT stored in a ``User`` column,<br/>
        /// not a ``Token`` row — as a real hashed ``sk-eden`` custom key.<br/>
        /// Nulls the ``User`` column, which revokes the old JWT immediately in BOTH<br/>
        /// services (edenai-back matches the column in ``auth.py``; aifeatures re-checks<br/>
        /// it against the column on every request), and mints a new key returned exactly<br/>
        /// once. The new key's name defaults to "Production"/"Sandbox" (auto-suffixed to<br/>
        /// "Production 2" etc. if that name is already taken) and may be overridden in the<br/>
        /// body. Session-only and NOT quota-gated — migrating an existing key is never<br/>
        /// blocked, even at the custom-key cap. The old key can't authorize its own<br/>
        /// replacement.
        /// </summary>
        /// <param name="legacyType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse> UserUserCustomTokenLegacyRegenerateCreateAsResponseAsync(
            string legacyType,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}