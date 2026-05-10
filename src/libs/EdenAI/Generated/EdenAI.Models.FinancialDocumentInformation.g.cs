
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialDocumentInformation
    {
        /// <summary>
        /// Identifier for the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_receipt_id")]
        public string? InvoiceReceiptId { get; set; }

        /// <summary>
        /// Purchase order related to the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_order")]
        public string? PurchaseOrder { get; set; }

        /// <summary>
        /// Date of the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_date")]
        public string? InvoiceDate { get; set; }

        /// <summary>
        /// Time associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Due date for the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_due_date")]
        public string? InvoiceDueDate { get; set; }

        /// <summary>
        /// Start date of the service associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_start_date")]
        public string? ServiceStartDate { get; set; }

        /// <summary>
        /// End date of the service associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_end_date")]
        public string? ServiceEndDate { get; set; }

        /// <summary>
        /// Reference number associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Biller code associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biller_code")]
        public string? BillerCode { get; set; }

        /// <summary>
        /// Date of the order associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_date")]
        public string? OrderDate { get; set; }

        /// <summary>
        /// Tracking number associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// List of barcodes associated with the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("barcodes")]
        public global::System.Collections.Generic.IList<global::EdenAI.FinancialBarcode>? Barcodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialDocumentInformation" /> class.
        /// </summary>
        /// <param name="invoiceReceiptId">
        /// Identifier for the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="purchaseOrder">
        /// Purchase order related to the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="invoiceDate">
        /// Date of the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="time">
        /// Time associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="invoiceDueDate">
        /// Due date for the invoice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceStartDate">
        /// Start date of the service associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceEndDate">
        /// End date of the service associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reference">
        /// Reference number associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="billerCode">
        /// Biller code associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="orderDate">
        /// Date of the order associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trackingNumber">
        /// Tracking number associated with the document.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="barcodes">
        /// List of barcodes associated with the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialDocumentInformation(
            string? invoiceReceiptId,
            string? purchaseOrder,
            string? invoiceDate,
            string? time,
            string? invoiceDueDate,
            string? serviceStartDate,
            string? serviceEndDate,
            string? reference,
            string? billerCode,
            string? orderDate,
            string? trackingNumber,
            global::System.Collections.Generic.IList<global::EdenAI.FinancialBarcode>? barcodes)
        {
            this.InvoiceReceiptId = invoiceReceiptId;
            this.PurchaseOrder = purchaseOrder;
            this.InvoiceDate = invoiceDate;
            this.Time = time;
            this.InvoiceDueDate = invoiceDueDate;
            this.ServiceStartDate = serviceStartDate;
            this.ServiceEndDate = serviceEndDate;
            this.Reference = reference;
            this.BillerCode = billerCode;
            this.OrderDate = orderDate;
            this.TrackingNumber = trackingNumber;
            this.Barcodes = barcodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialDocumentInformation" /> class.
        /// </summary>
        public FinancialDocumentInformation()
        {
        }

    }
}