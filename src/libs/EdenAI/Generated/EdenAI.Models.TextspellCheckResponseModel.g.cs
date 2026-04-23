
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextspellCheckResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohere")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Cohere { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sapling")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Sapling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prowritingaid")]
        public global::EdenAI.TextspellCheckSpellCheckDataClass? Prowritingaid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextspellCheckResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="cohere"></param>
        /// <param name="sapling"></param>
        /// <param name="prowritingaid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextspellCheckResponseModel(
            global::EdenAI.TextspellCheckSpellCheckDataClass? microsoft,
            global::EdenAI.TextspellCheckSpellCheckDataClass? xai,
            global::EdenAI.TextspellCheckSpellCheckDataClass? openai,
            global::EdenAI.TextspellCheckSpellCheckDataClass? cohere,
            global::EdenAI.TextspellCheckSpellCheckDataClass? sapling,
            global::EdenAI.TextspellCheckSpellCheckDataClass? prowritingaid)
        {
            this.Microsoft = microsoft;
            this.Xai = xai;
            this.Openai = openai;
            this.Cohere = cohere;
            this.Sapling = sapling;
            this.Prowritingaid = prowritingaid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextspellCheckResponseModel" /> class.
        /// </summary>
        public TextspellCheckResponseModel()
        {
        }
    }
}