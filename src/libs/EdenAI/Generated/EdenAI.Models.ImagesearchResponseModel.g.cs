
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagesearchResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nyckel")]
        public global::EdenAI.ImagesearchSearchDeleteImageDataClass? Nyckel { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImagesearchSearchDeleteImageDataClass? Sentisight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesearchResponseModel" /> class.
        /// </summary>
        /// <param name="nyckel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sentisight">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesearchResponseModel(
            global::EdenAI.ImagesearchSearchDeleteImageDataClass? nyckel,
            global::EdenAI.ImagesearchSearchDeleteImageDataClass? sentisight)
        {
            this.Nyckel = nyckel;
            this.Sentisight = sentisight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesearchResponseModel" /> class.
        /// </summary>
        public ImagesearchResponseModel()
        {
        }
    }
}