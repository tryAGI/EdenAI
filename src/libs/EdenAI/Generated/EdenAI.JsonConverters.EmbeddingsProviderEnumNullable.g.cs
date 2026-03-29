#nullable enable

namespace EdenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsProviderEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EdenAI.EmbeddingsProviderEnum?>
    {
        /// <inheritdoc />
        public override global::EdenAI.EmbeddingsProviderEnum? Read(
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
                        return global::EdenAI.EmbeddingsProviderEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EdenAI.EmbeddingsProviderEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EdenAI.EmbeddingsProviderEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EdenAI.EmbeddingsProviderEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::EdenAI.EmbeddingsProviderEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
