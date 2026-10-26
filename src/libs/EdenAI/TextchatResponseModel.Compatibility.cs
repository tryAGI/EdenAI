namespace EdenAI;

public sealed partial class TextchatResponseModel
{
    /// <summary>Legacy Meta provider data retained for existing response consumers.</summary>
    [System.Text.Json.Serialization.JsonPropertyName("meta")]
    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
    public TextchatChatDataClass? Meta { get; set; }

    /// <summary>Preserves the original positional provider constructor after upstream removed Meta.</summary>
    /// <param name="openai">The openai provider response.</param>
    /// <param name="togetherAi">The togetherAi provider response.</param>
    /// <param name="anthropic">The anthropic provider response.</param>
    /// <param name="replicate">The replicate provider response.</param>
    /// <param name="perplexityai">The perplexityai provider response.</param>
    /// <param name="meta">The meta provider response.</param>
    /// <param name="cohere">The cohere provider response.</param>
    /// <param name="microsoft">The microsoft provider response.</param>
    /// <param name="mistral">The mistral provider response.</param>
    /// <param name="groq">The groq provider response.</param>
    /// <param name="deepseek">The deepseek provider response.</param>
    /// <param name="google">The google provider response.</param>
    /// <param name="amazon">The amazon provider response.</param>
    /// <param name="xai">The xai provider response.</param>
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public TextchatResponseModel(
        TextchatChatDataClass? openai,
        TextchatChatDataClass? togetherAi,
        TextchatChatDataClass? anthropic,
        TextchatChatDataClass? replicate,
        TextchatChatDataClass? perplexityai,
        TextchatChatDataClass? meta,
        TextchatChatDataClass? cohere,
        TextchatChatDataClass? microsoft,
        TextchatChatDataClass? mistral,
        TextchatChatDataClass? groq,
        TextchatChatDataClass? deepseek,
        TextchatChatDataClass? google,
        TextchatChatDataClass? amazon,
        TextchatChatDataClass? xai)
        : this(openai, togetherAi, anthropic, replicate, perplexityai, cohere, microsoft, mistral, groq, deepseek, google, amazon, xai)
    {
        Meta = meta;
    }
}
