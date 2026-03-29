#nullable enable

namespace EdenAI
{
    public partial interface ITextDetectionAsyncClient
    {
        /// <summary>
        /// Text Detection List Jobs<br/>
        /// Get a list of all jobs launched for this feature. You'll then be able to use the ID of each one to get its status and results.<br/>
        ///                             Please note that a **job status doesn't get updated until a get request** is sent.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.ListAsyncJobResponse> VideoVideoTextDetectionAsyncRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}