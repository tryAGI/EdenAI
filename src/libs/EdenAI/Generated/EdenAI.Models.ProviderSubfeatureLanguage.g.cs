
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderSubfeatureLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSubfeatureLanguage" /> class.
        /// </summary>
        /// <param name="languageName"></param>
        /// <param name="languageCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderSubfeatureLanguage(
            string languageName,
            string languageCode)
        {
            this.LanguageName = languageName ?? throw new global::System.ArgumentNullException(nameof(languageName));
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSubfeatureLanguage" /> class.
        /// </summary>
        public ProviderSubfeatureLanguage()
        {
        }

    }
}