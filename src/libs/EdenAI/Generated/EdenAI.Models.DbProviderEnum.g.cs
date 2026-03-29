
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `qdrant` - qdrant<br/>
    /// * `supabase` - supabase
    /// </summary>
    public enum DbProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Qdrant,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DbProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DbProviderEnum value)
        {
            return value switch
            {
                DbProviderEnum.Qdrant => "qdrant",
                DbProviderEnum.Supabase => "supabase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DbProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "qdrant" => DbProviderEnum.Qdrant,
                "supabase" => DbProviderEnum.Supabase,
                _ => null,
            };
        }
    }
}