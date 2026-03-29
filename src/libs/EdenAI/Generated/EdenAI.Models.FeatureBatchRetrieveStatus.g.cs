
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeatureBatchRetrieveStatus
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
    public static class FeatureBatchRetrieveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeatureBatchRetrieveStatus value)
        {
            return value switch
            {
                FeatureBatchRetrieveStatus.Failed => "failed",
                FeatureBatchRetrieveStatus.Finished => "finished",
                FeatureBatchRetrieveStatus.Processing => "processing",
                FeatureBatchRetrieveStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeatureBatchRetrieveStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => FeatureBatchRetrieveStatus.Failed,
                "finished" => FeatureBatchRetrieveStatus.Finished,
                "processing" => FeatureBatchRetrieveStatus.Processing,
                "succeeded" => FeatureBatchRetrieveStatus.Succeeded,
                _ => null,
            };
        }
    }
}