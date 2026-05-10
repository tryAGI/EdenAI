
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialBankInformation
    {
        /// <summary>
        /// International Bank Account Number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iban")]
        public string? Iban { get; set; }

        /// <summary>
        /// Society for Worldwide Interbank Financial Telecommunication code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swift")]
        public string? Swift { get; set; }

        /// <summary>
        /// Bank State Branch code (Australia).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bsb")]
        public string? Bsb { get; set; }

        /// <summary>
        /// Sort code for UK banks.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_code")]
        public string? SortCode { get; set; }

        /// <summary>
        /// Bank account number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Routing number for banks in the United States.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_number")]
        public string? RoutingNumber { get; set; }

        /// <summary>
        /// Bank Identifier Code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bic")]
        public string? Bic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialBankInformation" /> class.
        /// </summary>
        /// <param name="iban">
        /// International Bank Account Number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="swift">
        /// Society for Worldwide Interbank Financial Telecommunication code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bsb">
        /// Bank State Branch code (Australia).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sortCode">
        /// Sort code for UK banks.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="accountNumber">
        /// Bank account number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="routingNumber">
        /// Routing number for banks in the United States.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bic">
        /// Bank Identifier Code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialBankInformation(
            string? iban,
            string? swift,
            string? bsb,
            string? sortCode,
            string? accountNumber,
            string? routingNumber,
            string? bic)
        {
            this.Iban = iban;
            this.Swift = swift;
            this.Bsb = bsb;
            this.SortCode = sortCode;
            this.AccountNumber = accountNumber;
            this.RoutingNumber = routingNumber;
            this.Bic = bic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialBankInformation" /> class.
        /// </summary>
        public FinancialBankInformation()
        {
        }

    }
}