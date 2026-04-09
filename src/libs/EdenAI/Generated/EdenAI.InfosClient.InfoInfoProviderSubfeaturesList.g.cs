
#nullable enable

namespace EdenAI
{
    public partial class InfosClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_InfoInfoProviderSubfeaturesListSecurityRequirement0 =
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
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_InfoInfoProviderSubfeaturesListSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_InfoInfoProviderSubfeaturesListSecurityRequirement0,
            };
        partial void PrepareInfoInfoProviderSubfeaturesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? featureName,
            ref string? gender,
            ref bool? isWorking,
            ref string? language,
            ref string? phaseName,
            ref string? providerName,
            ref string? subfeatureName);
        partial void PrepareInfoInfoProviderSubfeaturesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? featureName,
            string? gender,
            bool? isWorking,
            string? language,
            string? phaseName,
            string? providerName,
            string? subfeatureName);
        partial void ProcessInfoInfoProviderSubfeaturesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInfoInfoProviderSubfeaturesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Providers Subfeatures<br/>
        /// List Provider and features relations : You can get a list of *all providers* for a *feature* or *all features* for a *given provider*.<br/>
        /// You can have the detailed information on the **pricing**, **supported languages** as well as the **models** for providers who propose different models (eg: voice models available for a text to speech provider).<br/>
        /// Example : If you want the detailed list of all providers that can analyse the sentiment of a text written in french, you'd need to set `feature__name=text`,  `subfeature__name=sentiment_analysis` and `languages=fr`.<br/>
        /// Which will look like the following :<br/>
        /// ```bash<br/>
        /// curl --request GET  https://api.edenai.run/v2/info/provider_subfeatures?subfeature__name=sentiment_analysis&amp;feature__name=text&amp;languages=fr<br/>
        /// ```
        /// </summary>
        /// <param name="featureName"></param>
        /// <param name="gender"></param>
        /// <param name="isWorking"></param>
        /// <param name="language"></param>
        /// <param name="phaseName"></param>
        /// <param name="providerName"></param>
        /// <param name="subfeatureName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>> InfoInfoProviderSubfeaturesListAsync(
            string? featureName = default,
            string? gender = default,
            bool? isWorking = default,
            string? language = default,
            string? phaseName = default,
            string? providerName = default,
            string? subfeatureName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareInfoInfoProviderSubfeaturesListArguments(
                httpClient: HttpClient,
                featureName: ref featureName,
                gender: ref gender,
                isWorking: ref isWorking,
                language: ref language,
                phaseName: ref phaseName,
                providerName: ref providerName,
                subfeatureName: ref subfeatureName);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfoInfoProviderSubfeaturesListSecurityRequirements,
                operationName: "InfoInfoProviderSubfeaturesListAsync");

            var __pathBuilder = new global::EdenAI.PathBuilder(
                path: "/info/provider_subfeatures/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("feature__name", featureName)
                .AddOptionalParameter("gender", gender)
                .AddOptionalParameter("is_working", isWorking?.ToString().ToLowerInvariant())
                .AddOptionalParameter("language", language)
                .AddOptionalParameter("phase__name", phaseName)
                .AddOptionalParameter("provider__name", providerName)
                .AddOptionalParameter("subfeature__name", subfeatureName) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareInfoInfoProviderSubfeaturesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                featureName: featureName,
                gender: gender,
                isWorking: isWorking,
                language: language,
                phaseName: phaseName,
                providerName: providerName,
                subfeatureName: subfeatureName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessInfoInfoProviderSubfeaturesListResponse(
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
                ProcessInfoInfoProviderSubfeaturesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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