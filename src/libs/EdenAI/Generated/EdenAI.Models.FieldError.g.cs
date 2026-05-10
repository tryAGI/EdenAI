
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("<parameter_name>")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> x_parameterName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldError" /> class.
        /// </summary>
        /// <param name="x_parameterName_"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldError(
            global::System.Collections.Generic.IList<string> x_parameterName_)
        {
            this.x_parameterName_ = x_parameterName_ ?? throw new global::System.ArgumentNullException(nameof(x_parameterName_));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldError" /> class.
        /// </summary>
        public FieldError()
        {
        }

    }
}