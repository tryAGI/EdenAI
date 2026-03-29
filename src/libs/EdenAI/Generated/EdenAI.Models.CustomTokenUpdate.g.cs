
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
            string name = default!,
            global::EdenAI.TokenTypeEnum tokenType = default!)
        {
            this.Name = name;
            this.TokenType = tokenType;
            this.Balance = balance;
            this.ExpireTime = expireTime;
            this.ActiveBalance = activeBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokenUpdate" /> class.
        /// </summary>
        public CustomTokenUpdate()
        {
        }
    }
}