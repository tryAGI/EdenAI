
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LaunchAsyncJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PublicId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchAsyncJobResponse" /> class.
        /// </summary>
        /// <param name="publicId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LaunchAsyncJobResponse(
            global::System.Guid publicId)
        {
            this.PublicId = publicId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchAsyncJobResponse" /> class.
        /// </summary>
        public LaunchAsyncJobResponse()
        {
        }
    }
}