
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// This model represents an entity extracted from the text.<br/>
    /// Attributes:<br/>
    ///     offset (int): The offset of the entity in the text.<br/>
    ///     length (int): The lenght of the entity in the text.<br/>
    ///     category (CategoryType): The category of the entity.<br/>
    ///     subcategory (SubCategoryType): The subcategory of the entity.<br/>
    ///     original_label (str): The original label of the entity.<br/>
    ///     content (str): The content of the entity.
    /// </summary>
    public sealed partial class AnonymizationEntity
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("original_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationEntity" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="category">
        /// This enum are used to categorize the explicit content extracted from the text
        /// </param>
        /// <param name="subcategory"></param>
        /// <param name="originalLabel"></param>
        /// <param name="content"></param>
        /// <param name="confidenceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnonymizationEntity(
            int offset,
            int length,
            global::EdenAI.CategoryType category,
            global::EdenAI.SubCategoryType subcategory,
            string originalLabel,
            string content,
            int confidenceScore)
        {
            this.Offset = offset;
            this.Length = length;
            this.Category = category;
            this.Subcategory = subcategory;
            this.OriginalLabel = originalLabel ?? throw new global::System.ArgumentNullException(nameof(originalLabel));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationEntity" /> class.
        /// </summary>
        public AnonymizationEntity()
        {
        }

    }
}