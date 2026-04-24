
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextplagiaDetectionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winstonai")]
        public global::EdenAI.TextplagiaDetectionPlagiaDetectionDataClass? Winstonai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalityai")]
        public global::EdenAI.TextplagiaDetectionPlagiaDetectionDataClass? Originalityai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextplagiaDetectionResponseModel" /> class.
        /// </summary>
        /// <param name="winstonai"></param>
        /// <param name="originalityai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextplagiaDetectionResponseModel(
            global::EdenAI.TextplagiaDetectionPlagiaDetectionDataClass? winstonai,
            global::EdenAI.TextplagiaDetectionPlagiaDetectionDataClass? originalityai)
        {
            this.Winstonai = winstonai;
            this.Originalityai = originalityai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextplagiaDetectionResponseModel" /> class.
        /// </summary>
        public TextplagiaDetectionResponseModel()
        {
        }
    }
}