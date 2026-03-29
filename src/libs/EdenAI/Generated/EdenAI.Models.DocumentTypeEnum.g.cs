
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `auto-detect` - auto-detect<br/>
    /// * `invoice` - invoice<br/>
    /// * `receipt` - receipt
    /// </summary>
    public enum DocumentTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AutoDetect,
        /// <summary>
        /// 
        /// </summary>
        Invoice,
        /// <summary>
        /// 
        /// </summary>
        Receipt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentTypeEnum value)
        {
            return value switch
            {
                DocumentTypeEnum.AutoDetect => "auto-detect",
                DocumentTypeEnum.Invoice => "invoice",
                DocumentTypeEnum.Receipt => "receipt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto-detect" => DocumentTypeEnum.AutoDetect,
                "invoice" => DocumentTypeEnum.Invoice,
                "receipt" => DocumentTypeEnum.Receipt,
                _ => null,
            };
        }
    }
}