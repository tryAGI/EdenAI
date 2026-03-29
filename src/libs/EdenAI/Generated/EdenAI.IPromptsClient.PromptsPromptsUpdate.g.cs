#nullable enable

namespace EdenAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update Prompt
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsUpdateAsync(
            string name,

            global::EdenAI.PromptUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Prompt
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestName">
        /// The unique identifier for the prompt. Must contain only alphanumeric characters, underscores (_) and hyphens (-). No spaces allowed.
        /// </param>
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
        /// <param name="currentVersion">
        /// The production version of the prompt, that is used by default when you call the prompt
        /// </param>
        /// <param name="fileUrls">
        /// Optional list of URLs to images or other files that should be included with the prompt for multimodal models. Files are not supported by all models.
        /// </param>
        /// <param name="systemPrompt">
        /// Specify a system prompt for the LLM
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.PromptUpdate> PromptsPromptsUpdateAsync(
            string name,
            string? requestName = default,
            string? text = default,
            string? model = default,
            object? @params = default,
            int? currentVersion = default,
            global::System.Collections.Generic.IList<string>? fileUrls = default,
            string? systemPrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}