
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogoItem
    {
        /// <summary>
        /// Default Value: {"vertices":[]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_poly")]
        public global::EdenAI.LogoBoundingPoly? BoundingPoly { get; set; }

        /// <summary>
        /// Name of the logo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Confidence score how sure it's this is a real logo.
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
        /// Initializes a new instance of the <see cref="LogoItem" /> class.
        /// </summary>
        /// <param name="description">
        /// Name of the logo
        /// </param>
        /// <param name="score">
        /// Confidence score how sure it's this is a real logo.
        /// </param>
        /// <param name="boundingPoly">
        /// Default Value: {"vertices":[]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogoItem(
            string description,
            int score,
            global::EdenAI.LogoBoundingPoly? boundingPoly)
        {
            this.BoundingPoly = boundingPoly;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoItem" /> class.
        /// </summary>
        public LogoItem()
        {
        }
    }
}