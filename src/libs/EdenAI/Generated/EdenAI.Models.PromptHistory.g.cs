
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptHistory
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int Version { get; set; } = default!;

        /// <summary>
        /// The text used for the prompt<br/>
        /// You can include prompt variables with {{ my_variable }}. These variables are injected when you later call your prompt.<br/>
        /// The template language is compatible with jinja2<br/>
        /// #### Example<br/>
        /// ```bash<br/>
        /// Translate this word to {{ language }}: {{ word }}<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The model used to call the prompt. E.g. openai/gpt-4o
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_urls")]
        public global::System.Collections.Generic.IList<string>? FileUrls { get; set; }

        /// <summary>
        /// Specify a system prompt for the LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptHistory" /> class.
        /// </summary>
        /// <param name="text">
        /// The text used for the prompt<br/>
        /// You can include prompt variables with {{ my_variable }}. These variables are injected when you later call your prompt.<br/>
        /// The template language is compatible with jinja2<br/>
        /// #### Example<br/>
        /// ```bash<br/>
        /// Translate this word to {{ language }}: {{ word }}<br/>
        /// ```
        /// </param>
        /// <param name="model">
        /// The model used to call the prompt. E.g. openai/gpt-4o
        /// </param>
        /// <param name="params">
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="fileUrls">
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models.
        /// </param>
        /// <param name="systemPrompt">
        /// Specify a system prompt for the LLM
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="version">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptHistory(
            string? text,
            string? model,
            object? @params,
            global::System.Collections.Generic.IList<string>? fileUrls,
            string? systemPrompt,
            int id = default!,
            int version = default!,
            string name = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Id = id;
            this.Version = version;
            this.Text = text;
            this.Model = model;
            this.Name = name;
            this.Params = @params;
            this.FileUrls = fileUrls;
            this.SystemPrompt = systemPrompt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptHistory" /> class.
        /// </summary>
        public PromptHistory()
        {
        }

    }
}