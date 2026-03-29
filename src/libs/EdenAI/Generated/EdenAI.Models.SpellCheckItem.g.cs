
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Represents a spell check item with suggestions.<br/>
    /// Args:<br/>
    ///     text (str): The text to spell check.<br/>
    ///     type (str, optional): The type of the text.<br/>
    ///     offset (int): The offset of the text.<br/>
    ///     length (int): The length of the text.<br/>
    ///     suggestions (Sequence[SuggestionItem], optional): The list of suggestions for the misspelled text.<br/>
    /// Raises:<br/>
    ///     ValueError: If the offset or length is not positive.<br/>
    /// Returns:<br/>
    ///     SpellCheckItem: An instance of the SpellCheckItem class.
    /// </summary>
    public sealed partial class SpellCheckItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        public global::System.Collections.Generic.IList<global::EdenAI.SuggestionItem>? Suggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellCheckItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="suggestions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpellCheckItem(
            string text,
            string type,
            int offset,
            int length,
            global::System.Collections.Generic.IList<global::EdenAI.SuggestionItem>? suggestions)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Offset = offset;
            this.Length = length;
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellCheckItem" /> class.
        /// </summary>
        public SpellCheckItem()
        {
        }
    }
}