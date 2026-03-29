
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceEmotions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Joy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sorrow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sorrow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Anger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surprise")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Surprise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disgust")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Disgust { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fear")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Fear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confusion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Calm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unknown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neutral")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Neutral { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Contempt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceEmotions" /> class.
        /// </summary>
        /// <param name="joy"></param>
        /// <param name="sorrow"></param>
        /// <param name="anger"></param>
        /// <param name="surprise"></param>
        /// <param name="disgust"></param>
        /// <param name="fear"></param>
        /// <param name="confusion"></param>
        /// <param name="calm"></param>
        /// <param name="unknown"></param>
        /// <param name="neutral"></param>
        /// <param name="contempt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceEmotions(
            int joy,
            int sorrow,
            int anger,
            int surprise,
            int disgust,
            int fear,
            int confusion,
            int calm,
            int unknown,
            int neutral,
            int contempt)
        {
            this.Joy = joy;
            this.Sorrow = sorrow;
            this.Anger = anger;
            this.Surprise = surprise;
            this.Disgust = disgust;
            this.Fear = fear;
            this.Confusion = confusion;
            this.Calm = calm;
            this.Unknown = unknown;
            this.Neutral = neutral;
            this.Contempt = contempt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceEmotions" /> class.
        /// </summary>
        public FaceEmotions()
        {
        }
    }
}