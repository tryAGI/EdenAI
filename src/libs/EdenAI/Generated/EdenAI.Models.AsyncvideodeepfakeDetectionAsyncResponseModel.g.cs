
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncvideodeepfakeDetectionAsyncResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.VideodeepfakeDetectionAsyncModel Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PublicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncvideodeepfakeDetectionAsyncResponseModel" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="error"></param>
        /// <param name="publicId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncvideodeepfakeDetectionAsyncResponseModel(
            global::EdenAI.VideodeepfakeDetectionAsyncModel results,
            string error,
            global::System.Guid publicId,
            string status)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.PublicId = publicId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncvideodeepfakeDetectionAsyncResponseModel" /> class.
        /// </summary>
        public AsyncvideodeepfakeDetectionAsyncResponseModel()
        {
        }

    }
}