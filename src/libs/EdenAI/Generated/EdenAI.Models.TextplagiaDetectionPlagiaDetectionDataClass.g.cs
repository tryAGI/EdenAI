
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextplagiaDetectionPlagiaDetectionDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plagia_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlagiaScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionItem>? Items { get; set; }

        /// <summary>
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_response")]
        public object? OriginalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.Status549EnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Status549Enum Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextplagiaDetectionPlagiaDetectionDataClass" /> class.
        /// </summary>
        /// <param name="plagiaScore"></param>
        /// <param name="status"></param>
        /// <param name="items"></param>
        /// <param name="originalResponse">
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextplagiaDetectionPlagiaDetectionDataClass(
            int plagiaScore,
            global::EdenAI.Status549Enum status,
            global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionItem>? items,
            object? originalResponse)
        {
            this.PlagiaScore = plagiaScore;
            this.Items = items;
            this.OriginalResponse = originalResponse;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextplagiaDetectionPlagiaDetectionDataClass" /> class.
        /// </summary>
        public TextplagiaDetectionPlagiaDetectionDataClass()
        {
        }

    }
}