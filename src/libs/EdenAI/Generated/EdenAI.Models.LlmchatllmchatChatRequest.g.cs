
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmchatllmchatChatRequest
    {
        /// <summary>
        /// A list containing all the conversations between the user and the assistant.<br/>
        /// Each item in the list should be a dictionary with two keys: 'role' and 'message'.<br/>
        /// **role**: Specifies the role of the speaker and can have the values 'user', 'system', 'assistant' or 'tool'.<br/>
        /// The system role instructs the way the model should answer, e.g. 'You are a helpful assistant'. The user<br/>
        /// role specifies the user query and assistant is the model's response. The tool role is for external tools that<br/>
        /// can be used in the conversation.<br/>
        /// **message**: A list of dictionaries. Each dictionary in the 'message' list must contain the keys 'type' and 'content'.<br/>
        /// #### Structure<br/>
        /// - **type**: Specifies the type of content and can be 'image_url' or 'text'.<br/>
        /// - **content**: A dictionary with the actual content based on the 'type':<br/>
        ///     - If 'type' is 'image_url', 'content' must contain 'image_url' and must not contain 'text'.<br/>
        ///     - If 'type' is 'text', 'content' must contain 'text' and must not contain 'image_url'.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": [<br/>
        ///         {<br/>
        ///           "type": "text",<br/>
        ///           "text": "Describe this image"<br/>
        ///         },<br/>
        ///         {<br/>
        ///         "type": "image_url",<br/>
        ///         "image_url": {<br/>
        ///           "url": "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg"<br/>
        ///           }<br/>
        ///         }<br/>
        ///     ]<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Messages { get; set; }

        /// <summary>
        /// The OpenAI model to use for the chat completion. <br/>
        /// This field is required and specifies which language model will process the conversation. <br/>
        /// **Example values**: 'gpt-3.5-turbo', 'gpt-4', 'gpt-4-turbo'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

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
        /// Optional list of metadata associated with the chat request. <br/>
        /// Can be used to provide additional context or tracking information. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "metadata": [<br/>
        ///     {"key": "conversation_id", "value": "chat_12345"},<br/>
        ///     {"key": "source", "value": "customer_support"}<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>? Metadata { get; set; }

        /// <summary>
        /// Controls repetitiveness of model responses by penalizing frequent tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Reduce token repetition<br/>
        /// - Negative values: Encourage repetition<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.5 to significantly reduce repeated phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modify the likelihood of specific tokens appearing in the response. <br/>
        /// A dictionary where keys are token IDs and values are bias scores. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "logit_bias": {<br/>
        ///     "50256": -100,  # Reduce probability of end-of-text token<br/>
        ///     "15": 5  # Slightly increase probability of a specific token<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// If set to True, returns log probabilities of the most likely tokens. <br/>
        /// Useful for advanced token probability analysis. <br/>
        /// **Example**: True to get detailed token likelihood information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Number of top log probabilities to return with each token. <br/>
        /// Must be between 0 and 20. <br/>
        /// **Example**: 5 to get top 5 most likely tokens for each position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate in the completion. <br/>
        /// Must be at least 1. <br/>
        /// **Example**: 150 to limit response to approximately 100-150 words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Number of chat completion choices to generate.<br/>
        ///     **Example**: 3 to generate multiple alternative responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// List of supported input/output modalities for the chat. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "modalities": ["text", "image", "audio"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// Optional field for storing prediction-related information. <br/>
        /// Flexible dictionary to capture model's predictive metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "prediction": {<br/>
        ///     "confidence_score": 0.85,<br/>
        ///     "top_prediction": "response_category"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public object? Prediction { get; set; }

        /// <summary>
        /// Optional dictionary for audio-related parameters or metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "audio": {<br/>
        ///     "language": "en-US",<br/>
        ///     "transcription_format": "srt"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public object? Audio { get; set; }

        /// <summary>
        /// Adjusts likelihood of discussing new topics by penalizing existing tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Encourage more diverse topics<br/>
        /// - Negative values: Keep discussion more focused<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.0 to promote topic diversity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Specify the desired response format for the completion. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "response_format": {<br/>
        ///     "type": "json_object",<br/>
        ///     "schema": {...}<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public object? ResponseFormat { get; set; }

        /// <summary>
        /// Set a seed for deterministic sampling to reproduce consistent results. <br/>
        /// **Example**: 42 for a reproducible random generation process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Select the service tier for the API request. <br/>
        /// **Choices**:<br/>
        /// - 'auto': Automatically select appropriate tier<br/>
        /// - 'default': Use default service configuration<br/>
        /// * `auto` - auto<br/>
        /// * `default` - default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EdenAI.JsonConverters.ServiceTierEnumJsonConverter))]
        public global::EdenAI.ServiceTierEnum? ServiceTier { get; set; }

        /// <summary>
        /// List of strings that will cause the model to stop generating. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stop": ["\n", "Human:", "AI:"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// If True, returns tokens as they are generated in a streaming format. <br/>
        /// Default is False. <br/>
        /// **Example**: True for real-time token streaming<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional configuration for streaming responses. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stream_options": {<br/>
        ///     "include_usage": true<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public object? StreamOptions { get; set; }

        /// <summary>
        /// Controls randomness in token selection. <br/>
        /// Ranges from 0.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - 0.0: Most deterministic, focused responses<br/>
        /// - 1.0: Balanced randomness<br/>
        /// - 2.0: Most creative, unpredictable responses<br/>
        /// **Example**: 0.7 for a good balance of creativity and focus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling threshold for token selection. <br/>
        /// Ranges from 0.0 to 1.0. Default is 1.0. <br/>
        /// **Values**:<br/>
        /// - 1.0: Consider all tokens<br/>
        /// - Lower values: More focused, deterministic sampling<br/>
        /// **Example**: 0.9 to select from top 90% most probable tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// List of tools or function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "function",<br/>
        ///       "function": {<br/>
        ///         "name": "get_weather",<br/>
        ///         "description": "Retrieve current weather"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// Specify how tools should be used in the completion. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Model decides when to use tools<br/>
        /// - 'none': Disable tool usage<br/>
        /// - Specific tool name to always use a particular tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Allow the model to make multiple tool calls in parallel. <br/>
        /// **Example**: True to enable concurrent tool invocations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Optional identifier for the end-user to help track and monitor API usage. <br/>
        /// **Example**: 'user_123456'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Control how function calls are handled. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Default behavior<br/>
        /// - 'none': Disable function calls<br/>
        /// - Specific function name to force its execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public string? FunctionCall { get; set; }

        /// <summary>
        /// List of function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "functions": [<br/>
        ///     {<br/>
        ///       "name": "get_current_weather",<br/>
        ///       "description": "Get the current weather for a location",<br/>
        ///       "parameters": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        /// Configuration for enabling Claude's extended thinking. When enabled, responses include thinking content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your max_tokens limit.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   'thinking': {<br/>
        ///     'type': 'enabled'<br/>
        ///     'budget_tokens': '1024'  }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::EdenAI.ThinkingRequest? Thinking { get; set; }

        /// <summary>
        /// Options for web search integration. <br/>
        ///         **Example**:<br/>
        ///         ```json<br/>
        ///         web_search_options={<br/>
        ///             "search_context_size": "medium"  # Options: "low", "medium", "high"<br/>
        ///         }<br/>
        ///         ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_options")]
        public object? WebSearchOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatllmchatChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list containing all the conversations between the user and the assistant.<br/>
        /// Each item in the list should be a dictionary with two keys: 'role' and 'message'.<br/>
        /// **role**: Specifies the role of the speaker and can have the values 'user', 'system', 'assistant' or 'tool'.<br/>
        /// The system role instructs the way the model should answer, e.g. 'You are a helpful assistant'. The user<br/>
        /// role specifies the user query and assistant is the model's response. The tool role is for external tools that<br/>
        /// can be used in the conversation.<br/>
        /// **message**: A list of dictionaries. Each dictionary in the 'message' list must contain the keys 'type' and 'content'.<br/>
        /// #### Structure<br/>
        /// - **type**: Specifies the type of content and can be 'image_url' or 'text'.<br/>
        /// - **content**: A dictionary with the actual content based on the 'type':<br/>
        ///     - If 'type' is 'image_url', 'content' must contain 'image_url' and must not contain 'text'.<br/>
        ///     - If 'type' is 'text', 'content' must contain 'text' and must not contain 'image_url'.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": [<br/>
        ///         {<br/>
        ///           "type": "text",<br/>
        ///           "text": "Describe this image"<br/>
        ///         },<br/>
        ///         {<br/>
        ///         "type": "image_url",<br/>
        ///         "image_url": {<br/>
        ///           "url": "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg"<br/>
        ///           }<br/>
        ///         }<br/>
        ///     ]<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="model">
        /// The OpenAI model to use for the chat completion. <br/>
        /// This field is required and specifies which language model will process the conversation. <br/>
        /// **Example values**: 'gpt-3.5-turbo', 'gpt-4', 'gpt-4-turbo'
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
        /// <param name="metadata">
        /// Optional list of metadata associated with the chat request. <br/>
        /// Can be used to provide additional context or tracking information. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "metadata": [<br/>
        ///     {"key": "conversation_id", "value": "chat_12345"},<br/>
        ///     {"key": "source", "value": "customer_support"}<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="frequencyPenalty">
        /// Controls repetitiveness of model responses by penalizing frequent tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Reduce token repetition<br/>
        /// - Negative values: Encourage repetition<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.5 to significantly reduce repeated phrases
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specific tokens appearing in the response. <br/>
        /// A dictionary where keys are token IDs and values are bias scores. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "logit_bias": {<br/>
        ///     "50256": -100,  # Reduce probability of end-of-text token<br/>
        ///     "15": 5  # Slightly increase probability of a specific token<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="logprobs">
        /// If set to True, returns log probabilities of the most likely tokens. <br/>
        /// Useful for advanced token probability analysis. <br/>
        /// **Example**: True to get detailed token likelihood information
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return with each token. <br/>
        /// Must be between 0 and 20. <br/>
        /// **Example**: 5 to get top 5 most likely tokens for each position
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of tokens to generate in the completion. <br/>
        /// Must be at least 1. <br/>
        /// **Example**: 150 to limit response to approximately 100-150 words
        /// </param>
        /// <param name="n">
        /// Number of chat completion choices to generate.<br/>
        ///     **Example**: 3 to generate multiple alternative responses
        /// </param>
        /// <param name="modalities">
        /// List of supported input/output modalities for the chat. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "modalities": ["text", "image", "audio"]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="prediction">
        /// Optional field for storing prediction-related information. <br/>
        /// Flexible dictionary to capture model's predictive metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "prediction": {<br/>
        ///     "confidence_score": 0.85,<br/>
        ///     "top_prediction": "response_category"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="audio">
        /// Optional dictionary for audio-related parameters or metadata. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "audio": {<br/>
        ///     "language": "en-US",<br/>
        ///     "transcription_format": "srt"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="presencePenalty">
        /// Adjusts likelihood of discussing new topics by penalizing existing tokens. <br/>
        /// Ranges from -2.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - Positive values: Encourage more diverse topics<br/>
        /// - Negative values: Keep discussion more focused<br/>
        /// - 0.0: Default behavior<br/>
        /// **Example**: 1.0 to promote topic diversity
        /// </param>
        /// <param name="responseFormat">
        /// Specify the desired response format for the completion. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "response_format": {<br/>
        ///     "type": "json_object",<br/>
        ///     "schema": {...}<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="seed">
        /// Set a seed for deterministic sampling to reproduce consistent results. <br/>
        /// **Example**: 42 for a reproducible random generation process
        /// </param>
        /// <param name="serviceTier">
        /// Select the service tier for the API request. <br/>
        /// **Choices**:<br/>
        /// - 'auto': Automatically select appropriate tier<br/>
        /// - 'default': Use default service configuration<br/>
        /// * `auto` - auto<br/>
        /// * `default` - default
        /// </param>
        /// <param name="stop">
        /// List of strings that will cause the model to stop generating. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stop": ["\n", "Human:", "AI:"]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="stream">
        /// If True, returns tokens as they are generated in a streaming format. <br/>
        /// Default is False. <br/>
        /// **Example**: True for real-time token streaming<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Additional configuration for streaming responses. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "stream_options": {<br/>
        ///     "include_usage": true<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in token selection. <br/>
        /// Ranges from 0.0 to 2.0. <br/>
        /// **Values**:<br/>
        /// - 0.0: Most deterministic, focused responses<br/>
        /// - 1.0: Balanced randomness<br/>
        /// - 2.0: Most creative, unpredictable responses<br/>
        /// **Example**: 0.7 for a good balance of creativity and focus
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling threshold for token selection. <br/>
        /// Ranges from 0.0 to 1.0. Default is 1.0. <br/>
        /// **Values**:<br/>
        /// - 1.0: Consider all tokens<br/>
        /// - Lower values: More focused, deterministic sampling<br/>
        /// **Example**: 0.9 to select from top 90% most probable tokens
        /// </param>
        /// <param name="tools">
        /// List of tools or function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "function",<br/>
        ///       "function": {<br/>
        ///         "name": "get_weather",<br/>
        ///         "description": "Retrieve current weather"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="toolChoice">
        /// Specify how tools should be used in the completion. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Model decides when to use tools<br/>
        /// - 'none': Disable tool usage<br/>
        /// - Specific tool name to always use a particular tool
        /// </param>
        /// <param name="parallelToolCalls">
        /// Allow the model to make multiple tool calls in parallel. <br/>
        /// **Example**: True to enable concurrent tool invocations
        /// </param>
        /// <param name="user">
        /// Optional identifier for the end-user to help track and monitor API usage. <br/>
        /// **Example**: 'user_123456'
        /// </param>
        /// <param name="functionCall">
        /// Control how function calls are handled. <br/>
        /// **Example values**:<br/>
        /// - 'auto': Default behavior<br/>
        /// - 'none': Disable function calls<br/>
        /// - Specific function name to force its execution
        /// </param>
        /// <param name="functions">
        /// List of function definitions available to the model. <br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "functions": [<br/>
        ///     {<br/>
        ///       "name": "get_current_weather",<br/>
        ///       "description": "Get the current weather for a location",<br/>
        ///       "parameters": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="thinking">
        /// Configuration for enabling Claude's extended thinking. When enabled, responses include thinking content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your max_tokens limit.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   'thinking': {<br/>
        ///     'type': 'enabled'<br/>
        ///     'budget_tokens': '1024'  }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="webSearchOptions">
        /// Options for web search integration. <br/>
        ///         **Example**:<br/>
        ///         ```json<br/>
        ///         web_search_options={<br/>
        ///             "search_context_size": "medium"  # Options: "low", "medium", "high"<br/>
        ///         }<br/>
        ///         ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmchatllmchatChatRequest(
            global::System.Collections.Generic.IList<object> messages,
            string model,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort,
            global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>? metadata,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            int? topLogprobs,
            int? maxCompletionTokens,
            int? n,
            global::System.Collections.Generic.IList<string>? modalities,
            object? prediction,
            object? audio,
            double? presencePenalty,
            object? responseFormat,
            int? seed,
            global::EdenAI.ServiceTierEnum? serviceTier,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            object? streamOptions,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<object>? tools,
            string? toolChoice,
            bool? parallelToolCalls,
            string? user,
            string? functionCall,
            global::System.Collections.Generic.IList<object>? functions,
            global::EdenAI.ThinkingRequest? thinking,
            object? webSearchOptions)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ReasoningEffort = reasoningEffort;
            this.Metadata = metadata;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.N = n;
            this.Modalities = modalities;
            this.Prediction = prediction;
            this.Audio = audio;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.User = user;
            this.FunctionCall = functionCall;
            this.Functions = functions;
            this.Thinking = thinking;
            this.WebSearchOptions = webSearchOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmchatllmchatChatRequest" /> class.
        /// </summary>
        public LlmchatllmchatChatRequest()
        {
        }
    }
}