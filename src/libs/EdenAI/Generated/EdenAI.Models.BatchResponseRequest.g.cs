
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchResponseRequest
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        public int PublicId { get; set; } = default!;

        /// <summary>
        /// * `succeeded` - Status Succeeded<br/>
        /// * `failed` - Status Failed<br/>
        /// * `finished` - Status Finished<br/>
        /// * `processing` - Status Processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.Status889EnumJsonConverter))]
        public global::EdenAI.Status889Enum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponseRequest" /> class.
        /// </summary>
        /// <param name="status">
        /// * `succeeded` - Status Succeeded<br/>
        /// * `failed` - Status Failed<br/>
        /// * `finished` - Status Finished<br/>
        /// * `processing` - Status Processing
        /// </param>
        /// <param name="name"></param>
        /// <param name="errors"></param>
        /// <param name="response"></param>
        /// <param name="publicId">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResponseRequest(
            global::EdenAI.Status889Enum? status,
            string? name,
            object? errors,
            object? response,
            int publicId = default!)
        {
            this.PublicId = publicId;
            this.Status = status;
            this.Name = name;
            this.Errors = errors;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponseRequest" /> class.
        /// </summary>
        public BatchResponseRequest()
        {
        }

    }
}