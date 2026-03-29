
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// This enum are used to categorize the explicit content extracted from the text
    /// </summary>
    public enum CategoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
        /// <summary>
        /// 
        /// </summary>
        DrugAndAlcohol,
        /// <summary>
        /// 
        /// </summary>
        Finance,
        /// <summary>
        /// 
        /// </summary>
        HateAndExtremism,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        Toxic,
        /// <summary>
        /// 
        /// </summary>
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CategoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CategoryType value)
        {
            return value switch
            {
                CategoryType.Content => "Content",
                CategoryType.DrugAndAlcohol => "DrugAndAlcohol",
                CategoryType.Finance => "Finance",
                CategoryType.HateAndExtremism => "HateAndExtremism",
                CategoryType.Other => "Other",
                CategoryType.Safe => "Safe",
                CategoryType.Sexual => "Sexual",
                CategoryType.Toxic => "Toxic",
                CategoryType.Violence => "Violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CategoryType? ToEnum(string value)
        {
            return value switch
            {
                "Content" => CategoryType.Content,
                "DrugAndAlcohol" => CategoryType.DrugAndAlcohol,
                "Finance" => CategoryType.Finance,
                "HateAndExtremism" => CategoryType.HateAndExtremism,
                "Other" => CategoryType.Other,
                "Safe" => CategoryType.Safe,
                "Sexual" => CategoryType.Sexual,
                "Toxic" => CategoryType.Toxic,
                "Violence" => CategoryType.Violence,
                _ => null,
            };
        }
    }
}