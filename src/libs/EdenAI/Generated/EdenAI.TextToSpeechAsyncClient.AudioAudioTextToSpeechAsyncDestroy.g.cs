
#nullable enable

namespace EdenAI
{
    public partial class TextToSpeechAsyncClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioTextToSpeechAsyncDestroySecurityRequirement0 =
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

        private static readonly global::EdenAI.EndPointSecurityRequirement s_AudioAudioTextToSpeechAsyncDestroySecurityRequirement1 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_AudioAudioTextToSpeechAsyncDestroySecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_AudioAudioTextToSpeechAsyncDestroySecurityRequirement0,
                s_AudioAudioTextToSpeechAsyncDestroySecurityRequirement1,
            };
        partial void PrepareAudioAudioTextToSpeechAsyncDestroyArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareAudioAudioTextToSpeechAsyncDestroyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessAudioAudioTextToSpeechAsyncDestroyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text To Speech delete Jobs<br/>
        /// Generic class to handle method GET all async job for user<br/>
        /// Attributes:<br/>
        ///     feature (str): EdenAI feature<br/>
        ///     subfeature (str): EdenAI subfeature
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AudioAudioTextToSpeechAsyncDestroyAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAudioAudioTextToSpeechAsyncDestroyArguments(
                httpClient: HttpClient);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioAudioTextToSpeechAsyncDestroySecurityRequirements,
                operationName: "AudioAudioTextToSpeechAsyncDestroyAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/audio/text_to_speech_async/",
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
            PrepareAudioAudioTextToSpeechAsyncDestroyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAudioAudioTextToSpeechAsyncDestroyResponse(
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