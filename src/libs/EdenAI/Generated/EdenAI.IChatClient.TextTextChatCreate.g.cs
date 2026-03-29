#nullable enable

namespace EdenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|**o3-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v1Beta`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v1Beta`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v1Beta`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v1Beta`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v1Beta`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v1Beta`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v1Beta`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v1Beta`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v1Beta`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v1Beta`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v1Beta`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v1Beta`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**gemini-1.5-flash-8b-latest**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
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
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
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
        /// |**cohere**|-|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-light**|`2022-12-06`|0.6 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-nightly**|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command**|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-light-nightly**|`2022-12-06`|0.6 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r**|`2022-12-06`|1.5 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r7b-12-2024**|`2022-12-06`|0.15 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-405b-instruct-v1:0**|`boto3 (v1.35.84)`|2.4 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-70b-instruct-v1:0**|`boto3 (v1.35.84)`|0.72 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-8b-instruct-v1:0**|`boto3 (v1.35.84)`|0.22 (per 1000000 token)|1 token<br/>
        /// |**meta**|-|`boto3 (v1.35.84)`|0.15 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-saba-latest**|`v0.0.1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral-small-latest**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-latest**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-latest**|`v0.0.1`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2405**|`v0.0.1`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2508**|`v0.0.1`|9e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-mamba-latest**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-medium-2507**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2505**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2507**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**labs-devstral-small-2512**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-2512**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2506**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2509**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-latest**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-2506**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-latest**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2402**|`v0.0.1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2407**|`v0.0.1`|9e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2411**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-3**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium**|`v0.0.1`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2312**|`v0.0.1`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2505**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-latest**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-tiny**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-codestral-mamba**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-7b**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo-2407**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x22b**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x7b**|`v0.0.1`|7e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-12b-2409**|`v0.0.1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-2411**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|-|`v1.0`|2.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`v1.0`|30.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`v1.0`|2.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022-v1:0**|`bedrock-2023-05-31`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20240620-v1:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20241022-v2:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20240620-v1:0**|`bedrock-2023-05-31`|1.8e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307-v1:0**|`bedrock-2023-05-31`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-20240229-v1:0**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-sonnet-20240229-v1:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-instant-v1**|`bedrock-2023-05-31`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-v1**|`bedrock-2023-05-31`|2.4e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-v2:1**|`bedrock-2023-05-31`|2.4e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022**|`bedrock-2023-05-31`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5-20251001**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20240620**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20241022**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-latest**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-latest**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307**|`bedrock-2023-05-31`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-20240229**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-latest**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-opus-20250514**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-sonnet-20250514**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5-20250929**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1-20250805**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-20250514**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5-20251101**|`bedrock-2023-05-31`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5**|`bedrock-2023-05-31`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-20250514**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|1e-05 (per 1 token)|1 token<br/>
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
        /// |**deepseek**|**deepseek-v3**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|-|`v1`|1.25 (per 1000000 token)|1 token<br/>
        /// |**deepseek**|**deepseek-reasoner**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-chat**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-coder**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-r1**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-v3.2**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-lite-v1:0**|`boto3 (v1.29.6)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-micro-v1:0**|`boto3 (v1.29.6)`|0.14 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|-|`v1`|1.2 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-21.1b-41b**|`v1`|8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-4.1b-8b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-41.1b-80b**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-8.1b-21b**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-81.1b-110b**|`v1`|1.8e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-up-to-4b**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-7B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Instruct-2507-tput**|`v1`|6e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-fp8-tput**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-FP8**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1**|`v1`|7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1-0528-tput**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3**|`v1`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3.1**|`v1`|1.7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.2-3B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo-Free**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`v1`|8.5e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`v1`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`v1`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mistral-7B-Instruct-v0.1**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**mistralai/Mistral-Small-24B-Instruct-2501**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-120b**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-20b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**togethercomputer/CodeLlama-34b-Instruct**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**zai-org/GLM-4.5-Air-FP8**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.6**|`v1`|2.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Thinking**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// |**groq**|**llama3-70b-8192**|`v1`|0.59 (per 1000000 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**gemma-7b-it**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-guard-4-12b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-maverick-17b-128e-instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-scout-17b-16e-instruct**|`v1`|3.4e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**moonshotai/kimi-k2-instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-120b**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-20b**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**qwen/qwen3-32b**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// |**cohere**|`command`|<br/>
        /// |**meta**|`llama3-1-8b-instruct-v1:0`|<br/>
        /// |**mistral**|`mistral-large-latest`|<br/>
        /// |**perplexityai**|`sonar`|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// |**deepseek**|`deepseek-chat`|<br/>
        /// |**amazon**|`amazon.nova-lite-v1:0`|<br/>
        /// |**together_ai**|`Qwen/Qwen2.5-72B-Instruct-Turbo`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// |**groq**|`llama3-70b-8192`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextchatResponseModel> TextTextChatCreateAsync(

            global::EdenAI.TextchatChatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**openai**|**o3-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|-|`v1Beta`|10.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o1-preview**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`v1Beta`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v1Beta`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v1Beta`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`v1Beta`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0301**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0613**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`v1Beta`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k-0613**|`v1Beta`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-vision-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0314**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-32k-0613**|`v1Beta`|0.00012 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-vision-preview**|`v1Beta`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`v1Beta`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`v1Beta`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview**|`v1Beta`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.5-preview-2025-02-27**|`v1Beta`|0.00015 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-10-01**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2024-12-17**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-audio-preview-2025-06-03**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-audio-preview-2024-12-17**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-realtime-preview-2024-12-17**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`v1Beta`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-10-01**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2024-12-17**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-realtime-preview-2025-06-03**|`v1Beta`|2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`v1Beta`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat**|`v1Beta`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`v1Beta`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`v1Beta`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime**|`v1Beta`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-mini**|`v1Beta`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-realtime-2025-08-28**|`v1Beta`|1.6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-mini-2024-09-12**|`v1Beta`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-preview-2024-09-12**|`v1Beta`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`v1Beta`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`v1Beta`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**container**|`v1Beta`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**google**|**gemini-1.5-flash-8b-latest**|`v1`|0.3 (per 1000000 token)|1 token<br/>
        /// |**google**|-|`v1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`v1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite-preview-02-05**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-preview-03-25**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro-exp-03-25**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b-exp-0924**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-001**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-002**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0801**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-exp-0827**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-exp**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`v1`|3e-07 (per 1 token)|1 token<br/>
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
        /// |**google**|**gemini-2.5-computer-use-preview-10-2025**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`v1`|3e-06 (per 1 token)|1 token<br/>
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
        /// |**cohere**|-|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-light**|`2022-12-06`|0.6 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-nightly**|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command**|`2022-12-06`|2.0 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-light-nightly**|`2022-12-06`|0.6 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r**|`2022-12-06`|1.5 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r7b-12-2024**|`2022-12-06`|0.15 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-405b-instruct-v1:0**|`boto3 (v1.35.84)`|2.4 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-70b-instruct-v1:0**|`boto3 (v1.35.84)`|0.72 (per 1000000 token)|1 token<br/>
        /// |**meta**|**llama3-1-8b-instruct-v1:0**|`boto3 (v1.35.84)`|0.22 (per 1000000 token)|1 token<br/>
        /// |**meta**|-|`boto3 (v1.35.84)`|0.15 (per 1000000 token)|1 token<br/>
        /// |**mistral**|-|`v0.0.1`|6.0 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-saba-latest**|`v0.0.1`|0.6 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**mistral-small-latest**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-latest**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-latest**|`v0.0.1`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2405**|`v0.0.1`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2508**|`v0.0.1`|9e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-mamba-latest**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-medium-2507**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2505**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2507**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**labs-devstral-small-2512**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-2512**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2506**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2509**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-latest**|`v0.0.1`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-2506**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-latest**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2402**|`v0.0.1`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2407**|`v0.0.1`|9e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2411**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-3**|`v0.0.1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium**|`v0.0.1`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2312**|`v0.0.1`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2505**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-latest**|`v0.0.1`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-tiny**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-codestral-mamba**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-7b**|`v0.0.1`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo-2407**|`v0.0.1`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x22b**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x7b**|`v0.0.1`|7e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-12b-2409**|`v0.0.1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-2411**|`v0.0.1`|6e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|-|`v1.0`|2.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`v1.0`|30.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`v1.0`|2.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|-|`bedrock-2023-05-31`|15.0 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022-v1:0**|`bedrock-2023-05-31`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20240620-v1:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20241022-v2:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20240620-v1:0**|`bedrock-2023-05-31`|1.8e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307-v1:0**|`bedrock-2023-05-31`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-20240229-v1:0**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-sonnet-20240229-v1:0**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-instant-v1**|`bedrock-2023-05-31`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-v1**|`bedrock-2023-05-31`|2.4e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-v2:1**|`bedrock-2023-05-31`|2.4e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022**|`bedrock-2023-05-31`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5-20251001**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5**|`bedrock-2023-05-31`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20240620**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-20241022**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-sonnet-latest**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-latest**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307**|`bedrock-2023-05-31`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-20240229**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-opus-latest**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-opus-20250514**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-sonnet-20250514**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5-20250929**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1-20250805**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-20250514**|`bedrock-2023-05-31`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5-20251101**|`bedrock-2023-05-31`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5**|`bedrock-2023-05-31`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-20250514**|`bedrock-2023-05-31`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|-|`v1`|10.0 (per 1000000 token)|1 token<br/>
        /// |**xai**|**grok-2-latest**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-1212**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`v1`|1e-05 (per 1 token)|1 token<br/>
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
        /// |**deepseek**|**deepseek-v3**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|-|`v1`|1.25 (per 1000000 token)|1 token<br/>
        /// |**deepseek**|**deepseek-reasoner**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-chat**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-coder**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-r1**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-v3.2**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**amazon**|-|`boto3 (v1.29.6)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-lite-v1:0**|`boto3 (v1.29.6)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`boto3 (v1.29.6)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-micro-v1:0**|`boto3 (v1.29.6)`|0.14 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|-|`v1`|1.2 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-21.1b-41b**|`v1`|8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-4.1b-8b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-41.1b-80b**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-8.1b-21b**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-81.1b-110b**|`v1`|1.8e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**together-ai-up-to-4b**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-7B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Instruct-2507-tput**|`v1`|6e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-fp8-tput**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-FP8**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1**|`v1`|7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1-0528-tput**|`v1`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3**|`v1`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3.1**|`v1`|1.7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.2-3B-Instruct-Turbo**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo-Free**|`v1`|0.0 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`v1`|8.5e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`v1`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`v1`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mistral-7B-Instruct-v0.1**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**mistralai/Mistral-Small-24B-Instruct-2501**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-120b**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-20b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**togethercomputer/CodeLlama-34b-Instruct**|`v1`|0.0 (per 1 seconde)|1 seconde<br/>
        /// |**together_ai**|**zai-org/GLM-4.5-Air-FP8**|`v1`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.6**|`v1`|2.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Thinking**|`v1`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|15.0 (per 1000000 token)|1 token<br/>
        /// |**groq**|**llama3-70b-8192**|`v1`|0.59 (per 1000000 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**gemma-7b-it**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-guard-4-12b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-maverick-17b-128e-instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-scout-17b-16e-instruct**|`v1`|3.4e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**moonshotai/kimi-k2-instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-120b**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-20b**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**qwen/qwen3-32b**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// |**cohere**|`command`|<br/>
        /// |**meta**|`llama3-1-8b-instruct-v1:0`|<br/>
        /// |**mistral**|`mistral-large-latest`|<br/>
        /// |**perplexityai**|`sonar`|<br/>
        /// |**anthropic**|`claude-3-5-sonnet-latest`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// |**deepseek**|`deepseek-chat`|<br/>
        /// |**amazon**|`amazon.nova-lite-v1:0`|<br/>
        /// |**together_ai**|`Qwen/Qwen2.5-72B-Instruct-Turbo`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// |**groq**|`llama3-70b-8192`|<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EdenAI.TextchatResponseModel> TextTextChatCreateAsync(
            global::System.Collections.Generic.IList<string> providers,
            string? settings = default,
            global::System.Collections.Generic.IList<string>? fallbackProviders = default,
            bool? responseAsDict = default,
            bool? attributesAsList = default,
            bool? showBase64 = default,
            bool? showOriginalResponse = default,
            string? text = default,
            string? chatbotGlobalAction = default,
            global::System.Collections.Generic.IList<global::EdenAI.ChatMessageRequest>? previousHistory = default,
            double? temperature = default,
            int? maxTokens = default,
            global::EdenAI.ToolChoiceEnum? toolChoice = default,
            global::System.Collections.Generic.IList<global::EdenAI.ChatAvailableToolsRequest>? availableTools = default,
            global::System.Collections.Generic.IList<global::EdenAI.ChatToolResultRequest>? toolResults = default,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}