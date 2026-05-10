
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextModerationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likelihood")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Likelihood { get; set; }

        /// <summary>
        /// This enum are used to categorize the explicit content extracted from the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.CategoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.CategoryType Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subcategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.SubCategoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.SubCategoryType Subcategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likelihood_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikelihoodScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextModerationItem" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="likelihood"></param>
        /// <param name="category">
        /// This enum are used to categorize the explicit content extracted from the text
        /// </param>
        /// <param name="subcategory"></param>
        /// <param name="likelihoodScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextModerationItem(
            string label,
            int likelihood,
            global::EdenAI.CategoryType category,
            global::EdenAI.SubCategoryType subcategory,
            int likelihoodScore)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Likelihood = likelihood;
            this.Category = category;
            this.Subcategory = subcategory;
            this.LikelihoodScore = likelihoodScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextModerationItem" /> class.
        /// </summary>
        public TextModerationItem()
        {
        }

    }
}