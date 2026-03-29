
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `resolution` - Resolution<br/>
    /// * `document_type` - Document Type
    /// </summary>
    public enum DetailTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentType,
        /// <summary>
        /// 
        /// </summary>
        Resolution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailTypeEnum value)
        {
            return value switch
            {
                DetailTypeEnum.DocumentType => "document_type",
                DetailTypeEnum.Resolution => "resolution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "document_type" => DetailTypeEnum.DocumentType,
                "resolution" => DetailTypeEnum.Resolution,
                _ => null,
            };
        }
    }
}