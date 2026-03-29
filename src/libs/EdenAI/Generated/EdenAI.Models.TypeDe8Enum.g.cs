
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `db` - Db<br/>
    /// * `bucket` - Bucket<br/>
    /// * `db_vector` - Db Vector<br/>
    /// * `ai` - Ai
    /// </summary>
    public enum TypeDe8Enum
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Db,
        /// <summary>
        /// 
        /// </summary>
        DbVector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeDe8EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeDe8Enum value)
        {
            return value switch
            {
                TypeDe8Enum.Ai => "ai",
                TypeDe8Enum.Bucket => "bucket",
                TypeDe8Enum.Db => "db",
                TypeDe8Enum.DbVector => "db_vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeDe8Enum? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TypeDe8Enum.Ai,
                "bucket" => TypeDe8Enum.Bucket,
                "db" => TypeDe8Enum.Db,
                "db_vector" => TypeDe8Enum.DbVector,
                _ => null,
            };
        }
    }
}