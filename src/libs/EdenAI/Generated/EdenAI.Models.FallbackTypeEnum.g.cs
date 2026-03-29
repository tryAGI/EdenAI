
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `rerun` - Rerun<br/>
    /// * `continue` - Continue
    /// </summary>
    public enum FallbackTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Continue,
        /// <summary>
        /// 
        /// </summary>
        Rerun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackTypeEnum value)
        {
            return value switch
            {
                FallbackTypeEnum.Continue => "continue",
                FallbackTypeEnum.Rerun => "rerun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "continue" => FallbackTypeEnum.Continue,
                "rerun" => FallbackTypeEnum.Rerun,
                _ => null,
            };
        }
    }
}