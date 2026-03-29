
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `finished` - finished<br/>
    /// * `failed` - failed<br/>
    /// * `Timeout error` - Timeout error<br/>
    /// * `processing` - processing
    /// </summary>
    public enum StateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        TimeoutError,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateEnum value)
        {
            return value switch
            {
                StateEnum.TimeoutError => "Timeout error",
                StateEnum.Failed => "failed",
                StateEnum.Finished => "finished",
                StateEnum.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateEnum? ToEnum(string value)
        {
            return value switch
            {
                "Timeout error" => StateEnum.TimeoutError,
                "failed" => StateEnum.Failed,
                "finished" => StateEnum.Finished,
                "processing" => StateEnum.Processing,
                _ => null,
            };
        }
    }
}