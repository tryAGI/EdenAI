
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// **Choices**:<br/>
    /// - 'low': Minimal reasoning, quick responses<br/>
    /// - 'medium': Balanced reasoning approach<br/>
    /// - 'high': In-depth, comprehensive reasoning<br/>
    /// **Example**: 'high' for complex problem-solving tasks<br/>
    /// * `low` - low<br/>
    /// * `medium` - medium<br/>
    /// * `high` - high
    /// </summary>
    public enum ReasoningEffortEnum
    {
        /// <summary>
        /// In-depth, comprehensive reasoning
        /// </summary>
        High,
        /// <summary>
        /// Minimal reasoning, quick responses
        /// </summary>
        Low,
        /// <summary>
        /// Balanced reasoning approach
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortEnum value)
        {
            return value switch
            {
                ReasoningEffortEnum.High => "high",
                ReasoningEffortEnum.Low => "low",
                ReasoningEffortEnum.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortEnum.High,
                "low" => ReasoningEffortEnum.Low,
                "medium" => ReasoningEffortEnum.Medium,
                _ => null,
            };
        }
    }
}