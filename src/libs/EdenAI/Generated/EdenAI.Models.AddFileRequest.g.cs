
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddFileRequest
    {
        /// <summary>
        /// * `pdf` - pdf<br/>
        /// * `audio` - audio<br/>
        /// * `csv` - csv<br/>
        /// * `xml` - xml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.DataTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.DataTypeEnum DataType { get; set; }

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
        /// Optional parameter: Attach metadata to the uploaded file data in your database. Provide a stringified JSON with key-value pairs. Useful in `filter_document` when querying the language model, it allows you to filter data with your Chatbot by considering only documents that have the specified metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Select a provider to use, only for audio (speech-to-text) &amp; pdf (ocr-async) files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFileRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddFileRequest(
            global::EdenAI.DataTypeEnum dataType,
            byte[]? file,
            string? filename,
            string? fileUrl,
            string? metadata,
            string? provider)
        {
            this.DataType = dataType;
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
            this.Metadata = metadata;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFileRequest" /> class.
        /// </summary>
        public AddFileRequest()
        {
        }
    }
}