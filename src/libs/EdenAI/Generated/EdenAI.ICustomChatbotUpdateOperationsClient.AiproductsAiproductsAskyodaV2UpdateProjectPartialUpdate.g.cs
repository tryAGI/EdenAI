#nullable enable

namespace EdenAI
{
    public partial interface ICustomChatbotUpdateOperationsClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Update the default settings of the Yoda project.<br/>
        /// It allows you to modify the project's default settings,<br/>
        /// specifically changing the llm_provider (language model provider),<br/>
        /// llm_model (language model), ocr_provider (upload pdf), speech_to_text provider (upload audio)<br/>
        /// and the default chunks parameter associated with the default project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AskYodaProjectUpdate> AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync(
            global::System.Guid projectId,

            global::EdenAI.PatchedAskYodaProjectUpdateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update the default settings of the Yoda project.<br/>
        /// It allows you to modify the project's default settings,<br/>
        /// specifically changing the llm_provider (language model provider),<br/>
        /// llm_model (language model), ocr_provider (upload pdf), speech_to_text provider (upload audio)<br/>
        /// and the default chunks parameter associated with the default project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.AskYodaProjectUpdate>> AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsResponseAsync(
            global::System.Guid projectId,

            global::EdenAI.PatchedAskYodaProjectUpdateRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update the default settings of the Yoda project.<br/>
        /// It allows you to modify the project's default settings,<br/>
        /// specifically changing the llm_provider (language model provider),<br/>
        /// llm_model (language model), ocr_provider (upload pdf), speech_to_text provider (upload audio)<br/>
        /// and the default chunks parameter associated with the default project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ocrProvider">
        /// Default Value: amazon
        /// </param>
        /// <param name="speechToTextProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="llmProvider">
        /// Select a default LLM provider to use in your project.
        /// </param>
        /// <param name="llmModel">
        /// Select a default Model for LLM provider to use in your project
        /// </param>
        /// <param name="chunkSize"></param>
        /// <param name="chunkSeparators"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AskYodaProjectUpdate> AiproductsAiproductsAskyodaV2UpdateProjectPartialUpdateAsync(
            global::System.Guid projectId,
            string? ocrProvider = default,
            string? speechToTextProvider = default,
            string? llmProvider = default,
            string? llmModel = default,
            int? chunkSize = default,
            global::System.Collections.Generic.IList<string>? chunkSeparators = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}