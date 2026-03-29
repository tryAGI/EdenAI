
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotUploadOperationsClient
    {
        partial void PrepareAiproductsAiproductsAskyodaV2AddFileCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId,
            global::EdenAI.AddFileRequest request);
        partial void PrepareAiproductsAiproductsAskyodaV2AddFileCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId,
            global::EdenAI.AddFileRequest request);
        partial void ProcessAiproductsAiproductsAskyodaV2AddFileCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddFileCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2AddFileCreateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                request: request);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/add_file/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAiproductsAiproductsAskyodaV2AddFileCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2AddFileCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddFileCreateAsync(
            global::System.Guid projectId,
            global::EdenAI.DataTypeEnum dataType,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? metadata = default,
            string? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.AddFileRequest
            {
                DataType = dataType,
                File = file,
                Filename = filename,
                FileUrl = fileUrl,
                Metadata = metadata,
                Provider = provider,
            };

            await AiproductsAiproductsAskyodaV2AddFileCreateAsync(
                projectId: projectId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}