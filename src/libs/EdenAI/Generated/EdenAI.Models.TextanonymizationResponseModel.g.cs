
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextanonymizationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateai")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Privateai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneai")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Oneai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emvista")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Emvista { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Xai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.TextanonymizationAnonymizationDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextanonymizationResponseModel" /> class.
        /// </summary>
        /// <param name="microsoft"></param>
        /// <param name="privateai"></param>
        /// <param name="oneai"></param>
        /// <param name="emvista"></param>
        /// <param name="xai"></param>
        /// <param name="openai"></param>
        /// <param name="amazon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextanonymizationResponseModel(
            global::EdenAI.TextanonymizationAnonymizationDataClass? microsoft,
            global::EdenAI.TextanonymizationAnonymizationDataClass? privateai,
            global::EdenAI.TextanonymizationAnonymizationDataClass? oneai,
            global::EdenAI.TextanonymizationAnonymizationDataClass? emvista,
            global::EdenAI.TextanonymizationAnonymizationDataClass? xai,
            global::EdenAI.TextanonymizationAnonymizationDataClass? openai,
            global::EdenAI.TextanonymizationAnonymizationDataClass? amazon)
        {
            this.Microsoft = microsoft;
            this.Privateai = privateai;
            this.Oneai = oneai;
            this.Emvista = emvista;
            this.Xai = xai;
            this.Openai = openai;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextanonymizationResponseModel" /> class.
        /// </summary>
        public TextanonymizationResponseModel()
        {
        }
    }
}