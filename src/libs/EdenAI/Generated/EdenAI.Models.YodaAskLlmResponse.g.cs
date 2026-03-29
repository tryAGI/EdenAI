
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class YodaAskLlmResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaAskLlmResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="llmProvider"></param>
        /// <param name="llmModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public YodaAskLlmResponse(
            string result,
            string llmProvider,
            string llmModel)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.LlmProvider = llmProvider ?? throw new global::System.ArgumentNullException(nameof(llmProvider));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YodaAskLlmResponse" /> class.
        /// </summary>
        public YodaAskLlmResponse()
        {
        }
    }
}