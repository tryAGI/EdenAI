#nullable enable

namespace EdenAI
{
    public partial interface IKeywordExtractionClient
    {
        /// <summary>
        /// Keyword Extraction<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|-|`v3.1`|1.0 (per 1000000 char)|1000 char<br/>
        /// |**openai**|-|`v3.0.0`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v3.0.0`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v3.0.0`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**tenstorrent**|-|`v1.0.0`|0.7 (per 1000000 char)|1000 char<br/>
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
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-keyword_extraction' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextkeywordExtractionResponseModel> TextTextKeywordExtractionCreateAsync(

            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Keyword Extraction<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|-|`v3.1`|1.0 (per 1000000 char)|1000 char<br/>
        /// |**openai**|-|`v3.0.0`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v3.0.0`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v3.0.0`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**tenstorrent**|-|`v1.0.0`|0.7 (per 1000000 char)|1000 char<br/>
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
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-keyword_extraction' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.AutoSDKHttpResponse<global::EdenAI.TextkeywordExtractionResponseModel>> TextTextKeywordExtractionCreateAsResponseAsync(

            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Keyword Extraction<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**microsoft**|-|`v3.1`|1.0 (per 1000000 char)|1000 char<br/>
        /// |**openai**|-|`v3.0.0`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v3.0.0`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v3.0.0`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v3.0.0`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v3.0.0`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v3.0.0`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v3.0.0`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v3.0.0`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v3.0.0`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v3.0.0`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v3.0.0`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v3.0.0`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v3.0.0`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v3.0.0`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v3.0.0`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**tenstorrent**|-|`v1.0.0`|0.7 (per 1000000 char)|1000 char<br/>
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
        /// &lt;details&gt;&lt;summary&gt;Supported Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Afrikaans**|`af`|<br/>
        /// |**Arabic**|`ar`|<br/>
        /// |**Bulgarian**|`bg`|<br/>
        /// |**Catalan**|`ca`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Croatian**|`hr`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Estonian**|`et`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Hungarian**|`hu`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Latvian**|`lv`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Norwegian Bokmål**|`nb`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Romanian**|`ro`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Slovak**|`sk`|<br/>
        /// |**Slovenian**|`sl`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-keyword_extraction' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
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
        /// <param name="text">
        /// Text to analyze
        /// </param>
        /// <param name="language">
        /// Language code for the language the input text is written in (eg: en, fr).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextkeywordExtractionResponseModel> TextTextKeywordExtractionCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string text,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? language = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}