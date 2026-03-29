
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `pdf` - pdf<br/>
    /// * `audio` - audio<br/>
    /// * `csv` - csv<br/>
    /// * `xml` - xml
    /// </summary>
    public enum DataTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Xml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataTypeEnum value)
        {
            return value switch
            {
                DataTypeEnum.Audio => "audio",
                DataTypeEnum.Csv => "csv",
                DataTypeEnum.Pdf => "pdf",
                DataTypeEnum.Xml => "xml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "audio" => DataTypeEnum.Audio,
                "csv" => DataTypeEnum.Csv,
                "pdf" => DataTypeEnum.Pdf,
                "xml" => DataTypeEnum.Xml,
                _ => null,
            };
        }
    }
}