#nullable enable

namespace EdenAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Call prompt<br/>
        /// Call prompt with your variables in prompt_context. You can override params saved in the prompt and specifiy file urls
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsCreate2Async(
            string name,

            global::EdenAI.PromptCallRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call prompt<br/>
        /// Call prompt with your variables in prompt_context. You can override params saved in the prompt and specifiy file urls
        /// </summary>
        /// <param name="name"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsCreate2Async(
            string name,
            string? model = default,
            object? promptContext = default,
            object? @params = default,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}