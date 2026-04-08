
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.UsageTokensDetails CompletionTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.UsageTokensDetails PromptTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens used (prompt + completion)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTokensDetails"></param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="totalTokens">
        /// Total number of tokens used (prompt + completion)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUsage(
            global::EdenAI.UsageTokensDetails completionTokensDetails,
            global::EdenAI.UsageTokensDetails promptTokensDetails,
            int totalTokens)
        {
            this.CompletionTokensDetails = completionTokensDetails ?? throw new global::System.ArgumentNullException(nameof(completionTokensDetails));
            this.PromptTokensDetails = promptTokensDetails ?? throw new global::System.ArgumentNullException(nameof(promptTokensDetails));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        public ChatCompletionUsage()
        {
        }
    }
}