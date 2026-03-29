
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `succeeded` - Status Succeeded<br/>
    /// * `failed` - Status Failed<br/>
    /// * `finished` - Status Finished<br/>
    /// * `processing` - Status Processing
    /// </summary>
    public enum Status889Enum
    {
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
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Status889EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status889Enum value)
        {
            return value switch
            {
                Status889Enum.Failed => "failed",
                Status889Enum.Finished => "finished",
                Status889Enum.Processing => "processing",
                Status889Enum.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status889Enum? ToEnum(string value)
        {
            return value switch
            {
                "failed" => Status889Enum.Failed,
                "finished" => Status889Enum.Finished,
                "processing" => Status889Enum.Processing,
                "succeeded" => Status889Enum.Succeeded,
                _ => null,
            };
        }
    }
}