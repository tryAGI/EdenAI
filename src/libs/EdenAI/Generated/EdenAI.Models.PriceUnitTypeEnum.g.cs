
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `file` - File<br/>
    /// * `image` - Image<br/>
    /// * `page` - Page<br/>
    /// * `size` - Size<br/>
    /// * `request` - Request<br/>
    /// * `seconde` - Second<br/>
    /// * `minute` - Minute<br/>
    /// * `free` - Free<br/>
    /// * `hour` - Hour<br/>
    /// * `char` - Characters<br/>
    /// * `token` - Token<br/>
    /// * `exec_time` - Execution Time<br/>
    /// * `unknown` - Unknown
    /// </summary>
    public enum PriceUnitTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Char,
        /// <summary>
        /// 
        /// </summary>
        ExecTime,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        Seconde,
        /// <summary>
        /// 
        /// </summary>
        Size,
        /// <summary>
        /// 
        /// </summary>
        Token,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PriceUnitTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PriceUnitTypeEnum value)
        {
            return value switch
            {
                PriceUnitTypeEnum.Char => "char",
                PriceUnitTypeEnum.ExecTime => "exec_time",
                PriceUnitTypeEnum.File => "file",
                PriceUnitTypeEnum.Free => "free",
                PriceUnitTypeEnum.Hour => "hour",
                PriceUnitTypeEnum.Image => "image",
                PriceUnitTypeEnum.Minute => "minute",
                PriceUnitTypeEnum.Page => "page",
                PriceUnitTypeEnum.Request => "request",
                PriceUnitTypeEnum.Seconde => "seconde",
                PriceUnitTypeEnum.Size => "size",
                PriceUnitTypeEnum.Token => "token",
                PriceUnitTypeEnum.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PriceUnitTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "char" => PriceUnitTypeEnum.Char,
                "exec_time" => PriceUnitTypeEnum.ExecTime,
                "file" => PriceUnitTypeEnum.File,
                "free" => PriceUnitTypeEnum.Free,
                "hour" => PriceUnitTypeEnum.Hour,
                "image" => PriceUnitTypeEnum.Image,
                "minute" => PriceUnitTypeEnum.Minute,
                "page" => PriceUnitTypeEnum.Page,
                "request" => PriceUnitTypeEnum.Request,
                "seconde" => PriceUnitTypeEnum.Seconde,
                "size" => PriceUnitTypeEnum.Size,
                "token" => PriceUnitTypeEnum.Token,
                "unknown" => PriceUnitTypeEnum.Unknown,
                _ => null,
            };
        }
    }
}