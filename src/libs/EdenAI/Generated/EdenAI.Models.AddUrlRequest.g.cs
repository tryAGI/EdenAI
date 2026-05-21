
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddUrlRequest
    {
        /// <summary>
        /// Add multiple urls into the database, it loads all the text from HTML webpages into a document format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Enable JavaScript rendering for the provided URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("js_render")]
        public global::System.Collections.Generic.IList<bool>? JsRender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<object>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUrlRequest" /> class.
        /// </summary>
        /// <param name="urls">
        /// Add multiple urls into the database, it loads all the text from HTML webpages into a document format.
        /// </param>
        /// <param name="jsRender">
        /// Enable JavaScript rendering for the provided URLs.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddUrlRequest(
            global::System.Collections.Generic.IList<string> urls,
            global::System.Collections.Generic.IList<bool>? jsRender,
            global::System.Collections.Generic.IList<object>? metadata)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.JsRender = jsRender;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUrlRequest" /> class.
        /// </summary>
        public AddUrlRequest()
        {
        }

    }
}