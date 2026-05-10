
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Represents a suggestion for a misspelled word.<br/>
    /// Args:<br/>
    ///     suggestion (str): The suggested text.<br/>
    ///     score (float, optional): The score of the suggested text (between 0 and 1).<br/>
    /// Raises:<br/>
    ///     ValueError: If the score is not between 0 and 1.<br/>
    /// Returns:<br/>
    ///     SuggestionItem: An instance of the SuggestionItem class.
    /// </summary>
    public sealed partial class SuggestionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suggestion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionItem" /> class.
        /// </summary>
        /// <param name="suggestion"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestionItem(
            string suggestion,
            int score)
        {
            this.Suggestion = suggestion ?? throw new global::System.ArgumentNullException(nameof(suggestion));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionItem" /> class.
        /// </summary>
        public SuggestionItem()
        {
        }

    }
}