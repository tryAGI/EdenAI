
#nullable enable

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageaiDetectionResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winstonai")]
        public global::EdenAI.ImageaiDetectionAiDetectionDataClass? Winstonai { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resemble")]
        public global::EdenAI.ImageaiDetectionAiDetectionDataClass? Resemble { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageaiDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="winstonai"></param>
        /// <param name="resemble"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageaiDetectionResponseModel(
            global::EdenAI.ImageaiDetectionAiDetectionDataClass? winstonai,
            global::EdenAI.ImageaiDetectionAiDetectionDataClass? resemble)
        {
            this.Winstonai = winstonai;
            this.Resemble = resemble;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageaiDetectionResponseModel" /> class.
        /// </summary>
        public ImageaiDetectionResponseModel()
        {
        }

    }
}