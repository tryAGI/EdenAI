
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// * `openai` - openai<br/>
    /// * `cohere` - cohere<br/>
    /// * `google` - google<br/>
    /// * `mistral` - mistral<br/>
    /// * `jina` - jina
    /// </summary>
    public enum EmbeddingsProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Jina,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsProviderEnum value)
        {
            return value switch
            {
                EmbeddingsProviderEnum.Cohere => "cohere",
                EmbeddingsProviderEnum.Google => "google",
                EmbeddingsProviderEnum.Jina => "jina",
                EmbeddingsProviderEnum.Mistral => "mistral",
                EmbeddingsProviderEnum.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "cohere" => EmbeddingsProviderEnum.Cohere,
                "google" => EmbeddingsProviderEnum.Google,
                "jina" => EmbeddingsProviderEnum.Jina,
                "mistral" => EmbeddingsProviderEnum.Mistral,
                "openai" => EmbeddingsProviderEnum.Openai,
                _ => null,
            };
        }
    }
}