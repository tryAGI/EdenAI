
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagesearchResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nyckel")]
        public global::EdenAI.ImagesearchSearchDeleteImageDataClass? Nyckel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImagesearchSearchDeleteImageDataClass? Sentisight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesearchResponseModel" /> class.
        /// </summary>
        /// <param name="nyckel"></param>
        /// <param name="sentisight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesearchResponseModel(
            global::EdenAI.ImagesearchSearchDeleteImageDataClass? nyckel,
            global::EdenAI.ImagesearchSearchDeleteImageDataClass? sentisight)
        {
            this.Nyckel = nyckel;
            this.Sentisight = sentisight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesearchResponseModel" /> class.
        /// </summary>
        public ImagesearchResponseModel()
        {
        }
    }
}