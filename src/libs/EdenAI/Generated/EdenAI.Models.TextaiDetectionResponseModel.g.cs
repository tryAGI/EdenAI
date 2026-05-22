
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextaiDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sapling")]
        public global::EdenAI.TextaiDetectionAiDetectionDataClass? Sapling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winstonai")]
        public global::EdenAI.TextaiDetectionAiDetectionDataClass? Winstonai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalityai")]
        public global::EdenAI.TextaiDetectionAiDetectionDataClass? Originalityai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextaiDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="sapling"></param>
        /// <param name="winstonai"></param>
        /// <param name="originalityai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextaiDetectionResponseModel(
            global::EdenAI.TextaiDetectionAiDetectionDataClass? sapling,
            global::EdenAI.TextaiDetectionAiDetectionDataClass? winstonai,
            global::EdenAI.TextaiDetectionAiDetectionDataClass? originalityai)
        {
            this.Sapling = sapling;
            this.Winstonai = winstonai;
            this.Originalityai = originalityai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextaiDetectionResponseModel" /> class.
        /// </summary>
        public TextaiDetectionResponseModel()
        {
        }

    }
}