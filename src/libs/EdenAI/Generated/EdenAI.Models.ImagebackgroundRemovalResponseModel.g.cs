
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagebackgroundRemovalResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stabilityai")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Stabilityai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoroom")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Photoroom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Microsoft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clipdrop")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Clipdrop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api4ai")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Api4ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picsart")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Picsart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentisight")]
        public global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? Sentisight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalResponseModel" /> class.
        /// </summary>
        /// <param name="stabilityai"></param>
        /// <param name="photoroom"></param>
        /// <param name="microsoft"></param>
        /// <param name="clipdrop"></param>
        /// <param name="api4ai"></param>
        /// <param name="picsart"></param>
        /// <param name="sentisight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagebackgroundRemovalResponseModel(
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? stabilityai,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? photoroom,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? microsoft,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? clipdrop,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? api4ai,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? picsart,
            global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass? sentisight)
        {
            this.Stabilityai = stabilityai;
            this.Photoroom = photoroom;
            this.Microsoft = microsoft;
            this.Clipdrop = clipdrop;
            this.Api4ai = api4ai;
            this.Picsart = picsart;
            this.Sentisight = sentisight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagebackgroundRemovalResponseModel" /> class.
        /// </summary>
        public ImagebackgroundRemovalResponseModel()
        {
        }
    }
}