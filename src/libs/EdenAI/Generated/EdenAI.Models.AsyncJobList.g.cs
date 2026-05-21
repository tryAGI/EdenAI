
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncJobList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Nb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbOk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PublicId { get; set; }

        /// <summary>
        /// * `finished` - finished<br/>
        /// * `failed` - failed<br/>
        /// * `Timeout error` - Timeout error<br/>
        /// * `processing` - processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.StateEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.StateEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobList" /> class.
        /// </summary>
        /// <param name="providers"></param>
        /// <param name="nb"></param>
        /// <param name="nbOk"></param>
        /// <param name="publicId"></param>
        /// <param name="state">
        /// * `finished` - finished<br/>
        /// * `failed` - failed<br/>
        /// * `Timeout error` - Timeout error<br/>
        /// * `processing` - processing
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobList(
            string providers,
            int nb,
            int nbOk,
            global::System.Guid publicId,
            global::EdenAI.StateEnum state,
            global::System.DateTime createdAt)
        {
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.Nb = nb;
            this.NbOk = nbOk;
            this.PublicId = publicId;
            this.State = state;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobList" /> class.
        /// </summary>
        public AsyncJobList()
        {
        }

    }
}