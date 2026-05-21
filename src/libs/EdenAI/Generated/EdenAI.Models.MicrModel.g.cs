
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MicrModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Raw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SerialNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrModel" /> class.
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="accountNumber"></param>
        /// <param name="routingNumber"></param>
        /// <param name="serialNumber"></param>
        /// <param name="checkNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MicrModel(
            string raw,
            string accountNumber,
            string routingNumber,
            string serialNumber,
            string checkNumber)
        {
            this.Raw = raw ?? throw new global::System.ArgumentNullException(nameof(raw));
            this.AccountNumber = accountNumber ?? throw new global::System.ArgumentNullException(nameof(accountNumber));
            this.RoutingNumber = routingNumber ?? throw new global::System.ArgumentNullException(nameof(routingNumber));
            this.SerialNumber = serialNumber ?? throw new global::System.ArgumentNullException(nameof(serialNumber));
            this.CheckNumber = checkNumber ?? throw new global::System.ArgumentNullException(nameof(checkNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrModel" /> class.
        /// </summary>
        public MicrModel()
        {
        }

    }
}