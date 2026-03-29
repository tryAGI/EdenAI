
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceFacialHair
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moustache")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Moustache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Beard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sideburns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sideburns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFacialHair" /> class.
        /// </summary>
        /// <param name="moustache"></param>
        /// <param name="beard"></param>
        /// <param name="sideburns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceFacialHair(
            int moustache,
            int beard,
            int sideburns)
        {
            this.Moustache = moustache;
            this.Beard = beard;
            this.Sideburns = sideburns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceFacialHair" /> class.
        /// </summary>
        public FaceFacialHair()
        {
        }
    }
}