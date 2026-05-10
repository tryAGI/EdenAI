
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_cloths")]
        public global::System.Collections.Generic.IList<global::EdenAI.UpperCloth>? UpperCloths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower_cloths")]
        public global::System.Collections.Generic.IList<global::EdenAI.LowerCloth>? LowerCloths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAttributes" /> class.
        /// </summary>
        /// <param name="upperCloths"></param>
        /// <param name="lowerCloths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonAttributes(
            global::System.Collections.Generic.IList<global::EdenAI.UpperCloth>? upperCloths,
            global::System.Collections.Generic.IList<global::EdenAI.LowerCloth>? lowerCloths)
        {
            this.UpperCloths = upperCloths;
            this.LowerCloths = lowerCloths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAttributes" /> class.
        /// </summary>
        public PersonAttributes()
        {
        }

    }
}