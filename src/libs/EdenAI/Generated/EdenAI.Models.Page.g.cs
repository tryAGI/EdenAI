
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Page of a document<br/>
    /// Attributes:<br/>
    ///     lines (Sequence[Line]): List of lines of the page
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// List of lines
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<global::EdenAI.Line>? Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        /// <param name="lines">
        /// List of lines
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Page(
            global::System.Collections.Generic.IList<global::EdenAI.Line>? lines)
        {
            this.Lines = lines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        public Page()
        {
        }
    }
}