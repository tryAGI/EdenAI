
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneralSentimentEnum
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
    public static class GeneralSentimentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneralSentimentEnum value)
        {
            return value switch
            {
                GeneralSentimentEnum.Negative => "Negative",
                GeneralSentimentEnum.Neutral => "Neutral",
                GeneralSentimentEnum.Positive => "Positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneralSentimentEnum? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => GeneralSentimentEnum.Negative,
                "Neutral" => GeneralSentimentEnum.Neutral,
                "Positive" => GeneralSentimentEnum.Positive,
                _ => null,
            };
        }
    }
}