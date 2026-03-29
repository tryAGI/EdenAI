
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// **Choices**:<br/>
    /// - 'auto': Automatically select appropriate tier<br/>
    /// - 'default': Use default service configuration<br/>
    /// * `auto` - auto<br/>
    /// * `default` - default
    /// </summary>
    public enum ServiceTierEnum
    {
        /// <summary>
        /// Automatically select appropriate tier
        /// </summary>
        Auto,
        /// <summary>
        /// Use default service configuration
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierEnum value)
        {
            return value switch
            {
                ServiceTierEnum.Auto => "auto",
                ServiceTierEnum.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierEnum.Auto,
                "default" => ServiceTierEnum.Default,
                _ => null,
            };
        }
    }
}