
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextpromptOptimizationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextpromptOptimizationPromptOptimizationDataClass? Openai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextpromptOptimizationResponseModel" /> class.
        /// </summary>
        /// <param name="openai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextpromptOptimizationResponseModel(
            global::EdenAI.TextpromptOptimizationPromptOptimizationDataClass? openai)
        {
            this.Openai = openai;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextpromptOptimizationResponseModel" /> class.
        /// </summary>
        public TextpromptOptimizationResponseModel()
        {
        }

    }
}