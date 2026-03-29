
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headwear")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Headwear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frontal_gaze")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FrontalGaze { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyes_visible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EyesVisible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glasses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Glasses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MouthOpen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smiling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Smiling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brightness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Brightness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sharpness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.VideoFacePoses Pose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAttributes" /> class.
        /// </summary>
        /// <param name="headwear"></param>
        /// <param name="frontalGaze"></param>
        /// <param name="eyesVisible"></param>
        /// <param name="glasses"></param>
        /// <param name="mouthOpen"></param>
        /// <param name="smiling"></param>
        /// <param name="brightness"></param>
        /// <param name="sharpness"></param>
        /// <param name="pose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceAttributes(
            int headwear,
            int frontalGaze,
            int eyesVisible,
            int glasses,
            int mouthOpen,
            int smiling,
            int brightness,
            int sharpness,
            global::EdenAI.VideoFacePoses pose)
        {
            this.Headwear = headwear;
            this.FrontalGaze = frontalGaze;
            this.EyesVisible = eyesVisible;
            this.Glasses = glasses;
            this.MouthOpen = mouthOpen;
            this.Smiling = smiling;
            this.Brightness = brightness;
            this.Sharpness = sharpness;
            this.Pose = pose ?? throw new global::System.ArgumentNullException(nameof(pose));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAttributes" /> class.
        /// </summary>
        public FaceAttributes()
        {
        }
    }
}