
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRole value)
        {
            return value switch
            {
                ChatRole.Assistant => "assistant",
                ChatRole.Function => "function",
                ChatRole.System => "system",
                ChatRole.Tool => "tool",
                ChatRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatRole.Assistant,
                "function" => ChatRole.Function,
                "system" => ChatRole.System,
                "tool" => ChatRole.Tool,
                "user" => ChatRole.User,
                _ => null,
            };
        }
    }
}