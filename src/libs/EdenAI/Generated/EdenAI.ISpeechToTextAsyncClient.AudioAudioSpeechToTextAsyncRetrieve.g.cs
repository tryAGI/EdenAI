#nullable enable

namespace EdenAI
{
    public partial interface ISpeechToTextAsyncClient
    {
        /// <summary>
        /// Speech to Text List Jobs<br/>
        /// Get a list of all jobs launched for this feature. You'll then be able to use the ID of each one to get its status and results.<br/>
        ///                             Please note that a **job status doesn't get updated until a get request** is sent.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ListAsyncJobResponse> AudioAudioSpeechToTextAsyncRetrieveAsync(
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}