
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeEducationEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumeLocation Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("establishment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Establishment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpa")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gpa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accreditation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accreditation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeEducationEntry" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="location"></param>
        /// <param name="establishment"></param>
        /// <param name="description"></param>
        /// <param name="gpa"></param>
        /// <param name="accreditation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeEducationEntry(
            string title,
            string startDate,
            string endDate,
            global::EdenAI.ResumeLocation location,
            string establishment,
            string description,
            string gpa,
            string accreditation)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Establishment = establishment ?? throw new global::System.ArgumentNullException(nameof(establishment));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Gpa = gpa ?? throw new global::System.ArgumentNullException(nameof(gpa));
            this.Accreditation = accreditation ?? throw new global::System.ArgumentNullException(nameof(accreditation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeEducationEntry" /> class.
        /// </summary>
        public ResumeEducationEntry()
        {
        }

    }
}