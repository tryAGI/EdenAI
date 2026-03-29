
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTokensDetails
    {
        /// <summary>
        /// Number of audio tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioTokens { get; set; }

        /// <summary>
        /// Number of cached tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Number of tokens in the generated completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Total number of tokens used (prompt + completion)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Number of accepted tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_prediction_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AcceptedPredictionTokens { get; set; }

        /// <summary>
        /// Number of reasoning tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReasoningTokens { get; set; }

        /// <summary>
        /// Number of rejected tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_prediction_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RejectedPredictionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// Number of audio tokens in the prompt
        /// </param>
        /// <param name="cachedTokens">
        /// Number of cached tokens in the prompt
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used (prompt + completion)
        /// </param>
        /// <param name="acceptedPredictionTokens">
        /// Number of accepted tokens in the prompt
        /// </param>
        /// <param name="reasoningTokens">
        /// Number of reasoning tokens in the prompt
        /// </param>
        /// <param name="rejectedPredictionTokens">
        /// Number of rejected tokens in the prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageTokensDetails(
            int audioTokens,
            int cachedTokens,
            int promptTokens,
            int completionTokens,
            int totalTokens,
            int acceptedPredictionTokens,
            int reasoningTokens,
            int rejectedPredictionTokens)
        {
            this.AudioTokens = audioTokens;
            this.CachedTokens = cachedTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.AcceptedPredictionTokens = acceptedPredictionTokens;
            this.ReasoningTokens = reasoningTokens;
            this.RejectedPredictionTokens = rejectedPredictionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokensDetails" /> class.
        /// </summary>
        public UsageTokensDetails()
        {
        }
    }
}