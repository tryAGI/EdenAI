#nullable enable

namespace EdenAI
{
    public partial interface IInfosClient
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>> InfoInfoProviderSubfeaturesListAsync(
            string? featureName = default,
            string? gender = default,
            bool? isWorking = default,
            string? language = default,
            string? phaseName = default,
            string? providerName = default,
            string? subfeatureName = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>>> InfoInfoProviderSubfeaturesListAsResponseAsync(
            string? featureName = default,
            string? gender = default,
            bool? isWorking = default,
            string? language = default,
            string? phaseName = default,
            string? providerName = default,
            string? subfeatureName = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}