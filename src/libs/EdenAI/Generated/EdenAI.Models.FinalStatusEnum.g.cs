
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinalStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Sucess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinalStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinalStatusEnum value)
        {
            return value switch
            {
                FinalStatusEnum.Fail => "fail",
                FinalStatusEnum.Sucess => "sucess",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinalStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "fail" => FinalStatusEnum.Fail,
                "sucess" => FinalStatusEnum.Sucess,
                _ => null,
            };
        }
    }
}