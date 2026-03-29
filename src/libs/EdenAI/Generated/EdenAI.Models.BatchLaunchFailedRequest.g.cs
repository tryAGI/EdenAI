
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchLaunchFailedRequest
    {
        /// <summary>
        /// Request name, if any were given
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicId { get; set; }

        /// <summary>
        /// Parameters passed to the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Body { get; set; }

        /// <summary>
        /// Error received from the request validator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLaunchFailedRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Request name, if any were given
        /// </param>
        /// <param name="publicId">
        /// Request ID
        /// </param>
        /// <param name="body">
        /// Parameters passed to the request
        /// </param>
        /// <param name="errors">
        /// Error received from the request validator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchLaunchFailedRequest(
            string name,
            int publicId,
            object body,
            object errors)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PublicId = publicId;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchLaunchFailedRequest" /> class.
        /// </summary>
        public BatchLaunchFailedRequest()
        {
        }
    }
}