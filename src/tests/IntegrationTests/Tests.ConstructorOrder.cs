namespace EdenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(typeof(TextchatResponseModel), "openai,togetherAi,anthropic,replicate,perplexityai,meta,cohere,microsoft,mistral,groq,deepseek,google,amazon,xai")]
    [DataRow(typeof(AudiospeechToTextAsyncModel), "openai,assembly,speechmatics,greenpt,deepgram,microsoft,voci,gradium,oneai,google,symbl,gladia,faker,amazon,voxist")]
    [DataRow(typeof(ImagegenerationResponseModel), "bytedance,openai,ovhcloud,replicate,deepai,google,minimax,stabilityai,leonardo,pruna,amazon,ionos")]
    public void LegacyProviderConstructorOrderIsStable(Type modelType, string legacyOrder)
    {
        // Every provider uses the same CLR parameter type: reordering silently
        // changes positional calls, even when a binary API comparison is clean.
        var parameters = modelType.GetConstructors()
            .Single(constructor => constructor.GetParameters().Length > 0)
            .GetParameters().Select(parameter => parameter.Name).ToArray();
        var expected = legacyOrder.Split(',');
        parameters.Take(expected.Length).Should().Equal(expected);
    }
}
