
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageanonymizationResponseModel
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImageanonymizationAnonymizationDataClass? Api4ai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageanonymizationResponseModel" /> class.
        /// </summary>
        /// <param name="api4ai">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageanonymizationResponseModel(
            global::EdenAI.ImageanonymizationAnonymizationDataClass? api4ai)
        {
            this.Api4ai = api4ai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageanonymizationResponseModel" /> class.
        /// </summary>
        public ImageanonymizationResponseModel()
        {
        }
    }
}