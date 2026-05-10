
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemBankCheckParsingDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AmountText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bank_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BankAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payer_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PayerAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payer_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PayerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceiverAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceiverName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("micr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.MicrModel Micr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBankCheckParsingDataClass" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="amountText"></param>
        /// <param name="bankAddress"></param>
        /// <param name="bankName"></param>
        /// <param name="date"></param>
        /// <param name="memo"></param>
        /// <param name="payerAddress"></param>
        /// <param name="payerName"></param>
        /// <param name="receiverAddress"></param>
        /// <param name="receiverName"></param>
        /// <param name="currency"></param>
        /// <param name="micr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemBankCheckParsingDataClass(
            int amount,
            string amountText,
            string bankAddress,
            string bankName,
            string date,
            string memo,
            string payerAddress,
            string payerName,
            string receiverAddress,
            string receiverName,
            string currency,
            global::EdenAI.MicrModel micr)
        {
            this.Amount = amount;
            this.AmountText = amountText ?? throw new global::System.ArgumentNullException(nameof(amountText));
            this.BankAddress = bankAddress ?? throw new global::System.ArgumentNullException(nameof(bankAddress));
            this.BankName = bankName ?? throw new global::System.ArgumentNullException(nameof(bankName));
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Memo = memo ?? throw new global::System.ArgumentNullException(nameof(memo));
            this.PayerAddress = payerAddress ?? throw new global::System.ArgumentNullException(nameof(payerAddress));
            this.PayerName = payerName ?? throw new global::System.ArgumentNullException(nameof(payerName));
            this.ReceiverAddress = receiverAddress ?? throw new global::System.ArgumentNullException(nameof(receiverAddress));
            this.ReceiverName = receiverName ?? throw new global::System.ArgumentNullException(nameof(receiverName));
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.Micr = micr ?? throw new global::System.ArgumentNullException(nameof(micr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBankCheckParsingDataClass" /> class.
        /// </summary>
        public ItemBankCheckParsingDataClass()
        {
        }

    }
}