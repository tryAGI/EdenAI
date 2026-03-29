
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PredictionB20Enum
    {
        /// <summary>
        /// 
        /// </summary>
        Deepfake,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionB20EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionB20Enum value)
        {
            return value switch
            {
                PredictionB20Enum.Deepfake => "deepfake",
                PredictionB20Enum.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionB20Enum? ToEnum(string value)
        {
            return value switch
            {
                "deepfake" => PredictionB20Enum.Deepfake,
                "original" => PredictionB20Enum.Original,
                _ => null,
            };
        }
    }
}