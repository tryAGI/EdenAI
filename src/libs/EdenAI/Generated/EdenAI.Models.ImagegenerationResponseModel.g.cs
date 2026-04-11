
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImagegenerationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytedance")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Bytedance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimax")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Minimax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leonardo")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Leonardo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Openai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Replicate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepai")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Deepai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stabilityai")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Stabilityai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon")]
        public global::EdenAI.ImagegenerationGenerationDataClass? Amazon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagegenerationResponseModel" /> class.
        /// </summary>
        /// <param name="bytedance"></param>
        /// <param name="minimax"></param>
        /// <param name="leonardo"></param>
        /// <param name="openai"></param>
        /// <param name="replicate"></param>
        /// <param name="deepai"></param>
        /// <param name="stabilityai"></param>
        /// <param name="amazon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagegenerationResponseModel(
            global::EdenAI.ImagegenerationGenerationDataClass? bytedance,
            global::EdenAI.ImagegenerationGenerationDataClass? minimax,
            global::EdenAI.ImagegenerationGenerationDataClass? leonardo,
            global::EdenAI.ImagegenerationGenerationDataClass? openai,
            global::EdenAI.ImagegenerationGenerationDataClass? replicate,
            global::EdenAI.ImagegenerationGenerationDataClass? deepai,
            global::EdenAI.ImagegenerationGenerationDataClass? stabilityai,
            global::EdenAI.ImagegenerationGenerationDataClass? amazon)
        {
            this.Bytedance = bytedance;
            this.Minimax = minimax;
            this.Leonardo = leonardo;
            this.Openai = openai;
            this.Replicate = replicate;
            this.Deepai = deepai;
            this.Stabilityai = stabilityai;
            this.Amazon = amazon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagegenerationResponseModel" /> class.
        /// </summary>
        public ImagegenerationResponseModel()
        {
        }
    }
}