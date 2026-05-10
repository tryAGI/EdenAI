
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagebackgroundRemovalBackgroundRemovalDataClass
    {
        /// <summary>
        /// The image in base64 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_b64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageB64 { get; set; }

        /// <summary>
        /// The image url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_resource_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageResourceUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalBackgroundRemovalDataClass" /> class.
        /// </summary>
        /// <param name="imageB64">
        /// The image in base64 format.
        /// </param>
        /// <param name="imageResourceUrl">
        /// The image url.
        /// </param>
        /// <param name="status"></param>
        /// <param name="originalResponse">
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagebackgroundRemovalBackgroundRemovalDataClass(
            string imageB64,
            string imageResourceUrl,
            global::EdenAI.Status549Enum status,
            object? originalResponse)
        {
            this.ImageB64 = imageB64 ?? throw new global::System.ArgumentNullException(nameof(imageB64));
            this.ImageResourceUrl = imageResourceUrl ?? throw new global::System.ArgumentNullException(nameof(imageResourceUrl));
            this.OriginalResponse = originalResponse;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalBackgroundRemovalDataClass" /> class.
        /// </summary>
        public ImagebackgroundRemovalBackgroundRemovalDataClass()
        {
        }

    }
}