
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `document` - document<br/>
    /// * `query` - query<br/>
    /// * `symetric` - symetric
    /// </summary>
    public enum RepresentationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Symetric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepresentationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepresentationEnum value)
        {
            return value switch
            {
                RepresentationEnum.Document => "document",
                RepresentationEnum.Query => "query",
                RepresentationEnum.Symetric => "symetric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepresentationEnum? ToEnum(string value)
        {
            return value switch
            {
                "document" => RepresentationEnum.Document,
                "query" => RepresentationEnum.Query,
                "symetric" => RepresentationEnum.Symetric,
                _ => null,
            };
        }
    }
}