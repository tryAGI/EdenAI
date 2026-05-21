
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageautomlClassificationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nyckel")]
        public global::EdenAI.ImageautomlClassificationAutomlClassificationCreateProjectDataClass? Nyckel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageautomlClassificationResponseModel" /> class.
        /// </summary>
        /// <param name="nyckel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageautomlClassificationResponseModel(
            global::EdenAI.ImageautomlClassificationAutomlClassificationCreateProjectDataClass? nyckel)
        {
            this.Nyckel = nyckel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageautomlClassificationResponseModel" /> class.
        /// </summary>
        public ImageautomlClassificationResponseModel()
        {
        }

    }
}