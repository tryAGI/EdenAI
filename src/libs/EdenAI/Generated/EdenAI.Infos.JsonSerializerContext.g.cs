
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BlankEnum), TypeInfoPropertyName = "BlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DetailTypeEnum), TypeInfoPropertyName = "DetailTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Feature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PriceUnitTypeEnum), TypeInfoPropertyName = "PriceUnitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PricingSerialzier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>), TypeInfoPropertyName = "OneOfDetailTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProviderSubfeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PricingSerialzier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Subfeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeatureLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProviderSubfeatureLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BlankEnum?), TypeInfoPropertyName = "NullableBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DetailTypeEnum?), TypeInfoPropertyName = "NullableDetailTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PriceUnitTypeEnum?), TypeInfoPropertyName = "NullablePriceUnitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfDetailTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PricingSerialzier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ProviderSubfeatureLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ProviderSubfeature>))]
    internal sealed partial class InfosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InfosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InfosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>());
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
                    typeToConvert == typeof(global::EdenAI.BlankEnum)

                    || typeToConvert == typeof(global::EdenAI.BlankEnum?)

                    || typeToConvert == typeof(global::EdenAI.DetailTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.DetailTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.NullEnum)

                    || typeToConvert == typeof(global::EdenAI.NullEnum?)

                    || typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::EdenAI.BlankEnum))
                {
                    return new global::EdenAI.JsonConverters.BlankEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.BlankEnum?))
                {
                    return new global::EdenAI.JsonConverters.BlankEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DetailTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.DetailTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DetailTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.DetailTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.NullEnum))
                {
                    return new global::EdenAI.JsonConverters.NullEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.NullEnum?))
                {
                    return new global::EdenAI.JsonConverters.NullEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.PriceUnitTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.PriceUnitTypeEnumNullableJsonConverter();
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
                    0 => new InfosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}