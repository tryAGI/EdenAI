
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialPaymentInformation
    {
        /// <summary>
        /// Amount due for payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_due")]
        public int? AmountDue { get; set; }

        /// <summary>
        /// Tip amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_tip")]
        public int? AmountTip { get; set; }

        /// <summary>
        /// Shipping cost in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_shipping")]
        public int? AmountShipping { get; set; }

        /// <summary>
        /// Change amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_change")]
        public int? AmountChange { get; set; }

        /// <summary>
        /// Amount already paid in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_paid")]
        public int? AmountPaid { get; set; }

        /// <summary>
        /// Total amount in the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Subtotal amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        public int? Subtotal { get; set; }

        /// <summary>
        /// Total tax amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tax")]
        public int? TotalTax { get; set; }

        /// <summary>
        /// Tax rate applied in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
        public int? TaxRate { get; set; }

        /// <summary>
        /// Discount amount applied in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public int? Discount { get; set; }

        /// <summary>
        /// Gratuity amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gratuity")]
        public int? Gratuity { get; set; }

        /// <summary>
        /// Service charge in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_charge")]
        public int? ServiceCharge { get; set; }

        /// <summary>
        /// Previous unpaid balance in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_unpaid_balance")]
        public int? PreviousUnpaidBalance { get; set; }

        /// <summary>
        /// Prior balance before the current financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prior_balance")]
        public int? PriorBalance { get; set; }

        /// <summary>
        /// Terms and conditions for payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_terms")]
        public string? PaymentTerms { get; set; }

        /// <summary>
        /// Payment method used in the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Card number used in the payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_card_number")]
        public string? PaymentCardNumber { get; set; }

        /// <summary>
        /// Authorization code for the payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_auth_code")]
        public string? PaymentAuthCode { get; set; }

        /// <summary>
        /// Charge for shipping and handling in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shipping_handling_charge")]
        public int? ShippingHandlingCharge { get; set; }

        /// <summary>
        /// Unique identifier for the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_number")]
        public string? TransactionNumber { get; set; }

        /// <summary>
        /// Reference number for the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_reference")]
        public string? TransactionReference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialPaymentInformation" /> class.
        /// </summary>
        /// <param name="amountDue">
        /// Amount due for payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amountTip">
        /// Tip amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amountShipping">
        /// Shipping cost in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amountChange">
        /// Change amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amountPaid">
        /// Amount already paid in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="total">
        /// Total amount in the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="subtotal">
        /// Subtotal amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="totalTax">
        /// Total tax amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="taxRate">
        /// Tax rate applied in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="discount">
        /// Discount amount applied in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gratuity">
        /// Gratuity amount in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceCharge">
        /// Service charge in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="previousUnpaidBalance">
        /// Previous unpaid balance in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="priorBalance">
        /// Prior balance before the current financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="paymentTerms">
        /// Terms and conditions for payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="paymentMethod">
        /// Payment method used in the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="paymentCardNumber">
        /// Card number used in the payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="paymentAuthCode">
        /// Authorization code for the payment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shippingHandlingCharge">
        /// Charge for shipping and handling in a financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transactionNumber">
        /// Unique identifier for the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transactionReference">
        /// Reference number for the financial transaction.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialPaymentInformation(
            int? amountDue,
            int? amountTip,
            int? amountShipping,
            int? amountChange,
            int? amountPaid,
            int? total,
            int? subtotal,
            int? totalTax,
            int? taxRate,
            int? discount,
            int? gratuity,
            int? serviceCharge,
            int? previousUnpaidBalance,
            int? priorBalance,
            string? paymentTerms,
            string? paymentMethod,
            string? paymentCardNumber,
            string? paymentAuthCode,
            int? shippingHandlingCharge,
            string? transactionNumber,
            string? transactionReference)
        {
            this.AmountDue = amountDue;
            this.AmountTip = amountTip;
            this.AmountShipping = amountShipping;
            this.AmountChange = amountChange;
            this.AmountPaid = amountPaid;
            this.Total = total;
            this.Subtotal = subtotal;
            this.TotalTax = totalTax;
            this.TaxRate = taxRate;
            this.Discount = discount;
            this.Gratuity = gratuity;
            this.ServiceCharge = serviceCharge;
            this.PreviousUnpaidBalance = previousUnpaidBalance;
            this.PriorBalance = priorBalance;
            this.PaymentTerms = paymentTerms;
            this.PaymentMethod = paymentMethod;
            this.PaymentCardNumber = paymentCardNumber;
            this.PaymentAuthCode = paymentAuthCode;
            this.ShippingHandlingCharge = shippingHandlingCharge;
            this.TransactionNumber = transactionNumber;
            this.TransactionReference = transactionReference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialPaymentInformation" /> class.
        /// </summary>
        public FinancialPaymentInformation()
        {
        }
    }
}