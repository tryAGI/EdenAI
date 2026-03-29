
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalchatChatRequest
    {
        /// <summary>
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Providers { get; set; }

        /// <summary>
        /// Providers in this list will be used as fallback if the call to provider in `providers` parameter fails.<br/>
        ///     To use this feature, you must input **only one** provider in the `providers` parameter. but you can put up to 5 fallbacks.<br/>
        /// They will be tried in the same order they are input, and it will stop to the first provider who doesn't fail.<br/>
        /// *Doesn't work with async subfeatures.*<br/>
        ///     <br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_providers")]
        public global::System.Collections.Generic.IList<string>? FallbackProviders { get; set; }

        /// <summary>
        /// Optional : When set to **true** (default), the response is an object of responses with providers names as keys :  <br/>
        ///                   ``` {"google" : { "status": "success", ... }, } ``` <br/>
        ///                 When set to **false** the response structure is a list of response objects :  <br/>
        ///                    ``` [{"status": "success", "provider": "google" ... }, ] ```. <br/>
        ///                   <br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_as_dict")]
        public bool? ResponseAsDict { get; set; }

        /// <summary>
        /// Optional : When set to **false** (default) the structure of the extracted items is list of objects having different attributes : <br/>
        ///      ```{'items': [{"attribute_1": "x1","attribute_2": "y2"}, ... ]}``` <br/>
        ///      When it is set to **true**, the response contains an object with each attribute as a list : <br/>
        ///      ```{ "attribute_1": ["x1","x2", ...], "attribute_2": [y1, y2, ...]}``` <br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes_as_list")]
        public bool? AttributesAsList { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_base_64")]
        public bool? ShowBase64 { get; set; }

        /// <summary>
        /// Optional : Shows the original response of the provider.<br/>
        ///         When set to **true**, a new attribute *original_response* will appear in the response object.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_original_response")]
        public bool? ShowOriginalResponse { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Messages { get; set; }

        /// <summary>
        /// A system message that helps set the behavior of the assistant. For example, 'You are a helpful assistant'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatbot_global_action")]
        public string? ChatbotGlobalAction { get; set; }

        /// <summary>
        /// Controls the creativity of the model's responses. Higher values (up to 2) make the output more random, while lower values make it more focused and deterministic. A value of 0 (argmax sampling) is useful for scenarios requiring precise answers.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. This value, combined with the token count of your prompt, cannot exceed the model's context length.<br/>
        /// Default Value: 2048
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of sequences where the model will stop generating further tokens. Useful for controlling response length and format.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Limits the sampling pool to the top K options for each token. Setting this to a lower value can make the output more focused and deterministic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Enables nucleus sampling, where the model considers the smallest number of tokens whose cumulative probability is at least top_p. This allows for a dynamic selection of tokens based on probability, offering a balance between focus and creativity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.ReasoningEffortEnumJsonConverter))]
        public global::EdenAI.ReasoningEffortEnum? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalchatChatRequest" /> class.
        /// </summary>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
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
        /// <param name="settings">
        /// A dictionnary or a json object to specify specific models to use for some providers.                      It can be in the following format: {"google" : "google_model", "ibm": "ibm_model"...}.<br/>
        ///                      <br/>
        /// Default Value: {}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalchatChatRequest(
            global::System.Collections.Generic.IList<string> providers,
            global::System.Collections.Generic.IList<object> messages,
            string? settings,
            global::System.Collections.Generic.IList<string>? fallbackProviders,
            bool? responseAsDict,
            bool? attributesAsList,
            bool? showBase64,
            bool? showOriginalResponse,
            string? chatbotGlobalAction,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<string>? stopSequences,
            int? topK,
            double? topP,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort)
        {
            this.Settings = settings;
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.FallbackProviders = fallbackProviders;
            this.ResponseAsDict = responseAsDict;
            this.AttributesAsList = attributesAsList;
            this.ShowBase64 = showBase64;
            this.ShowOriginalResponse = showOriginalResponse;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.ChatbotGlobalAction = chatbotGlobalAction;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.StopSequences = stopSequences;
            this.TopK = topK;
            this.TopP = topP;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalchatChatRequest" /> class.
        /// </summary>
        public MultimodalchatChatRequest()
        {
        }
    }
}