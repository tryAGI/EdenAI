
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogoBoundingPoly
    {
        /// <summary>
        /// Vertices of the logos in the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertices")]
        public global::System.Collections.Generic.IList<global::EdenAI.LogoVertice>? Vertices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoBoundingPoly" /> class.
        /// </summary>
        /// <param name="vertices">
        /// Vertices of the logos in the image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogoBoundingPoly(
            global::System.Collections.Generic.IList<global::EdenAI.LogoVertice>? vertices)
        {
            this.Vertices = vertices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoBoundingPoly" /> class.
        /// </summary>
        public LogoBoundingPoly()
        {
        }

    }
}