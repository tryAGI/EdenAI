
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `TRAINING` - TRAINING<br/>
    /// * `TEST` - TEST
    /// </summary>
    public enum TypeOfDataEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Test,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeOfDataEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeOfDataEnum value)
        {
            return value switch
            {
                TypeOfDataEnum.Test => "TEST",
                TypeOfDataEnum.Training => "TRAINING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeOfDataEnum? ToEnum(string value)
        {
            return value switch
            {
                "TEST" => TypeOfDataEnum.Test,
                "TRAINING" => TypeOfDataEnum.Training,
                _ => null,
            };
        }
    }
}