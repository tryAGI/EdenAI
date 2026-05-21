
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialLineItem
    {
        /// <summary>
        /// Tax amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax")]
        public int? Tax { get; set; }

        /// <summary>
        /// Total amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_line")]
        public int? AmountLine { get; set; }

        /// <summary>
        /// Description of the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Quantity of units for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Unit price for each unit in the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        public int? UnitPrice { get; set; }

        /// <summary>
        /// Type of unit (e.g., hours, items).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_type")]
        public string? UnitType { get; set; }

        /// <summary>
        /// Date associated with the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Product code or identifier for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_code")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Purchase order related to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_order")]
        public string? PurchaseOrder { get; set; }

        /// <summary>
        /// Tax rate applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
        public int? TaxRate { get; set; }

        /// <summary>
        /// Base total amount before any discounts or taxes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_total")]
        public int? BaseTotal { get; set; }

        /// <summary>
        /// Subtotal amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_total")]
        public int? SubTotal { get; set; }

        /// <summary>
        /// Amount of discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
        public int? DiscountAmount { get; set; }

        /// <summary>
        /// Rate of discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_rate")]
        public int? DiscountRate { get; set; }

        /// <summary>
        /// Code associated with any discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_code")]
        public string? DiscountCode { get; set; }

        /// <summary>
        /// Order number associated with the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_number")]
        public string? OrderNumber { get; set; }

        /// <summary>
        /// Title or name of the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialLineItem" /> class.
        /// </summary>
        /// <param name="tax">
        /// Tax amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="amountLine">
        /// Total amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description of the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="quantity">
        /// Quantity of units for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="unitPrice">
        /// Unit price for each unit in the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="unitType">
        /// Type of unit (e.g., hours, items).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="date">
        /// Date associated with the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="productCode">
        /// Product code or identifier for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="purchaseOrder">
        /// Purchase order related to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="taxRate">
        /// Tax rate applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseTotal">
        /// Base total amount before any discounts or taxes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="subTotal">
        /// Subtotal amount for the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="discountAmount">
        /// Amount of discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="discountRate">
        /// Rate of discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="discountCode">
        /// Code associated with any discount applied to the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="orderNumber">
        /// Order number associated with the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="title">
        /// Title or name of the line item.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialLineItem(
            int? tax,
            int? amountLine,
            string? description,
            int? quantity,
            int? unitPrice,
            string? unitType,
            string? date,
            string? productCode,
            string? purchaseOrder,
            int? taxRate,
            int? baseTotal,
            int? subTotal,
            int? discountAmount,
            int? discountRate,
            string? discountCode,
            string? orderNumber,
            string? title)
        {
            this.Tax = tax;
            this.AmountLine = amountLine;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.UnitType = unitType;
            this.Date = date;
            this.ProductCode = productCode;
            this.PurchaseOrder = purchaseOrder;
            this.TaxRate = taxRate;
            this.BaseTotal = baseTotal;
            this.SubTotal = subTotal;
            this.DiscountAmount = discountAmount;
            this.DiscountRate = discountRate;
            this.DiscountCode = discountCode;
            this.OrderNumber = orderNumber;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialLineItem" /> class.
        /// </summary>
        public FinancialLineItem()
        {
        }

    }
}