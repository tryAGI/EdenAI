
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `success` - Success<br/>
    /// * `failed` - Failed<br/>
    /// * `processing` - Processing
    /// </summary>
    public enum ExecutionContentCreateStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionContentCreateStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionContentCreateStatusEnum value)
        {
            return value switch
            {
                ExecutionContentCreateStatusEnum.Failed => "failed",
                ExecutionContentCreateStatusEnum.Processing => "processing",
                ExecutionContentCreateStatusEnum.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionContentCreateStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExecutionContentCreateStatusEnum.Failed,
                "processing" => ExecutionContentCreateStatusEnum.Processing,
                "success" => ExecutionContentCreateStatusEnum.Success,
                _ => null,
            };
        }
    }
}