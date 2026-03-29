
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderSubfeature
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::EdenAI.PricingSerialzier> Pricings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_working")]
        public bool? IsWorking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_title")]
        public string? DescriptionTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_content")]
        public string? DescriptionContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Feature Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subfeature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Subfeature Subfeature { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("constraints")]
        public object Constraints { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public object Models { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_models")]
        public object TtsModels { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_details")]
        public object LlmDetails { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeatureLanguage> Languages { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public string Phase { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string> Regions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSubfeature" /> class.
        /// </summary>
        /// <param name="pricings"></param>
        /// <param name="provider"></param>
        /// <param name="feature"></param>
        /// <param name="subfeature"></param>
        /// <param name="isWorking"></param>
        /// <param name="descriptionTitle"></param>
        /// <param name="descriptionContent"></param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="version">
        /// Included only in responses
        /// </param>
        /// <param name="constraints">
        /// Included only in responses
        /// </param>
        /// <param name="models">
        /// Included only in responses
        /// </param>
        /// <param name="ttsModels">
        /// Included only in responses
        /// </param>
        /// <param name="llmDetails">
        /// Included only in responses
        /// </param>
        /// <param name="languages">
        /// Included only in responses
        /// </param>
        /// <param name="phase">
        /// Included only in responses
        /// </param>
        /// <param name="regions">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderSubfeature(
            global::System.Collections.Generic.IList<global::EdenAI.PricingSerialzier> pricings,
            global::EdenAI.Provider provider,
            global::EdenAI.Feature feature,
            global::EdenAI.Subfeature subfeature,
            bool? isWorking,
            string? descriptionTitle,
            string? descriptionContent,
            string name = default!,
            string version = default!,
            object constraints = default!,
            object models = default!,
            object ttsModels = default!,
            object llmDetails = default!,
            global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeatureLanguage> languages = default!,
            string phase = default!,
            global::System.Collections.Generic.IList<string> regions = default!)
        {
            this.Name = name;
            this.Version = version;
            this.Pricings = pricings ?? throw new global::System.ArgumentNullException(nameof(pricings));
            this.IsWorking = isWorking;
            this.DescriptionTitle = descriptionTitle;
            this.DescriptionContent = descriptionContent;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.Subfeature = subfeature ?? throw new global::System.ArgumentNullException(nameof(subfeature));
            this.Constraints = constraints;
            this.Models = models;
            this.TtsModels = ttsModels;
            this.LlmDetails = llmDetails;
            this.Languages = languages;
            this.Phase = phase;
            this.Regions = regions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderSubfeature" /> class.
        /// </summary>
        public ProviderSubfeature()
        {
        }
    }
}