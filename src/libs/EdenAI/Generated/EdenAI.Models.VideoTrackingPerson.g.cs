
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTrackingPerson
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracked")]
        public global::System.Collections.Generic.IList<global::EdenAI.PersonTracking>? Tracked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTrackingPerson" /> class.
        /// </summary>
        /// <param name="tracked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTrackingPerson(
            global::System.Collections.Generic.IList<global::EdenAI.PersonTracking>? tracked)
        {
            this.Tracked = tracked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTrackingPerson" /> class.
        /// </summary>
        public VideoTrackingPerson()
        {
        }
    }
}