
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `resolution` - Resolution<br/>
    /// * `document_type` - Document Type<br/>
    /// * `depth` - Depth<br/>
    /// * `reasoning_depth` - Reasoning Depth
    /// </summary>
    public enum DetailTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Depth,
        /// <summary>
        ///
        /// </summary>
        DocumentType,
        /// <summary>
        ///
        /// </summary>
        ReasoningDepth,
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
                DetailTypeEnum.Depth => "depth",
                DetailTypeEnum.DocumentType => "document_type",
                DetailTypeEnum.ReasoningDepth => "reasoning_depth",
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
                "depth" => DetailTypeEnum.Depth,
                "document_type" => DetailTypeEnum.DocumentType,
                "reasoning_depth" => DetailTypeEnum.ReasoningDepth,
                "resolution" => DetailTypeEnum.Resolution,
                _ => null,
            };
        }
    }
}