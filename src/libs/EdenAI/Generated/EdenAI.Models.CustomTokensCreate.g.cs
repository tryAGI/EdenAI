
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomTokensCreate
    {
        /// <summary>
        /// The token name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        public string? Balance { get; set; }

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
        /// Initializes a new instance of the <see cref="CustomTokensCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The token name
        /// </param>
        /// <param name="tokenType">
        /// * `sandbox_api_token` - Sandbox<br/>
        /// * `api_token` - Back
        /// </param>
        /// <param name="balance">
        /// Optional remaining credits balance for this Token, if `active_balance` is set to True and the balance reaches 0, this token will become unusable
        /// </param>
        /// <param name="expireTime"></param>
        /// <param name="activeBalance">
        /// Weither to use the balance field or not.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTokensCreate(
            string name,
            global::EdenAI.TokenTypeEnum? tokenType,
            string? balance,
            global::System.DateTime? expireTime,
            bool? activeBalance)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenType = tokenType;
            this.Balance = balance;
            this.ExpireTime = expireTime;
            this.ActiveBalance = activeBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTokensCreate" /> class.
        /// </summary>
        public CustomTokensCreate()
        {
        }
    }
}