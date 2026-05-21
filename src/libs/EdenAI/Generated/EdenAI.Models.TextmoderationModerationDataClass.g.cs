
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextmoderationModerationDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw_likelihood")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NsfwLikelihood { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::EdenAI.TextModerationItem>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw_likelihood_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NsfwLikelihoodScore { get; set; }

        /// <summary>
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_response")]
        public object? OriginalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.Status549EnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Status549Enum Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationModerationDataClass" /> class.
        /// </summary>
        /// <param name="nsfwLikelihood"></param>
        /// <param name="nsfwLikelihoodScore"></param>
        /// <param name="status"></param>
        /// <param name="items"></param>
        /// <param name="originalResponse">
        /// original response sent by the provider, hidden by default, show it by passing the `show_original_response` field to `true` in your request<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextmoderationModerationDataClass(
            int nsfwLikelihood,
            int nsfwLikelihoodScore,
            global::EdenAI.Status549Enum status,
            global::System.Collections.Generic.IList<global::EdenAI.TextModerationItem>? items,
            object? originalResponse)
        {
            this.NsfwLikelihood = nsfwLikelihood;
            this.Items = items;
            this.NsfwLikelihoodScore = nsfwLikelihoodScore;
            this.OriginalResponse = originalResponse;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextmoderationModerationDataClass" /> class.
        /// </summary>
        public TextmoderationModerationDataClass()
        {
        }

    }
}