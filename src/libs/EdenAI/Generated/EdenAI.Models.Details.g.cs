
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Details1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> CostPerProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Details" /> class.
        /// </summary>
        /// <param name="totalCost"></param>
        /// <param name="details1"></param>
        /// <param name="costPerProvider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Details(
            int totalCost,
            int details1,
            global::System.Collections.Generic.Dictionary<string, int> costPerProvider)
        {
            this.TotalCost = totalCost;
            this.Details1 = details1;
            this.CostPerProvider = costPerProvider ?? throw new global::System.ArgumentNullException(nameof(costPerProvider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details" /> class.
        /// </summary>
        public Details()
        {
        }
    }
}