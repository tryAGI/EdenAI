
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCallRequest
    {
        /// <summary>
        /// Optional model override (e.g., 'openai/gpt-4o'). If not provided, the model specified in the prompt will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Variables to inject into the prompt template.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "my_variable": "some_value",<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_context")]
        public object? PromptContext { get; set; }

        /// <summary>
        /// Optional params override. If not provided, the default params in the prompt will be used<br/>
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models. Overrides the file urls set on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_urls")]
        public global::System.Collections.Generic.IList<string>? FileUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Optional model override (e.g., 'openai/gpt-4o'). If not provided, the model specified in the prompt will be used.
        /// </param>
        /// <param name="promptContext">
        /// Variables to inject into the prompt template.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "my_variable": "some_value",<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="params">
        /// Optional params override. If not provided, the default params in the prompt will be used<br/>
        /// Params that are passed on to the llm request. See llm chat docs for more details.<br/>
        /// #### Example<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "temperature": 0.7,<br/>
        ///   "max_tokens": 100<br/>
        /// }<br/>
        /// ```<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="fileUrls">
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models. Overrides the file urls set on the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCallRequest(
            string? model,
            object? promptContext,
            object? @params,
            global::System.Collections.Generic.IList<string>? fileUrls)
        {
            this.Model = model;
            this.PromptContext = promptContext;
            this.Params = @params;
            this.FileUrls = fileUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallRequest" /> class.
        /// </summary>
        public PromptCallRequest()
        {
        }

    }
}