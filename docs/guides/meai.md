# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The EdenAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to EdenAI's unified gateway for chat, translation, image generation, summarization, sentiment analysis, and language detection across multiple AI providers.

## Installation

```bash
dotnet add package EdenAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsChatTool()` | `EdenAI_Chat` | Send a chat message to any AI provider (OpenAI, Google, Anthropic, etc.) |
| `AsTranslateTool()` | `EdenAI_Translate` | Translate text between languages using multiple providers |
| `AsGenerateImageTool()` | `EdenAI_GenerateImage` | Generate images from text descriptions |
| `AsSummarizeTool()` | `EdenAI_Summarize` | Summarize text using AI providers |
| `AsSentimentAnalysisTool()` | `EdenAI_SentimentAnalysis` | Analyze text sentiment (positive/negative/neutral) |
| `AsDetectLanguageTool()` | `EdenAI_DetectLanguage` | Detect the language of text |

## Usage

```csharp
using EdenAI;
using Microsoft.Extensions.AI;

var edenClient = new EdenAIClient(
    apiKey: Environment.GetEnvironmentVariable("EDENAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        edenClient.AsTranslateTool(),
        edenClient.AsSummarizeTool(),
        edenClient.AsSentimentAnalysisTool(),
        edenClient.AsDetectLanguageTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Detect the language of 'Bonjour le monde' and then translate it to English."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
