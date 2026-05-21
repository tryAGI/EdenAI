
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingSerialzier
    {
        /// <summary>
        /// Model name, default to 'default' if no models to chose from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public string? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_unit_quantity")]
        public int? PriceUnitQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_price_quantity")]
        public int? MinPriceQuantity { get; set; }

        /// <summary>
        /// * `file` - File<br/>
        /// * `image` - Image<br/>
        /// * `page` - Page<br/>
        /// * `size` - Size<br/>
        /// * `request` - Request<br/>
        /// * `seconde` - Second<br/>
        /// * `minute` - Minute<br/>
        /// * `free` - Free<br/>
        /// * `hour` - Hour<br/>
        /// * `char` - Characters<br/>
        /// * `token` - Token<br/>
        /// * `exec_time` - Execution Time<br/>
        /// * `unknown` - Unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_unit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.PriceUnitTypeEnumJsonConverter))]
        public global::EdenAI.PriceUnitTypeEnum? PriceUnitType { get; set; }

        /// <summary>
        /// (Optional) type of extra value, MUST be the same name as the feature parameter name. eg: resolution<br/>
        /// * `resolution` - Resolution<br/>
        /// * `document_type` - Document Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum>))]
        public global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum>? DetailType { get; set; }

        /// <summary>
        /// (Optional) extra value for detailed pricing, eg: 250x250 for resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail_value")]
        public string? DetailValue { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_detail_type_display")]
        public string GetDetailTypeDisplay { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_post_call")]
        public bool? IsPostCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingSerialzier" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model name, default to 'default' if no models to chose from
        /// </param>
        /// <param name="price"></param>
        /// <param name="priceUnitQuantity"></param>
        /// <param name="minPriceQuantity"></param>
        /// <param name="priceUnitType">
        /// * `file` - File<br/>
        /// * `image` - Image<br/>
        /// * `page` - Page<br/>
        /// * `size` - Size<br/>
        /// * `request` - Request<br/>
        /// * `seconde` - Second<br/>
        /// * `minute` - Minute<br/>
        /// * `free` - Free<br/>
        /// * `hour` - Hour<br/>
        /// * `char` - Characters<br/>
        /// * `token` - Token<br/>
        /// * `exec_time` - Execution Time<br/>
        /// * `unknown` - Unknown
        /// </param>
        /// <param name="detailType">
        /// (Optional) type of extra value, MUST be the same name as the feature parameter name. eg: resolution<br/>
        /// * `resolution` - Resolution<br/>
        /// * `document_type` - Document Type
        /// </param>
        /// <param name="detailValue">
        /// (Optional) extra value for detailed pricing, eg: 250x250 for resolution
        /// </param>
        /// <param name="isPostCall"></param>
        /// <param name="getDetailTypeDisplay">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingSerialzier(
            string? modelName,
            string? price,
            int? priceUnitQuantity,
            int? minPriceQuantity,
            global::EdenAI.PriceUnitTypeEnum? priceUnitType,
            global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum>? detailType,
            string? detailValue,
            bool? isPostCall,
            string getDetailTypeDisplay = default!)
        {
            this.ModelName = modelName;
            this.Price = price;
            this.PriceUnitQuantity = priceUnitQuantity;
            this.MinPriceQuantity = minPriceQuantity;
            this.PriceUnitType = priceUnitType;
            this.DetailType = detailType;
            this.DetailValue = detailValue;
            this.GetDetailTypeDisplay = getDetailTypeDisplay;
            this.IsPostCall = isPostCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingSerialzier" /> class.
        /// </summary>
        public PricingSerialzier()
        {
        }

    }
}