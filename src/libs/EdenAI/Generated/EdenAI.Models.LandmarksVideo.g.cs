
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LandmarksVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_left")]
        public global::System.Collections.Generic.IList<int>? EyeLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_right")]
        public global::System.Collections.Generic.IList<int>? EyeRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nose")]
        public global::System.Collections.Generic.IList<int>? Nose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_left")]
        public global::System.Collections.Generic.IList<int>? MouthLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_right")]
        public global::System.Collections.Generic.IList<int>? MouthRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarksVideo" /> class.
        /// </summary>
        /// <param name="eyeLeft"></param>
        /// <param name="eyeRight"></param>
        /// <param name="nose"></param>
        /// <param name="mouthLeft"></param>
        /// <param name="mouthRight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LandmarksVideo(
            global::System.Collections.Generic.IList<int>? eyeLeft,
            global::System.Collections.Generic.IList<int>? eyeRight,
            global::System.Collections.Generic.IList<int>? nose,
            global::System.Collections.Generic.IList<int>? mouthLeft,
            global::System.Collections.Generic.IList<int>? mouthRight)
        {
            this.EyeLeft = eyeLeft;
            this.EyeRight = eyeRight;
            this.Nose = nose;
            this.MouthLeft = mouthLeft;
            this.MouthRight = mouthRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LandmarksVideo" /> class.
        /// </summary>
        public LandmarksVideo()
        {
        }
    }
}