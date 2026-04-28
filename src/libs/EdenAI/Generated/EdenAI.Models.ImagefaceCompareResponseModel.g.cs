
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagefaceCompareResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImagefaceCompareFaceCompareDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facepp")]
        public global::EdenAI.ImagefaceCompareFaceCompareDataClass? Facepp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public global::EdenAI.ImagefaceCompareFaceCompareDataClass? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceCompareResponseModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="facepp"></param>
        /// <param name="base64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagefaceCompareResponseModel(
            global::EdenAI.ImagefaceCompareFaceCompareDataClass? amazon,
            global::EdenAI.ImagefaceCompareFaceCompareDataClass? facepp,
            global::EdenAI.ImagefaceCompareFaceCompareDataClass? base64)
        {
            this.Amazon = amazon;
            this.Facepp = facepp;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceCompareResponseModel" /> class.
        /// </summary>
        public ImagefaceCompareResponseModel()
        {
        }
    }
}