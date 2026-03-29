#nullable enable

namespace EdenAI
{
    public partial interface ICodeGenerationClient
    {
        /// <summary>
        /// Code Generation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v1`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v1`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v1`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v1`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-latest**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-live-001**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-preview-image-generation**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp-01-21**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-pro-exp-02-05**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-06-17**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-04-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-05-20**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-tts**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-05-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-06-05**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-tts**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1114**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1206**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-27b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-9b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro-vision**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**learnlm-1.5-pro-experimental**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-beta**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-latest**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-beta**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-beta**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-latest**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-non-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1-0825**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-vision-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-code_generation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**google**|`gemini-1.5-flash`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextcodeGenerationResponseModel> TextTextCodeGenerationCreateAsync(

            global::EdenAI.TextcodeGenerationCodeGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Code Generation<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v1`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v1`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v1`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v1`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v1`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v1`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v1`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v1`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v1`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v1`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v1`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-latest**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-live-001**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-preview-image-generation**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-thinking-exp-01-21**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-pro-exp-02-05**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-06-17**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-04-17**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-05-20**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-tts**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-05-06**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-06-05**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-tts**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1114**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-exp-1206**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-27b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-gemma-2-9b-it**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-pro-vision**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**learnlm-1.5-pro-experimental**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-beta**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-latest**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-beta**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-beta**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-latest**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-non-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning-latest**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1-0825**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-vision-beta**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=text-code_generation' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**google**|`gemini-1.5-flash`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
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
        /// <param name="prompt">
        /// Entrer the source code that will be used as a context.
        /// </param>
        /// <param name="instruction">
        /// Entrer the instruction you want to be followed.
        /// </param>
        /// <param name="temperature">
        /// Higher values mean the model will take more risks and value 0 (argmax sampling) works better for scenarios with a well-defined answer.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus max_tokens cannot exceed the model's context length.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextcodeGenerationResponseModel> TextTextCodeGenerationCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string instruction,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? prompt = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}