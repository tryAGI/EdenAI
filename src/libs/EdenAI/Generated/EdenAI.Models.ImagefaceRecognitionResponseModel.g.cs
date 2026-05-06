
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagefaceRecognitionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? Amazon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facepp")]
        public global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? Facepp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceRecognitionResponseModel" /> class.
        /// </summary>
        /// <param name="amazon"></param>
        /// <param name="microsoft"></param>
        /// <param name="facepp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagefaceRecognitionResponseModel(
            global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? amazon,
            global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? microsoft,
            global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass? facepp)
        {
            this.Amazon = amazon;
            this.Microsoft = microsoft;
            this.Facepp = facepp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagefaceRecognitionResponseModel" /> class.
        /// </summary>
        public ImagefaceRecognitionResponseModel()
        {
        }
    }
}