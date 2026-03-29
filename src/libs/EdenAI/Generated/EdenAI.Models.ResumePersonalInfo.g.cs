
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumePersonalInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumePersonalName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ResumeLocation Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SelfSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_of_birth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DateOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("place_of_birth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaceOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phones")]
        public global::System.Collections.Generic.IList<string>? Phones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mails")]
        public global::System.Collections.Generic.IList<string>? Mails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fax")]
        public global::System.Collections.Generic.IList<string>? Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_profession")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentProfession { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nationality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nationality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("martial_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MartialStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_salary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentSalary { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability")]
        public string? Availability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePersonalInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="selfSummary"></param>
        /// <param name="objective"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="currentProfession"></param>
        /// <param name="gender"></param>
        /// <param name="nationality"></param>
        /// <param name="martialStatus"></param>
        /// <param name="currentSalary"></param>
        /// <param name="phones"></param>
        /// <param name="mails"></param>
        /// <param name="urls"></param>
        /// <param name="fax"></param>
        /// <param name="availability">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumePersonalInfo(
            global::EdenAI.ResumePersonalName name,
            global::EdenAI.ResumeLocation address,
            string selfSummary,
            string objective,
            string dateOfBirth,
            string placeOfBirth,
            string currentProfession,
            string gender,
            string nationality,
            string martialStatus,
            string currentSalary,
            global::System.Collections.Generic.IList<string>? phones,
            global::System.Collections.Generic.IList<string>? mails,
            global::System.Collections.Generic.IList<string>? urls,
            global::System.Collections.Generic.IList<string>? fax,
            string? availability)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.SelfSummary = selfSummary ?? throw new global::System.ArgumentNullException(nameof(selfSummary));
            this.Objective = objective ?? throw new global::System.ArgumentNullException(nameof(objective));
            this.DateOfBirth = dateOfBirth ?? throw new global::System.ArgumentNullException(nameof(dateOfBirth));
            this.PlaceOfBirth = placeOfBirth ?? throw new global::System.ArgumentNullException(nameof(placeOfBirth));
            this.Phones = phones;
            this.Mails = mails;
            this.Urls = urls;
            this.Fax = fax;
            this.CurrentProfession = currentProfession ?? throw new global::System.ArgumentNullException(nameof(currentProfession));
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.Nationality = nationality ?? throw new global::System.ArgumentNullException(nameof(nationality));
            this.MartialStatus = martialStatus ?? throw new global::System.ArgumentNullException(nameof(martialStatus));
            this.CurrentSalary = currentSalary ?? throw new global::System.ArgumentNullException(nameof(currentSalary));
            this.Availability = availability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePersonalInfo" /> class.
        /// </summary>
        public ResumePersonalInfo()
        {
        }
    }
}