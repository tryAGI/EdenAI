#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace EdenAI;

public static class EdenAIClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that sends a chat message to an AI provider via EdenAI.
    /// Supports multi-provider routing with automatic fallback.
    /// </summary>
    public static AIFunction AsChatTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text message to send to the AI model")] string text,
                   [Description("The AI provider to use (e.g. 'openai', 'google', 'anthropic', 'mistral', 'cohere')")] string provider,
                   [Description("Optional system prompt to set the assistant behavior")] string? systemPrompt = null,
                   [Description("Optional maximum number of tokens to generate")] int? maxTokens = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Chat.TextTextChatCreateAsync(
                    request: new TextchatChatRequest
                    {
                        Providers = [provider],
                        Text = text,
                        ChatbotGlobalAction = systemPrompt,
                        MaxTokens = maxTokens,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_Chat",
            description: "Send a chat message to an AI provider (OpenAI, Google, Anthropic, etc.) via the EdenAI unified API. Returns the model's response.");
    }

    /// <summary>
    /// Creates an AIFunction tool that translates text between languages via EdenAI.
    /// </summary>
    public static AIFunction AsTranslateTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text to translate")] string text,
                   [Description("The target language code (e.g. 'en', 'fr', 'de', 'es', 'ja', 'zh')")] string targetLanguage,
                   [Description("The AI provider to use (e.g. 'google', 'amazon', 'microsoft', 'deepl')")] string provider = "google",
                   [Description("Optional source language code; auto-detected if not specified")] string? sourceLanguage = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.AutomaticTranslation.TranslationTranslationAutomaticTranslationCreateAsync(
                    request: new TranslationautomaticTranslationAutomaticTranslationRequest
                    {
                        Providers = [provider],
                        Text = text,
                        TargetLanguage = targetLanguage,
                        SourceLanguage = sourceLanguage,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_Translate",
            description: "Translate text between languages using AI providers (Google, Amazon, Microsoft, DeepL) via the EdenAI unified API.");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates images from text descriptions via EdenAI.
    /// </summary>
    public static AIFunction AsGenerateImageTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("A text description of the image to generate")] string text,
                   [Description("The AI provider to use (e.g. 'openai', 'stabilityai', 'amazon')")] string provider = "openai",
                   [Description("Image resolution (e.g. '512x512', '1024x1024')")] string resolution = "1024x1024",
                   [Description("Number of images to generate (1-10)")] int numImages = 1,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Generation.ImageImageGenerationCreateAsync(
                    request: new ImagegenerationGenerationRequest
                    {
                        Providers = [provider],
                        Text = text,
                        Resolution = resolution,
                        NumImages = numImages,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_GenerateImage",
            description: "Generate images from text descriptions using AI providers (OpenAI DALL-E, Stability AI, Amazon) via the EdenAI unified API.");
    }

    /// <summary>
    /// Creates an AIFunction tool that summarizes text via EdenAI.
    /// </summary>
    public static AIFunction AsSummarizeTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text to summarize")] string text,
                   [Description("The AI provider to use (e.g. 'openai', 'cohere', 'anthropic', 'google')")] string provider = "openai",
                   [Description("Optional number of sentences in the summary")] int? outputSentences = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Summarize.TextTextSummarizeCreateAsync(
                    request: new TextsummarizeSummarizeRequest
                    {
                        Providers = [provider],
                        Text = text,
                        OutputSentences = outputSentences,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_Summarize",
            description: "Summarize text using AI providers (OpenAI, Cohere, Anthropic, Google) via the EdenAI unified API.");
    }

    /// <summary>
    /// Creates an AIFunction tool that analyzes sentiment of text via EdenAI.
    /// </summary>
    public static AIFunction AsSentimentAnalysisTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text to analyze sentiment for")] string text,
                   [Description("The AI provider to use (e.g. 'google', 'amazon', 'ibm', 'openai')")] string provider = "google",
                   [Description("Optional language code of the text (e.g. 'en', 'fr')")] string? language = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.SentimentAnalysis.TextTextSentimentAnalysisCreateAsync(
                    request: new TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest
                    {
                        Providers = [provider],
                        Text = text,
                        Language = language,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_SentimentAnalysis",
            description: "Analyze the sentiment of text (positive, negative, neutral) using AI providers via the EdenAI unified API.");
    }

    /// <summary>
    /// Creates an AIFunction tool that detects the language of text via EdenAI.
    /// </summary>
    public static AIFunction AsDetectLanguageTool(this EdenAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text to detect the language of")] string text,
                   [Description("The AI provider to use (e.g. 'google', 'amazon', 'microsoft', 'openai')")] string provider = "google",
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.LanguageDetection.TranslationTranslationLanguageDetectionCreateAsync(
                    request: new TranslationlanguageDetectionLanguageDetectionRequest
                    {
                        Providers = [provider],
                        Text = text,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "EdenAI_DetectLanguage",
            description: "Detect the language of a given text using AI providers (Google, Amazon, Microsoft) via the EdenAI unified API.");
    }
}
