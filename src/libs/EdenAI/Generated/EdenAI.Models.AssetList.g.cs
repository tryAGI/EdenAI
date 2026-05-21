
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubResource { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetList" /> class.
        /// </summary>
        /// <param name="subResource"></param>
        /// <param name="data">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetList(
            string subResource,
            byte[] data = default!)
        {
            this.SubResource = subResource ?? throw new global::System.ArgumentNullException(nameof(subResource));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetList" /> class.
        /// </summary>
        public AssetList()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AssetList"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AssetList FromSubResource(string subResource)
        {
            return new AssetList
            {
                SubResource = subResource,
            };
        }

    }
}