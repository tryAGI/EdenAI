
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `enabled` - enabled<br/>
    /// * `disabled` - disabled
    /// </summary>
    public enum ThinkingTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingTypeEnum value)
        {
            return value switch
            {
                ThinkingTypeEnum.Disabled => "disabled",
                ThinkingTypeEnum.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ThinkingTypeEnum.Disabled,
                "enabled" => ThinkingTypeEnum.Enabled,
                _ => null,
            };
        }
    }
}