
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialParserObjectDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_information")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialCustomerInformation CustomerInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merchant_information")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_information")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financial_document_information")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialDocumentInformation FinancialDocumentInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialLocalInformation Local { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialBankInformation Bank { get; set; }

        /// <summary>
        /// List of line items associated with the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_lines")]
        public global::System.Collections.Generic.IList<global::EdenAI.FinancialLineItem>? ItemLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FinancialDocumentMetadata DocumentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialParserObjectDataClass" /> class.
        /// </summary>
        /// <param name="customerInformation"></param>
        /// <param name="merchantInformation"></param>
        /// <param name="paymentInformation"></param>
        /// <param name="financialDocumentInformation"></param>
        /// <param name="local"></param>
        /// <param name="bank"></param>
        /// <param name="documentMetadata"></param>
        /// <param name="itemLines">
        /// List of line items associated with the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialParserObjectDataClass(
            global::EdenAI.FinancialCustomerInformation customerInformation,
            global::EdenAI.FinancialMerchantInformation merchantInformation,
            global::EdenAI.FinancialPaymentInformation paymentInformation,
            global::EdenAI.FinancialDocumentInformation financialDocumentInformation,
            global::EdenAI.FinancialLocalInformation local,
            global::EdenAI.FinancialBankInformation bank,
            global::EdenAI.FinancialDocumentMetadata documentMetadata,
            global::System.Collections.Generic.IList<global::EdenAI.FinancialLineItem>? itemLines)
        {
            this.CustomerInformation = customerInformation ?? throw new global::System.ArgumentNullException(nameof(customerInformation));
            this.MerchantInformation = merchantInformation ?? throw new global::System.ArgumentNullException(nameof(merchantInformation));
            this.PaymentInformation = paymentInformation ?? throw new global::System.ArgumentNullException(nameof(paymentInformation));
            this.FinancialDocumentInformation = financialDocumentInformation ?? throw new global::System.ArgumentNullException(nameof(financialDocumentInformation));
            this.Local = local ?? throw new global::System.ArgumentNullException(nameof(local));
            this.Bank = bank ?? throw new global::System.ArgumentNullException(nameof(bank));
            this.ItemLines = itemLines;
            this.DocumentMetadata = documentMetadata ?? throw new global::System.ArgumentNullException(nameof(documentMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialParserObjectDataClass" /> class.
        /// </summary>
        public FinancialParserObjectDataClass()
        {
        }
    }
}