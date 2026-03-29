# CLAUDE.md -- EdenAI SDK

## Overview

Auto-generated C# SDK for [EdenAI](https://www.edenai.co/) -- unified AI gateway with 500+ models across text, image, audio, video, OCR, and translation from multiple providers (OpenAI, Google, Amazon, Anthropic, etc.).
OpenAPI spec from `https://api.edenai.run/v2/info/schema` (36MB raw; stripped inline examples to ~1MB).

## Build & Test

```bash
dotnet build EdenAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token via `Authorization: Bearer <token>`. Constructor:

```csharp
var client = new EdenAIClient(apiKey); // EDENAI_API_KEY env var
```

## Key Files

- `src/libs/EdenAI/openapi.json` -- Cleaned OpenAPI 3.0.3 spec (examples stripped)
- `src/libs/EdenAI/generate.sh` -- Downloads spec, strips examples with Python, runs autosdk
- `src/libs/EdenAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/EdenAI/Extensions/EdenAIClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new EdenAIClient(apiKey);

// Text / LLM
client.Chat.TextTextChatCreateAsync(...)                 // Chat completion
client.Chat.TextTextChatStreamCreateAsync(...)           // Streaming chat
client.Embeddings.TextTextEmbeddingsCreateAsync(...)     // Text embeddings
client.Summarize.TextTextSummarizeCreateAsync(...)       // Text summarization
client.SentimentAnalysis.TextTextSentimentAnalysisCreateAsync(...) // Sentiment

// Translation
client.AutomaticTranslation.TranslationTranslationAutomaticTranslationCreateAsync(...)
client.LanguageDetection.TranslationTranslationLanguageDetectionCreateAsync(...)

// Image
client.Generation.ImageImageGenerationCreateAsync(...)   // Image generation
client.ObjectDetection.ImageImageObjectDetectionCreateAsync(...) // Object detection
client.FaceDetection.ImageImageFaceDetectionCreateAsync(...)     // Face detection

// Audio
client.TextToSpeech.AudioAudioTextToSpeechCreateAsync(...)       // TTS
client.SpeechToTextAsync.AudioAudioSpeechToTextAsyncCreateAsync(...)  // STT (async)

// OCR
client.Ocr.OcrOcrOcrCreateAsync(...)                     // OCR
client.FinancialParser.OcrOcrFinancialParserCreateAsync(...)  // Financial parser
client.IdentityParser.OcrOcrIdentityParserCreateAsync(...)   // ID parser
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsChatTool()` -- Send chat messages to any AI provider
- `AsTranslateTool()` -- Translate text between languages
- `AsGenerateImageTool()` -- Generate images from text descriptions
- `AsSummarizeTool()` -- Summarize text
- `AsSentimentAnalysisTool()` -- Analyze text sentiment
- `AsDetectLanguageTool()` -- Detect the language of text

## Spec Notes

- Base URL: `https://api.edenai.run/v2`
- OpenAPI 3.0.3 with 141 paths, 207 operations, 444 schemas
- Auth: `FeatureApiAuth` (HTTP Bearer JWT)
- Raw spec is 36MB due to massive inline response examples; `generate.sh` strips them
- Wildcard batch path `/{feature}/{subfeature}/batch/{name}/` has operationIds fixed
- All endpoints require `providers` array parameter (multi-provider routing)
- Async operations (STT, video) use POST -> GET with `public_id` polling
