
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum Status549Enum
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
    public static class Status549EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status549Enum value)
        {
            return value switch
            {
                Status549Enum.Fail => "fail",
                Status549Enum.Sucess => "sucess",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status549Enum? ToEnum(string value)
        {
            return value switch
            {
                "fail" => Status549Enum.Fail,
                "sucess" => Status549Enum.Sucess,
                _ => null,
            };
        }
    }
}