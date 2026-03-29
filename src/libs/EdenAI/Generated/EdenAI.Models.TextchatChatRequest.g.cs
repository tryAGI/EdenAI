
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextchatChatRequest
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
        /// Start your conversation here...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A system message that helps set the behavior of the assistant. For example, 'You are a helpful assistant'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatbot_global_action")]
        public string? ChatbotGlobalAction { get; set; }

        /// <summary>
        /// A list containing all the previous conversations between the user and the chatbot AI. Each item in the list should be a dictionary with two keys: 'role' and 'message'. The 'role' key specifies the role of the speaker and can have the values 'user' or 'assistant'. The 'message' key contains the text of the conversation from the respective role. For example: [{'role': 'user', 'message': 'Hello'}, {'role': 'assistant', 'message': 'Hi, how can I help you?'}, ...]. This format allows easy identification of the speaker's role and their corresponding message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_history")]
        public global::System.Collections.Generic.IList<global::EdenAI.ChatMessageRequest>? PreviousHistory { get; set; }

        /// <summary>
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// `auto`: the model will choose to use tools if needed, `required`: force model to use any of the available tools, `none`: force model to not select a tool<br/>
        /// * `auto` - auto<br/>
        /// * `required` - required<br/>
        /// * `none` - none<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.ToolChoiceEnumJsonConverter))]
        public global::EdenAI.ToolChoiceEnum? ToolChoice { get; set; }

        /// <summary>
        /// A list of tools the model may generate the right arguments for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_tools")]
        public global::System.Collections.Generic.IList<global::EdenAI.ChatAvailableToolsRequest>? AvailableTools { get; set; }

        /// <summary>
        /// List of results obtained from applying the tool_call arguments to your own tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_results")]
        public global::System.Collections.Generic.IList<global::EdenAI.ChatToolResultRequest>? ToolResults { get; set; }

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
        /// Initializes a new instance of the <see cref="TextchatChatRequest" /> class.
        /// </summary>
        /// <param name="providers">
        /// It can be one (ex: **'amazon'** or **'google'**) or multiple provider(s) (ex: **'amazon,microsoft,google'**)             that the data will be redirected to in order to get the processed results.             Providers can also be invoked with specific models (ex: providers: **'amazon/model1, amazon/model2, google/model3'**)
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
        /// <param name="text">
        /// Start your conversation here...
        /// </param>
        /// <param name="chatbotGlobalAction">
        /// A system message that helps set the behavior of the assistant. For example, 'You are a helpful assistant'.
        /// </param>
        /// <param name="previousHistory">
        /// A list containing all the previous conversations between the user and the chatbot AI. Each item in the list should be a dictionary with two keys: 'role' and 'message'. The 'role' key specifies the role of the speaker and can have the values 'user' or 'assistant'. The 'message' key contains the text of the conversation from the respective role. For example: [{'role': 'user', 'message': 'Hello'}, {'role': 'assistant', 'message': 'Hi, how can I help you?'}, ...]. This format allows easy identification of the speaker's role and their corresponding message.
        /// </param>
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="toolChoice">
        /// `auto`: the model will choose to use tools if needed, `required`: force model to use any of the available tools, `none`: force model to not select a tool<br/>
        /// * `auto` - auto<br/>
        /// * `required` - required<br/>
        /// * `none` - none<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="availableTools">
        /// A list of tools the model may generate the right arguments for.
        /// </param>
        /// <param name="toolResults">
        /// List of results obtained from applying the tool_call arguments to your own tool.
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
        public TextchatChatRequest(
            global::System.Collections.Generic.IList<string> providers,
            string? settings,
            global::System.Collections.Generic.IList<string>? fallbackProviders,
            bool? responseAsDict,
            bool? attributesAsList,
            bool? showBase64,
            bool? showOriginalResponse,
            string? text,
            string? chatbotGlobalAction,
            global::System.Collections.Generic.IList<global::EdenAI.ChatMessageRequest>? previousHistory,
            double? temperature,
            int? maxTokens,
            global::EdenAI.ToolChoiceEnum? toolChoice,
            global::System.Collections.Generic.IList<global::EdenAI.ChatAvailableToolsRequest>? availableTools,
            global::System.Collections.Generic.IList<global::EdenAI.ChatToolResultRequest>? toolResults,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort)
        {
            this.Settings = settings;
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.FallbackProviders = fallbackProviders;
            this.ResponseAsDict = responseAsDict;
            this.AttributesAsList = attributesAsList;
            this.ShowBase64 = showBase64;
            this.ShowOriginalResponse = showOriginalResponse;
            this.Text = text;
            this.ChatbotGlobalAction = chatbotGlobalAction;
            this.PreviousHistory = previousHistory;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ToolChoice = toolChoice;
            this.AvailableTools = availableTools;
            this.ToolResults = toolResults;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextchatChatRequest" /> class.
        /// </summary>
        public TextchatChatRequest()
        {
        }
    }
}