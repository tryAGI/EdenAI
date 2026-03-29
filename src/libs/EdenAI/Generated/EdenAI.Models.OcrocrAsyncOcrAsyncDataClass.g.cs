
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrocrAsyncOcrAsyncDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawText { get; set; }

        /// <summary>
        /// List of pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<global::EdenAI.Page>? Pages { get; set; }

        /// <summary>
        /// Number of pages in the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPages { get; set; }

        /// <summary>
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_response")]
        public object? OriginalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.FinalStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinalStatusEnum FinalStatus { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrAsyncOcrAsyncDataClass" /> class.
        /// </summary>
        /// <param name="rawText"></param>
        /// <param name="numberOfPages">
        /// Number of pages in the document
        /// </param>
        /// <param name="id"></param>
        /// <param name="finalStatus"></param>
        /// <param name="pages">
        /// List of pages
        /// </param>
        /// <param name="originalResponse">
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="error">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrocrAsyncOcrAsyncDataClass(
            string rawText,
            int numberOfPages,
            string id,
            global::EdenAI.FinalStatusEnum finalStatus,
            global::System.Collections.Generic.IList<global::EdenAI.Page>? pages,
            object? originalResponse,
            object? error)
        {
            this.RawText = rawText ?? throw new global::System.ArgumentNullException(nameof(rawText));
            this.Pages = pages;
            this.NumberOfPages = numberOfPages;
            this.OriginalResponse = originalResponse;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FinalStatus = finalStatus;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrocrAsyncOcrAsyncDataClass" /> class.
        /// </summary>
        public OcrocrAsyncOcrAsyncDataClass()
        {
        }
    }
}