/*
order: 20
title: Translation
slug: translation

Shows how to translate text between languages via EdenAI.
*/

namespace EdenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Translation()
    {
        using var client = GetAuthenticatedClient();

        //// Translate text using the EdenAI unified API.
        //// Multiple providers are supported including Google, Amazon, Microsoft, and DeepL.
        var response = await client.AutomaticTranslation
            .TranslationTranslationAutomaticTranslationCreateAsync(
                request: new TranslationautomaticTranslationAutomaticTranslationRequest
                {
                    Providers = ["google"],
                    Text = "Hello, how are you?",
                    TargetLanguage = "fr",
                });

        Assert.IsNotNull(response);
    }
}
