
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceMakeup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_make")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EyeMake { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lip_make")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LipMake { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceMakeup" /> class.
        /// </summary>
        /// <param name="eyeMake"></param>
        /// <param name="lipMake"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceMakeup(
            bool eyeMake,
            bool lipMake)
        {
            this.EyeMake = eyeMake;
            this.LipMake = lipMake;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceMakeup" /> class.
        /// </summary>
        public FaceMakeup()
        {
        }
    }
}