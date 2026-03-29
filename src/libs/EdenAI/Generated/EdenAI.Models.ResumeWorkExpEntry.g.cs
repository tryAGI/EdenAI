
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeWorkExpEntry
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
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumeLocation Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Industry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeWorkExpEntry" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="company"></param>
        /// <param name="location"></param>
        /// <param name="description"></param>
        /// <param name="industry"></param>
        /// <param name="type">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeWorkExpEntry(
            string title,
            string startDate,
            string endDate,
            string company,
            global::EdenAI.ResumeLocation location,
            string description,
            string industry,
            string? type)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Industry = industry ?? throw new global::System.ArgumentNullException(nameof(industry));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeWorkExpEntry" /> class.
        /// </summary>
        public ResumeWorkExpEntry()
        {
        }
    }
}