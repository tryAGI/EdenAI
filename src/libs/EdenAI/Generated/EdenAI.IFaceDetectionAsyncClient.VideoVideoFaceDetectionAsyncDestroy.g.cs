#nullable enable

namespace EdenAI
{
    public partial interface IFaceDetectionAsyncClient
    {
        /// <summary>
        /// Face Detection delete Jobs<br/>
        /// Generic class to handle method GET all async job for user<br/>
        /// Attributes:<br/>
        ///     feature (str): EdenAI feature<br/>
        ///     subfeature (str): EdenAI subfeature
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task VideoVideoFaceDetectionAsyncDestroyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}