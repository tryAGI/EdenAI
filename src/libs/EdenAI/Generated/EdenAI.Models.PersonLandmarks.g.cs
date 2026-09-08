
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
        public global::System.Collections.Generic.IList<double>? EyeLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_right")]
        public global::System.Collections.Generic.IList<double>? EyeRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nose")]
        public global::System.Collections.Generic.IList<double>? Nose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ear_left")]
        public global::System.Collections.Generic.IList<double>? EarLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ear_right")]
        public global::System.Collections.Generic.IList<double>? EarRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoulder_left")]
        public global::System.Collections.Generic.IList<double>? ShoulderLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoulder_right")]
        public global::System.Collections.Generic.IList<double>? ShoulderRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elbow_left")]
        public global::System.Collections.Generic.IList<double>? ElbowLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elbow_right")]
        public global::System.Collections.Generic.IList<double>? ElbowRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrist_left")]
        public global::System.Collections.Generic.IList<double>? WristLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrist_right")]
        public global::System.Collections.Generic.IList<double>? WristRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hip_left")]
        public global::System.Collections.Generic.IList<double>? HipLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hip_right")]
        public global::System.Collections.Generic.IList<double>? HipRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knee_left")]
        public global::System.Collections.Generic.IList<double>? KneeLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knee_right")]
        public global::System.Collections.Generic.IList<double>? KneeRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ankle_left")]
        public global::System.Collections.Generic.IList<double>? AnkleLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ankle_right")]
        public global::System.Collections.Generic.IList<double>? AnkleRight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_left")]
        public global::System.Collections.Generic.IList<double>? MouthLeft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_right")]
        public global::System.Collections.Generic.IList<double>? MouthRight { get; set; }

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
            global::System.Collections.Generic.IList<double>? eyeLeft,
            global::System.Collections.Generic.IList<double>? eyeRight,
            global::System.Collections.Generic.IList<double>? nose,
            global::System.Collections.Generic.IList<double>? earLeft,
            global::System.Collections.Generic.IList<double>? earRight,
            global::System.Collections.Generic.IList<double>? shoulderLeft,
            global::System.Collections.Generic.IList<double>? shoulderRight,
            global::System.Collections.Generic.IList<double>? elbowLeft,
            global::System.Collections.Generic.IList<double>? elbowRight,
            global::System.Collections.Generic.IList<double>? wristLeft,
            global::System.Collections.Generic.IList<double>? wristRight,
            global::System.Collections.Generic.IList<double>? hipLeft,
            global::System.Collections.Generic.IList<double>? hipRight,
            global::System.Collections.Generic.IList<double>? kneeLeft,
            global::System.Collections.Generic.IList<double>? kneeRight,
            global::System.Collections.Generic.IList<double>? ankleLeft,
            global::System.Collections.Generic.IList<double>? ankleRight,
            global::System.Collections.Generic.IList<double>? mouthLeft,
            global::System.Collections.Generic.IList<double>? mouthRight)
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