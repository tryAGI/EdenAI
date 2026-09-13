
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatAvailableToolsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.UsageTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatRole), TypeInfoPropertyName = "ChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessageDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatAvailableToolsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatToolCallsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatToolCallsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatToolResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FallbackTypeEnum), TypeInfoPropertyName = "FallbackTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FieldError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ServiceTierEnum), TypeInfoPropertyName = "ServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum), TypeInfoPropertyName = "Status549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingTypeEnum), TypeInfoPropertyName = "ThinkingTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatllmchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatToolResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatRole?), TypeInfoPropertyName = "NullableChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FallbackTypeEnum?), TypeInfoPropertyName = "NullableFallbackTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ServiceTierEnum?), TypeInfoPropertyName = "NullableServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum?), TypeInfoPropertyName = "NullableStatus549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingTypeEnum?), TypeInfoPropertyName = "NullableThinkingTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatAvailableToolsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatToolCallsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.MetadataRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatToolResultRequest>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::EdenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::EdenAI.ChatRole)

                    || typeToConvert == typeof(global::EdenAI.ChatRole?)

                    || typeToConvert == typeof(global::EdenAI.FallbackTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.FallbackTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::EdenAI.ServiceTierEnum)

                    || typeToConvert == typeof(global::EdenAI.ServiceTierEnum?)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum?)

                    || typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.ToolChoiceEnum)

                    || typeToConvert == typeof(global::EdenAI.ToolChoiceEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::EdenAI.ChatRole))
                {
                    return new global::EdenAI.JsonConverters.ChatRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ChatRole?))
                {
                    return new global::EdenAI.JsonConverters.ChatRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FallbackTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.FallbackTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FallbackTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.FallbackTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum))
                {
                    return new global::EdenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum?))
                {
                    return new global::EdenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ServiceTierEnum))
                {
                    return new global::EdenAI.JsonConverters.ServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ServiceTierEnum?))
                {
                    return new global::EdenAI.JsonConverters.ServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum?))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.ThinkingTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.ThinkingTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ToolChoiceEnum))
                {
                    return new global::EdenAI.JsonConverters.ToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ToolChoiceEnum?))
                {
                    return new global::EdenAI.JsonConverters.ToolChoiceEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}