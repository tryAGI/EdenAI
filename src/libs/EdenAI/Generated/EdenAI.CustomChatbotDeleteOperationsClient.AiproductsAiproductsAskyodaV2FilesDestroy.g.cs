
#nullable enable

namespace EdenAI
{
    public partial class CustomChatbotDeleteOperationsClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirement0,
                s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirement1,
            };
        partial void PrepareAiproductsAiproductsAskyodaV2FilesDestroyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid fileId,
            ref global::System.Guid projectId);
        partial void PrepareAiproductsAiproductsAskyodaV2FilesDestroyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid fileId,
            global::System.Guid projectId);
        partial void ProcessAiproductsAiproductsAskyodaV2FilesDestroyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AiproductsAiproductsAskyodaV2FilesDestroyAsync(
            global::System.Guid fileId,
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAiproductsAiproductsAskyodaV2FilesDestroyArguments(
                httpClient: HttpClient,
                fileId: ref fileId,
                projectId: ref projectId);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AiproductsAiproductsAskyodaV2FilesDestroySecurityRequirements,
                operationName: "AiproductsAiproductsAskyodaV2FilesDestroyAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: $"/aiproducts/askyoda/v2/{projectId}/files/{fileId}/",
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
            PrepareAiproductsAiproductsAskyodaV2FilesDestroyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileId: fileId,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAiproductsAiproductsAskyodaV2FilesDestroyResponse(
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