
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeWorkExp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_years_experience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalYearsExperience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::EdenAI.ResumeWorkExpEntry>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeWorkExp" /> class.
        /// </summary>
        /// <param name="totalYearsExperience"></param>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeWorkExp(
            string totalYearsExperience,
            global::System.Collections.Generic.IList<global::EdenAI.ResumeWorkExpEntry>? entries)
        {
            this.TotalYearsExperience = totalYearsExperience ?? throw new global::System.ArgumentNullException(nameof(totalYearsExperience));
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeWorkExp" /> class.
        /// </summary>
        public ResumeWorkExp()
        {
        }
    }
}