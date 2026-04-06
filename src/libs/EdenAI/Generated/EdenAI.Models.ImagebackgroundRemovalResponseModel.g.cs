
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagebackgroundRemovalResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Sentisight { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stabilityai")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Stabilityai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picsart")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Picsart { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clipdrop")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Clipdrop { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Microsoft { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Api4ai { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoroom")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Photoroom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalResponseModel" /> class.
        /// </summary>
        /// <param name="sentisight">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stabilityai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="picsart">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clipdrop">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="microsoft">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="api4ai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="photoroom">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagebackgroundRemovalResponseModel(
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? sentisight,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? stabilityai,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? picsart,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? clipdrop,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? microsoft,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? api4ai,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? photoroom)
        {
            this.Sentisight = sentisight;
            this.Stabilityai = stabilityai;
            this.Picsart = picsart;
            this.Clipdrop = clipdrop;
            this.Microsoft = microsoft;
            this.Api4ai = api4ai;
            this.Photoroom = photoroom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalResponseModel" /> class.
        /// </summary>
        public ImagebackgroundRemovalResponseModel()
        {
        }
    }
}