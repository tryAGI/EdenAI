
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeExtractedData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personal_infos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumePersonalInfo PersonalInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("education")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumeEducation Education { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_experience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumeWorkExp WorkExperience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeLang>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifications")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? Certifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("courses")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? Courses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publications")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? Publications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interests")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? Interests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeExtractedData" /> class.
        /// </summary>
        /// <param name="personalInfos"></param>
        /// <param name="education"></param>
        /// <param name="workExperience"></param>
        /// <param name="languages"></param>
        /// <param name="skills"></param>
        /// <param name="certifications"></param>
        /// <param name="courses"></param>
        /// <param name="publications"></param>
        /// <param name="interests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeExtractedData(
            global::EdenAI.ResumePersonalInfo personalInfos,
            global::EdenAI.ResumeEducation education,
            global::EdenAI.ResumeWorkExp workExperience,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeLang>? languages,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? skills,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? certifications,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? courses,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? publications,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>? interests)
        {
            this.PersonalInfos = personalInfos ?? throw new global::System.ArgumentNullException(nameof(personalInfos));
            this.Education = education ?? throw new global::System.ArgumentNullException(nameof(education));
            this.WorkExperience = workExperience ?? throw new global::System.ArgumentNullException(nameof(workExperience));
            this.Languages = languages;
            this.Skills = skills;
            this.Certifications = certifications;
            this.Courses = courses;
            this.Publications = publications;
            this.Interests = interests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeExtractedData" /> class.
        /// </summary>
        public ResumeExtractedData()
        {
        }

    }
}