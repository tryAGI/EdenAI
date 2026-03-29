namespace EdenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static EdenAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("EDENAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("EDENAI_API_KEY environment variable is not found.");

        var client = new EdenAIClient(apiKey);
        
        return client;
    }
}
