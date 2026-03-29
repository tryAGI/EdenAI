/*
order: 30
title: Image Generation
slug: image-generation

Shows how to generate images from text descriptions via EdenAI.
*/

namespace EdenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ImageGeneration()
    {
        using var client = GetAuthenticatedClient();

        //// Generate images from text descriptions using the EdenAI unified API.
        //// Supported providers include OpenAI (DALL-E), Stability AI, and Amazon.
        var response = await client.Generation.ImageImageGenerationCreateAsync(
            request: new ImagegenerationGenerationRequest
            {
                Providers = ["openai"],
                Text = "A serene mountain landscape at sunset",
                Resolution = "1024x1024",
                NumImages = 1,
            });

        Assert.IsNotNull(response);
    }
}
