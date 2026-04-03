
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotCreateOperationsClient
    {
        partial void PrepareAiproductsAiproductsAskyodaV2CreateBotPromptCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? fileUrls,
            ref string model,
            ref string name,
            object? @params,
            ref global::System.Guid projectId,
            ref string? systemPrompt,
            ref string text);
        partial void PrepareAiproductsAiproductsAskyodaV2CreateBotPromptCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? fileUrls,
            string model,
            string name,
            object? @params,
            global::System.Guid projectId,
            string? systemPrompt,
            string text);
        partial void ProcessAiproductsAiproductsAskyodaV2CreateBotPromptCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create Bot Profile<br/>
        /// Create a default bot prompt for your RAG project.<br/>
        /// The bot prompt serves as the default system message or personality definition for your RAG-powered chatbot. This prompt helps define how your bot should interact with users and what context it should consider when processing queries.
        /// </summary>
        /// <param name="fileUrls"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="params"></param>
        /// <param name="projectId"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2CreateBotPromptCreateAsync(
            string model,
            string name,
            global::System.Guid projectId,
            string text,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            object? @params = default,
            string? systemPrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2CreateBotPromptCreateArguments(
                httpClient: HttpClient,
                fileUrls: fileUrls,
                model: ref model,
                name: ref name,
                @params: @params,
                projectId: ref projectId,
                systemPrompt: ref systemPrompt,
                text: ref text);

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/create_bot_prompt/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("file_urls", fileUrls, delimiter: ",", explode: true)
                .AddRequiredParameter("model", model)
                .AddRequiredParameter("name", name)
                .AddOptionalParameter("params", @params?.ToString())
                .AddOptionalParameter("system_prompt", systemPrompt)
                .AddRequiredParameter("text", text) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareAiproductsAiproductsAskyodaV2CreateBotPromptCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileUrls: fileUrls,
                model: model,
                name: name,
                @params: @params,
                projectId: projectId,
                systemPrompt: systemPrompt,
                text: text);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2CreateBotPromptCreateResponse(
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