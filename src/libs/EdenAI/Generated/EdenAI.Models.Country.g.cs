
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Country
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alpha2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha3")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alpha3 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public int? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="alpha2"></param>
        /// <param name="alpha3"></param>
        /// <param name="confidence">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Country(
            string name,
            string alpha2,
            string alpha3,
            int? confidence)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Alpha2 = alpha2 ?? throw new global::System.ArgumentNullException(nameof(alpha2));
            this.Alpha3 = alpha3 ?? throw new global::System.ArgumentNullException(nameof(alpha3));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// </summary>
        public Country()
        {
        }
    }
}