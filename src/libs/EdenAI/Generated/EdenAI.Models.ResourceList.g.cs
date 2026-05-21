
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// * `db` - Db<br/>
        /// * `bucket` - Bucket<br/>
        /// * `db_vector` - Db Vector<br/>
        /// * `ai` - Ai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.TypeDe8EnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.TypeDe8Enum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EdenAI.AssetList> Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceList" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="type">
        /// * `db` - Db<br/>
        /// * `bucket` - Bucket<br/>
        /// * `db_vector` - Db Vector<br/>
        /// * `ai` - Ai
        /// </param>
        /// <param name="provider"></param>
        /// <param name="assets"></param>
        /// <param name="data">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceList(
            string resource,
            global::EdenAI.TypeDe8Enum type,
            string provider,
            global::System.Collections.Generic.IList<global::EdenAI.AssetList> assets,
            byte[]? data)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Data = data;
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceList" /> class.
        /// </summary>
        public ResourceList()
        {
        }

    }
}