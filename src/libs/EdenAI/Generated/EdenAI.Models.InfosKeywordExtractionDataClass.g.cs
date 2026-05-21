
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfosKeywordExtractionDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Keyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Importance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosKeywordExtractionDataClass" /> class.
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="importance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfosKeywordExtractionDataClass(
            string keyword,
            int importance)
        {
            this.Keyword = keyword ?? throw new global::System.ArgumentNullException(nameof(keyword));
            this.Importance = importance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosKeywordExtractionDataClass" /> class.
        /// </summary>
        public InfosKeywordExtractionDataClass()
        {
        }

    }
}