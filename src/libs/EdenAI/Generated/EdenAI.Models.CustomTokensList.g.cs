
#nullable enable

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomTokensList
    {
        /// <summary>
        /// The token name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Non-secret display value, e.g. ``sk-eden-live…c5d6``. Owns the<br/>
        /// legacy-JWT vs hash-row duality so every surface (API, admin, shell) masks<br/>
        /// the same way. Falls back to the last 4 of a legacy row's stored token.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("masked")]
        public string Masked { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        public string? KeyPrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        public bool Revoked { get; set; } = default!;

        /// <summary>
        /// * `sandbox_api_token` - Sandbox<br/>
        /// * `api_token` - Back
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.TokenTypeEnumJsonConverter))]
        public global::EdenAI.TokenTypeEnum? TokenType { get; set; }

        /// <summary>
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// Weither to use the balance field or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_balance")]
        public bool? ActiveBalance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public global::System.DateTime? ExpireTime { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy")]
        public bool Legacy { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesized")]
        public bool Synthesized { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokensList" /> class.
        /// </summary>
        /// <param name="name">
        /// The token name
        /// </param>
        /// <param name="keyPrefix"></param>
        /// <param name="last4"></param>
        /// <param name="tokenType">
        /// * `sandbox_api_token` - Sandbox<br/>
        /// * `api_token` - Back
        /// </param>
        /// <param name="balance">
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </param>
        /// <param name="activeBalance">
        /// Weither to use the balance field or not.
        /// </param>
        /// <param name="expireTime"></param>
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
        /// <param name="label">
        /// Included only in responses
        /// </param>
        /// <param name="masked">
        /// Non-secret display value, e.g. ``sk-eden-live…c5d6``. Owns the<br/>
        /// legacy-JWT vs hash-row duality so every surface (API, admin, shell) masks<br/>
        /// the same way. Falls back to the last 4 of a legacy row's stored token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="revoked">
        /// Included only in responses
        /// </param>
        /// <param name="legacy">
        /// Included only in responses
        /// </param>
        /// <param name="synthesized">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTokensList(
            string name,
            string? keyPrefix,
            string? last4,
            global::EdenAI.TokenTypeEnum? tokenType,
            double? balance,
            bool? activeBalance,
            global::System.DateTime? expireTime,
            double? balanceResetAmount,
            global::EdenAI.BalanceResetPeriodEnum? balanceResetPeriod,
            string label = default!,
            string masked = default!,
            bool revoked = default!,
            bool legacy = default!,
            bool synthesized = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label;
            this.Masked = masked;
            this.KeyPrefix = keyPrefix;
            this.Last4 = last4;
            this.Revoked = revoked;
            this.TokenType = tokenType;
            this.Balance = balance;
            this.ActiveBalance = activeBalance;
            this.ExpireTime = expireTime;
            this.BalanceResetAmount = balanceResetAmount;
            this.BalanceResetPeriod = balanceResetPeriod;
            this.Legacy = legacy;
            this.Synthesized = synthesized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokensList" /> class.
        /// </summary>
        public CustomTokensList()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomTokensList"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CustomTokensList FromName(string name)
        {
            return new CustomTokensList
            {
                Name = name,
            };
        }

    }
}