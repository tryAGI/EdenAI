
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddImageRequest
    {
        /// <summary>
        /// Optional parameter: Attach metadata to the uploaded data in your database. Provide a stringified JSON with key-value pairs. Useful in `filter_document` when querying the language model, it allows you to filter data with your Chatbot by considering only documents that have the specified metadata. Key 'collection_name' is not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Optional. Select the Language Model provider (e.g., `google/gemini-2.0-flash`, `openai/gpt-4-vision-preview`) to use for describing the uploaded content.  This model will analyze the content and generate a text description, which will be stored in the RAG database. If left blank, a default model is used.<br/>
        /// Default Value: gemini-2.0-flash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional. Specify a custom prompt to guide the Language Model in generating the description for the content.  If no prompt is provided, a default prompt will be used to describe what's in the image/video.  This allows for more specific or targeted analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// File to analyse in binary format to be used with *content-type*: **multipart/form-data**  **Does not work with application/json !**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File **URL** to analyse to be used with with *content-type*: **application/json**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddImageRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddImageRequest(
            string? metadata,
            string? model,
            string? prompt,
            byte[]? file,
            string? filename,
            string? fileUrl)
        {
            this.Metadata = metadata;
            this.Model = model;
            this.Prompt = prompt;
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddImageRequest" /> class.
        /// </summary>
        public AddImageRequest()
        {
        }

    }
}