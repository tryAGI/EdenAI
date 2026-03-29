#nullable enable

namespace EdenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExecutionContentCreateStatusEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EdenAI.ExecutionContentCreateStatusEnum?>
    {
        /// <inheritdoc />
        public override global::EdenAI.ExecutionContentCreateStatusEnum? Read(
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
                        return global::EdenAI.ExecutionContentCreateStatusEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EdenAI.ExecutionContentCreateStatusEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EdenAI.ExecutionContentCreateStatusEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EdenAI.ExecutionContentCreateStatusEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::EdenAI.ExecutionContentCreateStatusEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
