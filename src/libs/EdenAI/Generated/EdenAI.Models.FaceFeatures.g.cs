
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyes_open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EyesOpen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Smile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MouthOpen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFeatures" /> class.
        /// </summary>
        /// <param name="eyesOpen"></param>
        /// <param name="smile"></param>
        /// <param name="mouthOpen"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceFeatures(
            int eyesOpen,
            int smile,
            int mouthOpen)
        {
            this.EyesOpen = eyesOpen;
            this.Smile = smile;
            this.MouthOpen = mouthOpen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFeatures" /> class.
        /// </summary>
        public FaceFeatures()
        {
        }
    }
}