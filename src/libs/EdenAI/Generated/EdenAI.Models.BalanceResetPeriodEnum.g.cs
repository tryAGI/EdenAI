
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `none` - None<br/>
    /// * `daily` - Daily<br/>
    /// * `weekly` - Weekly<br/>
    /// * `monthly` - Monthly
    /// </summary>
    public enum BalanceResetPeriodEnum
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BalanceResetPeriodEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BalanceResetPeriodEnum value)
        {
            return value switch
            {
                BalanceResetPeriodEnum.Daily => "daily",
                BalanceResetPeriodEnum.Monthly => "monthly",
                BalanceResetPeriodEnum.None => "none",
                BalanceResetPeriodEnum.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BalanceResetPeriodEnum? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BalanceResetPeriodEnum.Daily,
                "monthly" => BalanceResetPeriodEnum.Monthly,
                "none" => BalanceResetPeriodEnum.None,
                "weekly" => BalanceResetPeriodEnum.Weekly,
                _ => null,
            };
        }
    }
}