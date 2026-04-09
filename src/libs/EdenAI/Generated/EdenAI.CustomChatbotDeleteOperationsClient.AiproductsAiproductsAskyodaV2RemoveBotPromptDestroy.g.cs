
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotDeleteOperationsClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirement0 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                {                    new global::EdenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirement0,
                s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirement1,
            };
        partial void PrepareAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid projectId);
        partial void PrepareAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid projectId);
        partial void ProcessAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove Bot Prompt<br/>
        /// Remove the bot prompt from your RAG project.<br/>
        ///  This endpoint removes the custom bot prompt from your project, effectively resetting the bot's personality to system defaults. This action cannot be undone, but you can always set a new bot prompt later.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2RemoveBotPromptDestroyAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyArguments(
                httpClient: HttpClient,
                projectId: ref projectId);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AiproductsAiproductsAskyodaV2RemoveBotPromptDestroySecurityRequirements,
                operationName: "AiproductsAiproductsAskyodaV2RemoveBotPromptDestroyAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/remove_bot_prompt/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2RemoveBotPromptDestroyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::EdenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}