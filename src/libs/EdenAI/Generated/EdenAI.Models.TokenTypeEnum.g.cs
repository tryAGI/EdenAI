
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `sandbox_api_token` - Sandbox<br/>
    /// * `api_token` - Back
    /// </summary>
    public enum TokenTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ApiToken,
        /// <summary>
        /// 
        /// </summary>
        SandboxApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenTypeEnum value)
        {
            return value switch
            {
                TokenTypeEnum.ApiToken => "api_token",
                TokenTypeEnum.SandboxApiToken => "sandbox_api_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "api_token" => TokenTypeEnum.ApiToken,
                "sandbox_api_token" => TokenTypeEnum.SandboxApiToken,
                _ => null,
            };
        }
    }
}