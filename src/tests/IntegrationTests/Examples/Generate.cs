/*
order: 10
title: Chat
slug: chat

Shows how to send a chat message to an AI provider via EdenAI.
*/

namespace EdenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Chat()
    {
        using var client = GetAuthenticatedClient();

        //// Send a chat message through the EdenAI unified API,
        //// specifying one or more providers to route the request to.
        var response = await client.Chat.TextTextChatCreateAsync(
            request: new TextchatChatRequest
            {
                Providers = ["openai"],
                Text = "What is the capital of France?",
                ChatbotGlobalAction = "You are a helpful geography assistant.",
                MaxTokens = 100,
            });

        Assert.IsNotNull(response);
    }
}
