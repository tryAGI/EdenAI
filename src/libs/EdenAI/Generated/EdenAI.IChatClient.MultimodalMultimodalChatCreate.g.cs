#nullable enable

namespace EdenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.MultimodalchatResponseModel> MultimodalMultimodalChatCreateAsync(

            global::EdenAI.MultimodalchatChatRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.MultimodalchatResponseModel>> MultimodalMultimodalChatCreateAsResponseAsync(

            global::EdenAI.MultimodalchatChatRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|4.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|18.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|0.4 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|15.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|30.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|0.6 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|14.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|0.4 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|12.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|60.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=multimodal-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-vision-latest`|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**mistral**|`pixtral-large-latest`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
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
        /// <param name="messages">
        /// A list containing all the conversations between the user and the assistant. Each item in the list should be a dictionary with two keys: 'role' and 'message'.<br/>
        /// **role**: Specifies the role of the speaker and can have the values 'user' or 'assistant'.<br/>
        /// **message**: A list of dictionaries. Each dictionary in the 'message' list must contain the keys 'type' and 'content'.<br/>
        /// #### Structure<br/>
        /// - **type**: Specifies the type of content and can be 'media_url', 'media_base64', or 'text'.<br/>
        /// - **content**: A dictionary with the actual content based on the 'type':<br/>
        ///   - If 'type' is 'media_url', 'content' must contain 'media_url' and must not contain 'media_base64' or 'text'.<br/>
        ///   - If 'type' is 'media_base64', 'content' must contain 'media_base64' and must not contain 'media_url' or 'text'.<br/>
        ///   - If 'type' is 'text', 'content' must contain 'text' and must not contain 'media_url' or 'media_base64'.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     'role': 'user',<br/>
        ///     'content': [<br/>
        ///       {<br/>
        ///         'type': 'text',<br/>
        ///         'content': {'text': 'Describe this image'}<br/>
        ///       },<br/>
        ///       {<br/>
        ///         'type': 'media_url',<br/>
        ///         'content': {<br/>
        ///            'media_url': 'https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg',<br/>
        ///            'media_type': 'image/jpeg'}<br/>
        ///       },<br/>
        ///     ]<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="chatbotGlobalAction">
        /// A system message that helps set the behavior of the assistant. For example, 'You are a helpful assistant'.
        /// </param>
        /// <param name="temperature">
        /// Controls the creativity of the model's responses. Higher values (up to 2) make the output more random, while lower values make it more focused and deterministic. A value of 0 (argmax sampling) is useful for scenarios requiring precise answers.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.<br/>
        /// Default Value: 2048
        /// </param>
        /// <param name="stopSequences">
        /// A list of sequences where the model will stop generating further tokens. Useful for controlling response length and format.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="topK">
        /// Limits the sampling pool to the top K options for each token. Setting this to a lower value can make the output more focused and deterministic.
        /// </param>
        /// <param name="topP">
        /// Enables nucleus sampling, where the model considers the smallest number of tokens whose cumulative probability is at least top_p. This allows for a dynamic selection of tokens based on probability, offering a balance between focus and creativity.
        /// </param>
        /// <param name="reasoningEffort">
        /// Optional parameter to control the model's reasoning depth. <br/>
        /// Allows specifying the level of analytical effort in generating responses. <br/>
        /// **Choices**:<br/>
        /// - 'low': Minimal reasoning, quick responses<br/>
        /// - 'medium': Balanced reasoning approach<br/>
        /// - 'high': In-depth, comprehensive reasoning<br/>
        /// **Example**: 'high' for complex problem-solving tasks<br/>
        /// * `low` - low<br/>
        /// * `medium` - medium<br/>
        /// * `high` - high
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.MultimodalchatResponseModel> MultimodalMultimodalChatCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            global::System.Collections.Generic.IList<object> messages,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? chatbotGlobalAction = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topK = default,
            double? topP = default,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}