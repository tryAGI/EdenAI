
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DocumentTypeEnum), TypeInfoPropertyName = "DocumentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FieldError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialBankInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialBarcode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialCustomerInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialDocumentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialBarcode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialDocumentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialLocalInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialMerchantInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialParserObjectDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialPaymentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum), TypeInfoPropertyName = "Status549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserFinancialParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialParserObjectDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserFinancialParserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DocumentTypeEnum?), TypeInfoPropertyName = "NullableDocumentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum?), TypeInfoPropertyName = "NullableStatus549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialBarcode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialParserObjectDataClass>))]
    internal sealed partial class FinancialParserSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FinancialParserSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FinancialParserSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FinancialParserSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::EdenAI.DocumentTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.DocumentTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::EdenAI.DocumentTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.DocumentTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DocumentTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.DocumentTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum?))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumNullableJsonConverter();
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
                    0 => new FinancialParserSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}