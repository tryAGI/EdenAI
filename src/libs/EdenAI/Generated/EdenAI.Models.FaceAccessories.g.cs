
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceAccessories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunglasses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sunglasses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_glasses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadingGlasses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swimming_goggles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SwimmingGoggles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FaceMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyeglasses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Eyeglasses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headwear")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Headwear { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAccessories" /> class.
        /// </summary>
        /// <param name="sunglasses"></param>
        /// <param name="readingGlasses"></param>
        /// <param name="swimmingGoggles"></param>
        /// <param name="faceMask"></param>
        /// <param name="eyeglasses"></param>
        /// <param name="headwear"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceAccessories(
            int sunglasses,
            int readingGlasses,
            int swimmingGoggles,
            int faceMask,
            int eyeglasses,
            int headwear)
        {
            this.Sunglasses = sunglasses;
            this.ReadingGlasses = readingGlasses;
            this.SwimmingGoggles = swimmingGoggles;
            this.FaceMask = faceMask;
            this.Eyeglasses = eyeglasses;
            this.Headwear = headwear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAccessories" /> class.
        /// </summary>
        public FaceAccessories()
        {
        }
    }
}