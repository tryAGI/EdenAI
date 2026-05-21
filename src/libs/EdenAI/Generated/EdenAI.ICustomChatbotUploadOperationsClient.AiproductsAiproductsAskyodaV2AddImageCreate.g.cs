#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUploadOperationsClient
    {
        /// <summary>
        /// Add Image<br/>
        /// This endpoint enables you to upload images into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddImageCreateAsync(
            global::System.Guid projectId,

            global::EdenAI.AddImageRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Image<br/>
        /// This endpoint enables you to upload images into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse> AiproductsAiproductsAskyodaV2AddImageCreateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.AddImageRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Image<br/>
        /// This endpoint enables you to upload images into your project.  Upon upload, the file will be processed and stored as text embeddings within the project's database.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="metadata">
        /// Optional parameter: Attach metadata to the uploaded data in your database. Provide a stringified JSON with key-value pairs. Useful in `filter_document` when querying the language model, it allows you to filter data with your Chatbot by considering only documents that have the specified metadata. Key 'collection_name' is not allowed.
        /// </param>
        /// <param name="model">
        /// Optional. Select the Language Model provider (e.g., `google/gemini-2.0-flash`, `openai/gpt-4-vision-preview`) to use for describing the uploaded content.  This model will analyze the content and generate a text description, which will be stored in the RAG database. If left blank, a default model is used.<br/>
        /// Default Value: gemini-2.0-flash
        /// </param>
        /// <param name="prompt">
        /// Optional. Specify a custom prompt to guide the Language Model in generating the description for the content.  If no prompt is provided, a default prompt will be used to describe what's in the image/video.  This allows for more specific or targeted analysis.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2AddImageCreateAsync(
            global::System.Guid projectId,
            string? metadata = default,
            string? model = default,
            string? prompt = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}