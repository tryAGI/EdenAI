
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogoTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking")]
        public global::System.Collections.Generic.IList<global::EdenAI.VideoLogo>? Tracking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoTrack" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="tracking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogoTrack(
            string description,
            global::System.Collections.Generic.IList<global::EdenAI.VideoLogo>? tracking)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Tracking = tracking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoTrack" /> class.
        /// </summary>
        public LogoTrack()
        {
        }
    }
}