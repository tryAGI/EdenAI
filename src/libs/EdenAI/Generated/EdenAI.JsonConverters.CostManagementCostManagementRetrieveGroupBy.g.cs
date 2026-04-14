#nullable enable

namespace EdenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CostManagementCostManagementRetrieveGroupByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EdenAI.CostManagementCostManagementRetrieveGroupBy>
    {
        /// <inheritdoc />
        public override global::EdenAI.CostManagementCostManagementRetrieveGroupBy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::EdenAI.CostManagementCostManagementRetrieveGroupByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EdenAI.CostManagementCostManagementRetrieveGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EdenAI.CostManagementCostManagementRetrieveGroupBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EdenAI.CostManagementCostManagementRetrieveGroupBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::EdenAI.CostManagementCostManagementRetrieveGroupByExtensions.ToValueString(value));
        }
    }
}
