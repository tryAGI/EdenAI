
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCreateRequest
    {
        /// <summary>
        /// The unique identifier for the prompt. Must contain only alphanumeric characters, underscores (_) and hyphens (-). No spaces allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The text used for the prompt<br/>
        /// You can include prompt variables with {{ my_variable }}. These variables are injected when you later call your prompt.<br/>
        /// The template language is compatible with jinja2<br/>
        /// #### Example<br/>
        /// ```bash<br/>
        /// Translate this word to {{ language }}: {{ word }}<br/>
        /// ```<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The model used to call the prompt. E.g. openai/gpt-4o<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_urls")]
        public global::System.Collections.Generic.IList<string>? FileUrls { get; set; }

        /// <summary>
        /// Specify a system prompt for the LLM<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique identifier for the prompt. Must contain only alphanumeric characters, underscores (_) and hyphens (-). No spaces allowed.
        /// </param>
        /// <param name="text">
        /// The text used for the prompt<br/>
        /// You can include prompt variables with {{ my_variable }}. These variables are injected when you later call your prompt.<br/>
        /// The template language is compatible with jinja2<br/>
        /// #### Example<br/>
        /// ```bash<br/>
        /// Translate this word to {{ language }}: {{ word }}<br/>
        /// ```<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// The model used to call the prompt. E.g. openai/gpt-4o<br/>
        /// Included only in requests
        /// </param>
        /// <param name="params">
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```<br/>
        /// Included only in requests
        /// </param>
        /// <param name="fileUrls">
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="systemPrompt">
        /// Specify a system prompt for the LLM<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCreateRequest(
            string name,
            string? text,
            string? model,
            object? @params,
            global::System.Collections.Generic.IList<string>? fileUrls,
            string? systemPrompt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Text = text;
            this.Model = model;
            this.Params = @params;
            this.FileUrls = fileUrls;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCreateRequest" /> class.
        /// </summary>
        public PromptCreateRequest()
        {
        }

    }
}