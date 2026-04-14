
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CostManagementCostManagementRetrieveGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CostManagementCostManagementRetrieveGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CostManagementCostManagementRetrieveGroupBy value)
        {
            return value switch
            {
                CostManagementCostManagementRetrieveGroupBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CostManagementCostManagementRetrieveGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "user" => CostManagementCostManagementRetrieveGroupBy.User,
                _ => null,
            };
        }
    }
}