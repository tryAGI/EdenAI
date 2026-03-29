
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetListRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubResource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetListRequest" /> class.
        /// </summary>
        /// <param name="subResource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetListRequest(
            string subResource)
        {
            this.SubResource = subResource ?? throw new global::System.ArgumentNullException(nameof(subResource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetListRequest" /> class.
        /// </summary>
        public AssetListRequest()
        {
        }
    }
}