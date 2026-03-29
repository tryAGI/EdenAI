/* order: 40, title: MEAI Tools, slug: meai-tools */

namespace EdenAI.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// EdenAI provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("EDENAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("EDENAI_API_KEY environment variable is not found.");

        using var client = new EdenAIClient(apiKey);

        //// Create tools for chat, translation, image generation, summarization,
        //// sentiment analysis, and language detection.
        var chatTool = client.AsChatTool();
        var translateTool = client.AsTranslateTool();
        var generateImageTool = client.AsGenerateImageTool();
        var summarizeTool = client.AsSummarizeTool();
        var sentimentTool = client.AsSentimentAnalysisTool();
        var detectLanguageTool = client.AsDetectLanguageTool();

        Assert.AreEqual("EdenAI_Chat", chatTool.Name);
        Assert.AreEqual("EdenAI_Translate", translateTool.Name);
        Assert.AreEqual("EdenAI_GenerateImage", generateImageTool.Name);
        Assert.AreEqual("EdenAI_Summarize", summarizeTool.Name);
        Assert.AreEqual("EdenAI_SentimentAnalysis", sentimentTool.Name);
        Assert.AreEqual("EdenAI_DetectLanguage", detectLanguageTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { chatTool, translateTool, generateImageTool, summarizeTool, sentimentTool, detectLanguageTool };
        Assert.AreEqual(6, tools.Length);
    }
}
