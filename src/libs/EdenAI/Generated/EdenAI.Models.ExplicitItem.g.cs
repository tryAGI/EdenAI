
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExplicitItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likelihood")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Likelihood { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likelihood_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikelihoodScore { get; set; }

        /// <summary>
        /// This enum are used to categorize the explicit content extracted from the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.CategoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.CategoryType Category { get; set; }

        /// <summary>
        /// The subcategory of content. Possible values:<br/>
        /// Toxic Subcategories:<br/>
        /// - Insult<br/>
        /// - Obscene<br/>
        /// - Derogatory<br/>
        /// - Profanity<br/>
        /// - Threat<br/>
        /// - Toxic<br/>
        /// Content Subcategories:<br/>
        /// - MiddleFinger<br/>
        /// - PublicSafety<br/>
        /// - Health<br/>
        /// - Explicit<br/>
        /// - QRCode<br/>
        /// - Medical<br/>
        /// - Politics<br/>
        /// - Legal<br/>
        /// Sexual Subcategories:<br/>
        /// - SexualActivity<br/>
        /// - SexualSituations<br/>
        /// - Nudity<br/>
        /// - PartialNudity<br/>
        /// - Suggestive<br/>
        /// - AdultToys<br/>
        /// - RevealingClothes<br/>
        /// - Sexual<br/>
        /// Violence Subcategories:<br/>
        /// - GraphicViolenceOrGore<br/>
        /// - PhysicalViolence<br/>
        /// - WeaponViolence<br/>
        /// - Violence<br/>
        /// Drug and Alcohol Subcategories:<br/>
        /// - DrugProducts<br/>
        /// - DrugUse<br/>
        /// - Tobacco<br/>
        /// - Smoking<br/>
        /// - Alcohol<br/>
        /// - Drinking<br/>
        /// Finance Subcategories:<br/>
        /// - Gambling<br/>
        /// - Finance<br/>
        /// - MoneyContent<br/>
        /// Hate and Extremism Subcategories:<br/>
        /// - Hate<br/>
        /// - Harassment<br/>
        /// - Threatening<br/>
        /// - Extremist<br/>
        /// - Racy<br/>
        /// Safe Subcategories:<br/>
        /// - Safe<br/>
        /// - NotSafe<br/>
        /// Other Subcategories:<br/>
        /// - Spoof<br/>
        /// - Religion<br/>
        /// - Offensive<br/>
        /// - Other
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subcategory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subcategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitItem" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="likelihood"></param>
        /// <param name="likelihoodScore"></param>
        /// <param name="category">
        /// This enum are used to categorize the explicit content extracted from the text
        /// </param>
        /// <param name="subcategory">
        /// The subcategory of content. Possible values:<br/>
        /// Toxic Subcategories:<br/>
        /// - Insult<br/>
        /// - Obscene<br/>
        /// - Derogatory<br/>
        /// - Profanity<br/>
        /// - Threat<br/>
        /// - Toxic<br/>
        /// Content Subcategories:<br/>
        /// - MiddleFinger<br/>
        /// - PublicSafety<br/>
        /// - Health<br/>
        /// - Explicit<br/>
        /// - QRCode<br/>
        /// - Medical<br/>
        /// - Politics<br/>
        /// - Legal<br/>
        /// Sexual Subcategories:<br/>
        /// - SexualActivity<br/>
        /// - SexualSituations<br/>
        /// - Nudity<br/>
        /// - PartialNudity<br/>
        /// - Suggestive<br/>
        /// - AdultToys<br/>
        /// - RevealingClothes<br/>
        /// - Sexual<br/>
        /// Violence Subcategories:<br/>
        /// - GraphicViolenceOrGore<br/>
        /// - PhysicalViolence<br/>
        /// - WeaponViolence<br/>
        /// - Violence<br/>
        /// Drug and Alcohol Subcategories:<br/>
        /// - DrugProducts<br/>
        /// - DrugUse<br/>
        /// - Tobacco<br/>
        /// - Smoking<br/>
        /// - Alcohol<br/>
        /// - Drinking<br/>
        /// Finance Subcategories:<br/>
        /// - Gambling<br/>
        /// - Finance<br/>
        /// - MoneyContent<br/>
        /// Hate and Extremism Subcategories:<br/>
        /// - Hate<br/>
        /// - Harassment<br/>
        /// - Threatening<br/>
        /// - Extremist<br/>
        /// - Racy<br/>
        /// Safe Subcategories:<br/>
        /// - Safe<br/>
        /// - NotSafe<br/>
        /// Other Subcategories:<br/>
        /// - Spoof<br/>
        /// - Religion<br/>
        /// - Offensive<br/>
        /// - Other
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplicitItem(
            string label,
            int likelihood,
            int likelihoodScore,
            global::EdenAI.CategoryType category,
            string subcategory)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Likelihood = likelihood;
            this.LikelihoodScore = likelihoodScore;
            this.Category = category;
            this.Subcategory = subcategory ?? throw new global::System.ArgumentNullException(nameof(subcategory));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitItem" /> class.
        /// </summary>
        public ExplicitItem()
        {
        }
    }
}