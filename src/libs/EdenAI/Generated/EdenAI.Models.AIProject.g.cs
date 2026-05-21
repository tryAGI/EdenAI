
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIProject
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// * `AskYoDa` - Askyoda<br/>
        /// * `Translathor` - Translathor<br/>
        /// * `X-Merge` - X Merge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.ProjectTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ProjectTypeEnum ProjectType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIProject" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectType">
        /// * `AskYoDa` - Askyoda<br/>
        /// * `Translathor` - Translathor<br/>
        /// * `X-Merge` - X Merge
        /// </param>
        /// <param name="user"></param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIProject(
            string projectName,
            global::EdenAI.ProjectTypeEnum projectType,
            global::System.Guid user,
            global::System.Guid projectId = default!,
            global::System.DateTime createdAt = default!)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ProjectType = projectType;
            this.CreatedAt = createdAt;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIProject" /> class.
        /// </summary>
        public AIProject()
        {
        }

    }
}