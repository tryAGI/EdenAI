
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfosNamedEntityRecognitionDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Importance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosNamedEntityRecognitionDataClass" /> class.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="category"></param>
        /// <param name="importance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfosNamedEntityRecognitionDataClass(
            string entity,
            string category,
            int importance)
        {
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Importance = importance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosNamedEntityRecognitionDataClass" /> class.
        /// </summary>
        public InfosNamedEntityRecognitionDataClass()
        {
        }

    }
}