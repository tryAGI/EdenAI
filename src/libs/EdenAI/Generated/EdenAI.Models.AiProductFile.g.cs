
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiProductFile
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string User { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string Project { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum>))]
        public global::EdenAI.OneOf<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum>? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_started_at")]
        public global::System.DateTime? TaskStartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductFile" /> class.
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="taskId"></param>
        /// <param name="taskStartedAt"></param>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <param name="fileId">
        /// Included only in responses
        /// </param>
        /// <param name="user">
        /// Included only in responses
        /// </param>
        /// <param name="project">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiProductFile(
            string fileType,
            global::EdenAI.OneOf<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum>? status,
            string? error,
            string? taskId,
            global::System.DateTime? taskStartedAt,
            string? filePath,
            string? fileName,
            global::System.Guid fileId = default!,
            string user = default!,
            string project = default!,
            global::System.DateTime createdAt = default!)
        {
            this.FileId = fileId;
            this.User = user;
            this.Project = project;
            this.FileType = fileType ?? throw new global::System.ArgumentNullException(nameof(fileType));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Error = error;
            this.TaskId = taskId;
            this.TaskStartedAt = taskStartedAt;
            this.FilePath = filePath;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductFile" /> class.
        /// </summary>
        public AiProductFile()
        {
        }
    }
}