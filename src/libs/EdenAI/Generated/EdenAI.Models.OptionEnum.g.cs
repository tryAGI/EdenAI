
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `FEMALE` - Female<br/>
    /// * `MALE` - Male
    /// </summary>
    public enum OptionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptionEnum value)
        {
            return value switch
            {
                OptionEnum.Female => "FEMALE",
                OptionEnum.Male => "MALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "FEMALE" => OptionEnum.Female,
                "MALE" => OptionEnum.Male,
                _ => null,
            };
        }
    }
}