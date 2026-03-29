
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceHair
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hair_color")]
        public global::System.Collections.Generic.IList<global::EdenAI.FaceHairColor>? HairColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bald")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bald { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invisible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Invisible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceHair" /> class.
        /// </summary>
        /// <param name="bald"></param>
        /// <param name="invisible"></param>
        /// <param name="hairColor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceHair(
            int bald,
            bool invisible,
            global::System.Collections.Generic.IList<global::EdenAI.FaceHairColor>? hairColor)
        {
            this.HairColor = hairColor;
            this.Bald = bald;
            this.Invisible = invisible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceHair" /> class.
        /// </summary>
        public FaceHair()
        {
        }
    }
}