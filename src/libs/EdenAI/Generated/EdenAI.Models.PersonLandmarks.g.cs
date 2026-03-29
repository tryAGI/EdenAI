
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonLandmarks
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ear_left")]
        public global::System.Collections.Generic.IList<int>? EarLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ear_right")]
        public global::System.Collections.Generic.IList<int>? EarRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoulder_left")]
        public global::System.Collections.Generic.IList<int>? ShoulderLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoulder_right")]
        public global::System.Collections.Generic.IList<int>? ShoulderRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elbow_left")]
        public global::System.Collections.Generic.IList<int>? ElbowLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elbow_right")]
        public global::System.Collections.Generic.IList<int>? ElbowRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrist_left")]
        public global::System.Collections.Generic.IList<int>? WristLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrist_right")]
        public global::System.Collections.Generic.IList<int>? WristRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hip_left")]
        public global::System.Collections.Generic.IList<int>? HipLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hip_right")]
        public global::System.Collections.Generic.IList<int>? HipRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knee_left")]
        public global::System.Collections.Generic.IList<int>? KneeLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knee_right")]
        public global::System.Collections.Generic.IList<int>? KneeRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ankle_left")]
        public global::System.Collections.Generic.IList<int>? AnkleLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ankle_right")]
        public global::System.Collections.Generic.IList<int>? AnkleRight { get; set; }

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
        /// Initializes a new instance of the <see cref="PersonLandmarks" /> class.
        /// </summary>
        /// <param name="eyeLeft"></param>
        /// <param name="eyeRight"></param>
        /// <param name="nose"></param>
        /// <param name="earLeft"></param>
        /// <param name="earRight"></param>
        /// <param name="shoulderLeft"></param>
        /// <param name="shoulderRight"></param>
        /// <param name="elbowLeft"></param>
        /// <param name="elbowRight"></param>
        /// <param name="wristLeft"></param>
        /// <param name="wristRight"></param>
        /// <param name="hipLeft"></param>
        /// <param name="hipRight"></param>
        /// <param name="kneeLeft"></param>
        /// <param name="kneeRight"></param>
        /// <param name="ankleLeft"></param>
        /// <param name="ankleRight"></param>
        /// <param name="mouthLeft"></param>
        /// <param name="mouthRight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonLandmarks(
            global::System.Collections.Generic.IList<int>? eyeLeft,
            global::System.Collections.Generic.IList<int>? eyeRight,
            global::System.Collections.Generic.IList<int>? nose,
            global::System.Collections.Generic.IList<int>? earLeft,
            global::System.Collections.Generic.IList<int>? earRight,
            global::System.Collections.Generic.IList<int>? shoulderLeft,
            global::System.Collections.Generic.IList<int>? shoulderRight,
            global::System.Collections.Generic.IList<int>? elbowLeft,
            global::System.Collections.Generic.IList<int>? elbowRight,
            global::System.Collections.Generic.IList<int>? wristLeft,
            global::System.Collections.Generic.IList<int>? wristRight,
            global::System.Collections.Generic.IList<int>? hipLeft,
            global::System.Collections.Generic.IList<int>? hipRight,
            global::System.Collections.Generic.IList<int>? kneeLeft,
            global::System.Collections.Generic.IList<int>? kneeRight,
            global::System.Collections.Generic.IList<int>? ankleLeft,
            global::System.Collections.Generic.IList<int>? ankleRight,
            global::System.Collections.Generic.IList<int>? mouthLeft,
            global::System.Collections.Generic.IList<int>? mouthRight)
        {
            this.EyeLeft = eyeLeft;
            this.EyeRight = eyeRight;
            this.Nose = nose;
            this.EarLeft = earLeft;
            this.EarRight = earRight;
            this.ShoulderLeft = shoulderLeft;
            this.ShoulderRight = shoulderRight;
            this.ElbowLeft = elbowLeft;
            this.ElbowRight = elbowRight;
            this.WristLeft = wristLeft;
            this.WristRight = wristRight;
            this.HipLeft = hipLeft;
            this.HipRight = hipRight;
            this.KneeLeft = kneeLeft;
            this.KneeRight = kneeRight;
            this.AnkleLeft = ankleLeft;
            this.AnkleRight = ankleRight;
            this.MouthLeft = mouthLeft;
            this.MouthRight = mouthRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLandmarks" /> class.
        /// </summary>
        public PersonLandmarks()
        {
        }
    }
}