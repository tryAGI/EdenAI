
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomlClassificationListProjectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EdenAI.AutomlClassificationProject> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomlClassificationListProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomlClassificationListProjectsResponse(
            global::System.Collections.Generic.IList<global::EdenAI.AutomlClassificationProject> projects)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomlClassificationListProjectsResponse" /> class.
        /// </summary>
        public AutomlClassificationListProjectsResponse()
        {
        }
    }
}