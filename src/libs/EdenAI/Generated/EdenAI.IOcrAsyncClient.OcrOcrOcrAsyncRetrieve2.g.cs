#nullable enable

namespace EdenAI
{
    public partial interface IOcrAsyncClient
    {
        /// <summary>
        /// Ocr Async Get Job Results<br/>
        /// Get the status and results of an async job given its ID.
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="responseAsDict">
        /// Default Value: true
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AsyncocrocrAsyncResponseModel> OcrOcrOcrAsyncRetrieve2Async(
            string publicId,
            bool? responseAsDict = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}