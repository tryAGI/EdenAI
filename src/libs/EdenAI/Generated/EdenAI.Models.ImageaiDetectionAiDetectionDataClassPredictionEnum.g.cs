
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageaiDetectionAiDetectionDataClassPredictionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AiGenerated,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageaiDetectionAiDetectionDataClassPredictionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageaiDetectionAiDetectionDataClassPredictionEnum value)
        {
            return value switch
            {
                ImageaiDetectionAiDetectionDataClassPredictionEnum.AiGenerated => "ai-generated",
                ImageaiDetectionAiDetectionDataClassPredictionEnum.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageaiDetectionAiDetectionDataClassPredictionEnum? ToEnum(string value)
        {
            return value switch
            {
                "ai-generated" => ImageaiDetectionAiDetectionDataClassPredictionEnum.AiGenerated,
                "original" => ImageaiDetectionAiDetectionDataClassPredictionEnum.Original,
                _ => null,
            };
        }
    }
}