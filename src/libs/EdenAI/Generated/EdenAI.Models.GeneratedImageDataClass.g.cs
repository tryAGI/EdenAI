
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedImageDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_resource_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageResourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImageDataClass" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imageResourceUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedImageDataClass(
            string image,
            string imageResourceUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.ImageResourceUrl = imageResourceUrl ?? throw new global::System.ArgumentNullException(nameof(imageResourceUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImageDataClass" /> class.
        /// </summary>
        public GeneratedImageDataClass()
        {
        }
    }
}