
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `AskYoDa` - Askyoda<br/>
    /// * `Translathor` - Translathor<br/>
    /// * `X-Merge` - X Merge
    /// </summary>
    public enum ProjectTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AskYoDa,
        /// <summary>
        /// 
        /// </summary>
        Translathor,
        /// <summary>
        /// 
        /// </summary>
        XMerge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectTypeEnum value)
        {
            return value switch
            {
                ProjectTypeEnum.AskYoDa => "AskYoDa",
                ProjectTypeEnum.Translathor => "Translathor",
                ProjectTypeEnum.XMerge => "X-Merge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "AskYoDa" => ProjectTypeEnum.AskYoDa,
                "Translathor" => ProjectTypeEnum.Translathor,
                "X-Merge" => ProjectTypeEnum.XMerge,
                _ => null,
            };
        }
    }
}