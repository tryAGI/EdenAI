
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentimentEbfEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentEbfEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentEbfEnum value)
        {
            return value switch
            {
                SentimentEbfEnum.Negative => "Negative",
                SentimentEbfEnum.Neutral => "Neutral",
                SentimentEbfEnum.Positive => "Positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentEbfEnum? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => SentimentEbfEnum.Negative,
                "Neutral" => SentimentEbfEnum.Neutral,
                "Positive" => SentimentEbfEnum.Positive,
                _ => null,
            };
        }
    }
}