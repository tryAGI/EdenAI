
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeEducation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_years_education")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalYearsEducation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeEducationEntry>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeEducation" /> class.
        /// </summary>
        /// <param name="totalYearsEducation"></param>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeEducation(
            int totalYearsEducation,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeEducationEntry>? entries)
        {
            this.TotalYearsEducation = totalYearsEducation;
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeEducation" /> class.
        /// </summary>
        public ResumeEducation()
        {
        }
    }
}