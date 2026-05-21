#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUploadOperationsClient
    {
        /// <summary>
        /// Add File<br/>
        /// This endpoint enables you to upload files (**CSV**, **AUDIO**, **PDF**, or **XML**) into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database. <br/>
        /// ### Supported File Types<br/>
        /// - **CSV**: Comma-separated values files.<br/>
        /// - **Audio**: Supported audio formats for transcription to text.<br/>
        /// - **PDF**: Portable Document Format files.<br/>
        /// - **XML**: Extensible Markup Language files.<br/>
        /// ### OCR Processing and Speech-to-Text<br/>
        /// If the uploaded file is a PDF, it will undergo Optical Character Recognition (OCR) processing using the default provider chosen during the project creation step. <br/>
        /// Similarly, audio files will be converted to text using Speech-to-Text, also utilizing the default provider configured during project setup.<br/>
        /// ### Accepted File Extensions<br/>
        /// - **PDF**<br/>
        /// - **CSV**<br/>
        /// - **AMR**<br/>
        /// - **FLAC**<br/>
        /// - **WAV**<br/>
        /// - **OGG**<br/>
        /// - **MP3**<br/>
        /// - **MP4**<br/>
        /// - **WEBM**<br/>
        /// - **XML**
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddFileCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddFileRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add File<br/>
        /// This endpoint enables you to upload files (**CSV**, **AUDIO**, **PDF**, or **XML**) into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database. <br/>
        /// ### Supported File Types<br/>
        /// - **CSV**: Comma-separated values files.<br/>
        /// - **Audio**: Supported audio formats for transcription to text.<br/>
        /// - **PDF**: Portable Document Format files.<br/>
        /// - **XML**: Extensible Markup Language files.<br/>
        /// ### OCR Processing and Speech-to-Text<br/>
        /// If the uploaded file is a PDF, it will undergo Optical Character Recognition (OCR) processing using the default provider chosen during the project creation step. <br/>
        /// Similarly, audio files will be converted to text using Speech-to-Text, also utilizing the default provider configured during project setup.<br/>
        /// ### Accepted File Extensions<br/>
        /// - **PDF**<br/>
        /// - **CSV**<br/>
        /// - **AMR**<br/>
        /// - **FLAC**<br/>
        /// - **WAV**<br/>
        /// - **OGG**<br/>
        /// - **MP3**<br/>
        /// - **MP4**<br/>
        /// - **WEBM**<br/>
        /// - **XML**
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse> AiproductsAiproductsAskyodaV2AddFileCreateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.AddFileRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add File<br/>
        /// This endpoint enables you to upload files (**CSV**, **AUDIO**, **PDF**, or **XML**) into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database. <br/>
        /// ### Supported File Types<br/>
        /// - **CSV**: Comma-separated values files.<br/>
        /// - **Audio**: Supported audio formats for transcription to text.<br/>
        /// - **PDF**: Portable Document Format files.<br/>
        /// - **XML**: Extensible Markup Language files.<br/>
        /// ### OCR Processing and Speech-to-Text<br/>
        /// If the uploaded file is a PDF, it will undergo Optical Character Recognition (OCR) processing using the default provider chosen during the project creation step. <br/>
        /// Similarly, audio files will be converted to text using Speech-to-Text, also utilizing the default provider configured during project setup.<br/>
        /// ### Accepted File Extensions<br/>
        /// - **PDF**<br/>
        /// - **CSV**<br/>
        /// - **AMR**<br/>
        /// - **FLAC**<br/>
        /// - **WAV**<br/>
        /// - **OGG**<br/>
        /// - **MP3**<br/>
        /// - **MP4**<br/>
        /// - **WEBM**<br/>
        /// - **XML**
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="dataType">
        /// * `pdf` - pdf<br/>
        /// * `audio` - audio<br/>
        /// * `csv` - csv<br/>
        /// * `xml` - xml
        /// </param>
        /// <param name="file">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="filename">
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </param>
        /// <param name="fileUrl">
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </param>
        /// <param name="metadata">
        /// Optional parameter: Attach metadata to the uploaded file data in your database. Provide a stringified JSON with key-value pairs. Useful in `filter_document` when querying the language model, it allows you to filter data with your Chatbot by considering only documents that have the specified metadata.
        /// </param>
        /// <param name="provider">
        /// Select a provider to use, only for audio (speech-to-text) &amp; pdf (ocr-async) files.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddFileCreateAsync(
            global::System.Guid projectId,
            global::EdenAI.DataTypeEnum dataType,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? metadata = default,
            string? provider = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}