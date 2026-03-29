
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumePersonalName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Middle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sufix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sufix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePersonalName" /> class.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="rawName"></param>
        /// <param name="middle"></param>
        /// <param name="title"></param>
        /// <param name="prefix"></param>
        /// <param name="sufix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumePersonalName(
            string firstName,
            string lastName,
            string rawName,
            string middle,
            string title,
            string prefix,
            string sufix)
        {
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.RawName = rawName ?? throw new global::System.ArgumentNullException(nameof(rawName));
            this.Middle = middle ?? throw new global::System.ArgumentNullException(nameof(middle));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.Sufix = sufix ?? throw new global::System.ArgumentNullException(nameof(sufix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumePersonalName" /> class.
        /// </summary>
        public ResumePersonalName()
        {
        }
    }
}