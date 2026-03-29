
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntitySentimentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Mixed,
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
    public static class EntitySentimentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntitySentimentEnum value)
        {
            return value switch
            {
                EntitySentimentEnum.Mixed => "Mixed",
                EntitySentimentEnum.Negative => "Negative",
                EntitySentimentEnum.Neutral => "Neutral",
                EntitySentimentEnum.Positive => "Positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntitySentimentEnum? ToEnum(string value)
        {
            return value switch
            {
                "Mixed" => EntitySentimentEnum.Mixed,
                "Negative" => EntitySentimentEnum.Negative,
                "Neutral" => EntitySentimentEnum.Neutral,
                "Positive" => EntitySentimentEnum.Positive,
                _ => null,
            };
        }
    }
}