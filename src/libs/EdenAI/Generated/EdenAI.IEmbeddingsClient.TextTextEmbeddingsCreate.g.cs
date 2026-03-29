#nullable enable

namespace EdenAI
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**1536__text-embedding-ada-002**|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-large**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-small**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002-v2**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-embedding-001**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-v4.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**mistral**|**1024__mistral-embed**|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral/mistral-embed**|`v0.0.1`|0.1 (per 1000000 seconde)|1 seconde<br/>
        /// |**mistral**|**mistral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed-2505**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**jina**|-|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v2-base-en**|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v3**|`v1`|0.02 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-embeddings' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`1536__text-embedding-ada-002`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**cohere**|`4096__embed-english-v2.0`|<br/>
        /// |**mistral**|`1024__mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextembeddingsResponseModel> TextTextEmbeddingsCreateAsync(

            global::EdenAI.TextembeddingsEmbeddingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**1536__text-embedding-ada-002**|`v3.0.0`|0.1 (per 1000000 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-large**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-3-small**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**openai**|**text-embedding-ada-002-v2**|`v3.0.0`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-embedding-001**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-english-light-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-v2.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-v4.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**cohere**|**embed-multilingual-light-v3.0**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**mistral**|**1024__mistral-embed**|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|0.1 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral/mistral-embed**|`v0.0.1`|0.1 (per 1000000 seconde)|1 seconde<br/>
        /// |**mistral**|**mistral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**mistral**|**codestral-embed-2505**|`v0.0.1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**jina**|-|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v2-base-en**|`v1`|0.018 (per 1000000 token)|1 token<br/>
        /// |**jina**|**jina-embeddings-v3**|`v1`|0.02 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-embeddings' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`1536__text-embedding-ada-002`|<br/>
        /// |**google**|`text-multilingual-embedding-002`|<br/>
        /// |**cohere**|`4096__embed-english-v2.0`|<br/>
        /// |**mistral**|`1024__mistral-embed`|<br/>
        /// |**jina**|`jina-embeddings-v3`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </param>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </param>
        /// <param name="fallbackProviders">
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </param>
        /// <param name="responseAsDict">
        /// Optional : When set to **true** (default), the response is an object of responses with providers names as keys :  <br/>
        ///                   ``` {"google" : { "status": "success", ... }, } ``` <br/>
        ///                 When set to **false** the response structure is a list of response objects :  <br/>
        ///                    ``` [{"status": "success", "provider": "google" ... }, ] ```. <br/>
        ///                   <br/>
        /// Default Value: true
        /// </param>
        /// <param name="attributesAsList">
        /// Optional : When set to **false** (default) the structure of the extracted items is list of objects having different attributes : <br/>
        ///      ```{'items': [{"attribute_1": "x1","attribute_2": "y2"}, ... ]}``` <br/>
        ///      When it is set to **true**, the response contains an object with each attribute as a list : <br/>
        ///      ```{ "attribute_1": ["x1","x2", ...], "attribute_2": [y1, y2, ...]}``` <br/>
        /// Default Value: false
        /// </param>
        /// <param name="showBase64">
        /// Default Value: true
        /// </param>
        /// <param name="showOriginalResponse">
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="texts">
        /// List of texts to transform into embeddings.
        /// </param>
        /// <param name="dimensions">
        ///  parameter to control the size of the output embedding vecto
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextembeddingsResponseModel> TextTextEmbeddingsCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            global::System.Collections.Generic.IList<string> texts,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            int? dimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}