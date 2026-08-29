
#nullable enable

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomTokenUpdate
    {
        /// <summary>
        /// The token name<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.TokenTypeEnumJsonConverter))]
        public global::EdenAI.TokenTypeEnum TokenType { get; set; } = default!;

        /// <summary>
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public global::System.DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Weither to use the balance field or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_balance")]
        public bool? ActiveBalance { get; set; }

        /// <summary>
        /// The amount this token's balance is reset to at the start of each balance_reset_period. Null when balance_reset_period is 'none'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_reset_amount")]
        public double? BalanceResetAmount { get; set; }

        /// <summary>
        /// How often this token's balance is reinitialized to balance_reset_amount. 'none' = one-time balance (default, current behaviour).<br/>
        /// * `none` - None<br/>
        /// * `daily` - Daily<br/>
        /// * `weekly` - Weekly<br/>
        /// * `monthly` - Monthly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_reset_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.BalanceResetPeriodEnumJsonConverter))]
        public global::EdenAI.BalanceResetPeriodEnum? BalanceResetPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokenUpdate" /> class.
        /// </summary>
        /// <param name="balance">
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </param>
        /// <param name="expireTime"></param>
        /// <param name="activeBalance">
        /// Weither to use the balance field or not.
        /// </param>
        /// <param name="balanceResetAmount">
        /// The amount this token's balance is reset to at the start of each balance_reset_period. Null when balance_reset_period is 'none'.
        /// </param>
        /// <param name="balanceResetPeriod">
        /// How often this token's balance is reinitialized to balance_reset_amount. 'none' = one-time balance (default, current behaviour).<br/>
        /// * `none` - None<br/>
        /// * `daily` - Daily<br/>
        /// * `weekly` - Weekly<br/>
        /// * `monthly` - Monthly
        /// </param>
        /// <param name="name">
        /// The token name<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenType">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTokenUpdate(
            double? balance,
            global::System.DateTime? expireTime,
            bool? activeBalance,
            double? balanceResetAmount,
            global::EdenAI.BalanceResetPeriodEnum? balanceResetPeriod,
            string name = default!,
            global::EdenAI.TokenTypeEnum tokenType = default!)
        {
            this.Name = name;
            this.TokenType = tokenType;
            this.Balance = balance;
            this.ExpireTime = expireTime;
            this.ActiveBalance = activeBalance;
            this.BalanceResetAmount = balanceResetAmount;
            this.BalanceResetPeriod = balanceResetPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokenUpdate" /> class.
        /// </summary>
        public CustomTokenUpdate()
        {
        }

    }
}