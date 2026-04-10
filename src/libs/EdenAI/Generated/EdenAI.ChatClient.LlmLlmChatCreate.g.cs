
#nullable enable

namespace EdenAI
{
    public partial class ChatClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_LlmLlmChatCreateSecurityRequirement0 =
            new global::EdenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::EdenAI.EndPointAuthorizationRequirement[]
                {                    new global::EdenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "FeatureApiAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_LlmLlmChatCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_LlmLlmChatCreateSecurityRequirement0,
            };
        partial void PrepareLlmLlmChatCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.LlmchatllmchatChatRequest request);
        partial void PrepareLlmLlmChatCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.LlmchatllmchatChatRequest request);
        partial void ProcessLlmLlmChatCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLlmLlmChatCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-lite-v1:0**|`llmengine (v2)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-micro-v1:0**|`llmengine (v2)`|0.14 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`llmengine (v2)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-6**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-20250514**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1-20250805**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5-20251001**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307**|`v1`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-opus-20250514**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-sonnet-20250514**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5-20250929**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-20250514**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5-20251101**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**cohere**|**command-r7b-12-2024**|`llmengine (v2)`|0.15 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r-08-2024**|`llmengine (v2)`|0.6 (per 1000000 token)|1 token<br/>
        /// |**deepseek**|**deepseek-chat**|`llmengine (v2)`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-reasoner**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-coder**|`llmengine (v2)`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-405b-instruct-v1:0**|`llmengine (v2)`|2.4 (per 1000000 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-70b-instruct-v1:0**|`llmengine (v2)`|0.72 (per 1000000 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-8b-instruct-v1:0**|`llmengine (v2)`|0.22 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2506**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-2506**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-latest**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small-latest**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-latest**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-latest**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2405**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2508**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-medium-2507**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2505**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2507**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**labs-devstral-small-2512**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-2512**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2509**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-latest**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-latest**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2402**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2407**|`llmengine (v2)`|9e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2411**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium**|`llmengine (v2)`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2312**|`llmengine (v2)`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2505**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-tiny**|`llmengine (v2)`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-7b**|`llmengine (v2)`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo-2407**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x22b**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x7b**|`llmengine (v2)`|7e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-12b-2409**|`llmengine (v2)`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-2411**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`llmengine (v2)`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-pro**|`llmengine (v2)`|100.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`llmengine (v2)`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`llmengine (v2)`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`llmengine (v2)`|1.2 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-fp8-tput**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-FP8**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1**|`llmengine (v2)`|7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1-0528-tput**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3**|`llmengine (v2)`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3.1**|`llmengine (v2)`|1.7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`llmengine (v2)`|8.5e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`llmengine (v2)`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`llmengine (v2)`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`llmengine (v2)`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-20b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.5-Air-FP8**|`llmengine (v2)`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.6**|`llmengine (v2)`|2.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct-0905**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Thinking**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Instruct-2507-tput**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`llmengine (v2)`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-beta**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-beta**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-latest**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-beta**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-beta**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-latest**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-non-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1-0825**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-image-preview**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-image-preview**|`llmengine (v2)`|12.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`llmengine (v2)`|0.0 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-120b**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-guard-4-12b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-maverick-17b-128e-instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-scout-17b-16e-instruct**|`v1`|3.4e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**moonshotai/kimi-k2-instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-20b**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**qwen/qwen3-32b**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|5.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**o3-mini**|`Azure AI Foundry`|4.4 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**o1-mini**|`Azure AI Foundry`|12.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o-mini**|`Azure AI Foundry`|0.66 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4**|`Azure AI Foundry`|60.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-35-turbo-16k**|`Azure AI Foundry`|4.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-35-turbo**|`Azure AI Foundry`|1.5 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**minimax-m1**|`v1`|2.2 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**minimax-text-01**|`v1`|1.1 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2.1**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2.1-lightning**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**bytedance**|**seed-1-6-250915**|`llmengine (v2)`|2.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`llmengine (v2)`|1.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`llmengine (v2)`|1e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-deep-research**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-reasoning-pro**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Gryphe/MythoMax-L2-13b**|`v1`|9e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**NousResearch/Hermes-3-Llama-3.1-405B**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**NousResearch/Hermes-3-Llama-3.1-70B**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/QwQ-32B**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-72B-Instruct**|`v1`|3.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-7B-Instruct**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-VL-32B-Instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-14B**|`v1`|2.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B**|`v1`|5.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B-Instruct-2507**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`v1`|2.9e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-30B-A3B**|`v1`|2.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-32B**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Coder-480B-A35B-Instruct**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-Turbo**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`v1`|1.4e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3-8B-Lunaris-v1-Turbo**|`v1`|5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3.1-70B-Euryale-v2.2**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3.3-70B-Euryale-v2.3**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-3-7-sonnet-latest**|`v1`|1.65e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-4-opus**|`v1`|8.25e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-4-sonnet**|`v1`|1.65e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/Llama-3.3-Nemotron-Super-49B-v1.5**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-0528**|`v1`|2.15e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Distill-Llama-70B**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Distill-Qwen-32B**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Turbo**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3**|`v1`|8.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3-0324**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3.1**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3.1-Terminus**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-12b-it**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-27b-it**|`v1`|1.6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-4b-it**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.2-11B-Vision-Instruct**|`v1`|4.9e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.2-3B-Instruct**|`v1`|2e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.3-70B-Instruct**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`v1`|3.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-Guard-3-8B**|`v1`|5.5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-Guard-4-12B**|`v1`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-8B-Instruct**|`v1`|6e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-70B-Instruct**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-8B-Instruct**|`v1`|5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`v1`|3e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**microsoft/WizardLM-2-8x22B**|`v1`|4.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**microsoft/phi-4**|`v1`|1.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Nemo-Instruct-2407**|`v1`|4e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Small-24B-Instruct-2501**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Small-3.2-24B-Instruct-2506**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**moonshotai/Kimi-K2-Instruct**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**moonshotai/Kimi-K2-Instruct-0905**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/Llama-3.1-Nemotron-70B-Instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/NVIDIA-Nemotron-Nano-9B-v2**|`v1`|1.6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openai/gpt-oss-120b**|`v1`|4.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openai/gpt-oss-20b**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**zai-org/GLM-4.5**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**lizpreciatior/lzlv_70b_fp16_hf**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Gryphe/MythoMax-L2-13b**|`v1`|2.2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-7B-Instruct-v0.1**|`v1`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-2-70b-chat-hf**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**cognitivecomputations/dolphin-2.6-mixtral-8x7b**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Phind/Phind-CodeLlama-34B-v2**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-2-13b-chat-hf**|`v1`|2.2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-8B-Instruct**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-70B-Instruct**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-405B-Instruct**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openchat/openchat_3.5**|`v1`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-0528-Turbo**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**cerebras**|**llama3.1-8b**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**cerebras**|**gpt-oss-120b**|`llmengine (v2)`|6.9e-07 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/meta/llama-2-7b-chat-fp16**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/meta/llama-2-7b-chat-int8**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/mistral/mistral-7b-instruct-v0.1**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@hf/thebloke/codellama-7b-instruct-awq**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-3-7-sonnet**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-haiku-4-5**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-opus-4-1**|`llmengine (v2)`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-opus-4-5**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-sonnet-4**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-sonnet-4-5**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemini-2-5-flash**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemini-2-5-pro**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemma-3-12b**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-1**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-mini**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-oss-20b**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-llama-4-maverick**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-1-405b-instruct**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-1-8b-instruct**|`llmengine (v2)`|4.5e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-3-70b-instruct**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen2p5-vl-32b-instruct**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b-instruct-2507**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b-thinking-2507**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-8b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-235b-a22b-instruct**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-235b-a22b-thinking**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-30b-a3b-instruct**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-30b-a3b-thinking**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-r1-0528**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3-0324**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p1**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p1-terminus**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p2**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/glm-4p6**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/gpt-oss-20b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/kimi-k2-instruct-0905**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/kimi-k2-thinking**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-coder-480b-a35b-instruct**|`llmengine (v2)`|1.8e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/llama-v3p3-70b-instruct**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/minimax-m2**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/mixtral-8x22b-instruct**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**DeepSeek-R1-Distill-Llama-70B**|`llmengine (v2)`|6.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Llama-3.1-8B-Instruct**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Meta-Llama-3_3-70B-Instruct**|`llmengine (v2)`|6.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-7B-Instruct-v0.3**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-Nemo-Instruct-2407**|`llmengine (v2)`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-Small-3.2-24B-Instruct-2506**|`llmengine (v2)`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen2.5-Coder-32B-Instruct**|`llmengine (v2)`|8.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen2.5-VL-72B-Instruct**|`llmengine (v2)`|9.1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen3-32B**|`llmengine (v2)`|2.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**gpt-oss-120b**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**gpt-oss-20b**|`llmengine (v2)`|1.5e-07 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=llm-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**anthropic**|`claude-3-7-sonnet-latest`|<br/>
        /// |**cohere**|`command-r`|<br/>
        /// |**deepseek**|`deepseek-chat`|<br/>
        /// |**meta**|`meta.llama3-1-70b-instruct-v1:0`|<br/>
        /// |**mistral**|`mistral-large-latest`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**together_ai**|`Qwen/Qwen2.5-72B-Instruct-Turbo`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**groq**|`llama-3.3-70b-versatile`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// |**minimax**|`MiniMax-M1`|<br/>
        /// |**bytedance**|`seed-1-6-250915`|<br/>
        /// |**perplexityai**|`sonar`|<br/>
        /// |**deepinfra**|`nvidia/Llama-3.3-Nemotron-Super-49B-v1.5`|<br/>
        /// |**cerebras**|`gpt-oss-120b`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LlmchatResponseModel> LlmLlmChatCreateAsync(

            global::EdenAI.LlmchatllmchatChatRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareLlmLlmChatCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_LlmLlmChatCreateSecurityRequirements,
                operationName: "LlmLlmChatCreateAsync");

            using var __timeoutCancellationTokenSource = global::EdenAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::EdenAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::EdenAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::EdenAI.PathBuilder(
                                path: "/llm/chat/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::EdenAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::EdenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareLlmLlmChatCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LlmLlmChatCreate",
                                methodName: "LlmLlmChatCreateAsync",
                                pathTemplate: "\"/llm/chat/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LlmLlmChatCreate",
                                methodName: "LlmLlmChatCreateAsync",
                                pathTemplate: "\"/llm/chat/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::EdenAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LlmLlmChatCreate",
                                methodName: "LlmLlmChatCreateAsync",
                                pathTemplate: "\"/llm/chat/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::EdenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessLlmLlmChatCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LlmLlmChatCreate",
                                methodName: "LlmLlmChatCreateAsync",
                                pathTemplate: "\"/llm/chat/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LlmLlmChatCreate",
                                methodName: "LlmLlmChatCreateAsync",
                                pathTemplate: "\"/llm/chat/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::EdenAI.BadRequest? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::EdenAI.BadRequest.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::EdenAI.ApiException<global::EdenAI.BadRequest>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::EdenAI.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::EdenAI.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::EdenAI.ApiException<global::EdenAI.Error>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::EdenAI.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::EdenAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::EdenAI.ApiException<global::EdenAI.Error>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::EdenAI.NotFoundResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::EdenAI.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::EdenAI.ApiException<global::EdenAI.NotFoundResponse>(
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_404,
                                    ResponseObject = __value_404,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessLlmLlmChatCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::EdenAI.LlmchatResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::EdenAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::EdenAI.LlmchatResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::EdenAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Chat<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|**amazon.nova-lite-v1:0**|`llmengine (v2)`|0.24 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-micro-v1:0**|`llmengine (v2)`|0.14 (per 1000000 token)|1 token<br/>
        /// |**amazon**|**amazon.nova-pro-v1:0**|`llmengine (v2)`|3.2 (per 1000000 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-6**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-20250514**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1-20250805**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-latest**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-20241022**|`v1`|4e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-5-haiku-latest**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5-20251001**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-haiku-4-5**|`v1`|5e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-7-sonnet-20250219**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-3-haiku-20240307**|`v1`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-opus-20250514**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-4-sonnet-20250514**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-sonnet-4-5-20250929**|`v1`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-1**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-20250514**|`v1`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**anthropic**|**claude-opus-4-5-20251101**|`v1`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**cohere**|**command-r7b-12-2024**|`llmengine (v2)`|0.15 (per 1000000 token)|1 token<br/>
        /// |**cohere**|**command-r-08-2024**|`llmengine (v2)`|0.6 (per 1000000 token)|1 token<br/>
        /// |**deepseek**|**deepseek-chat**|`llmengine (v2)`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-reasoner**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**deepseek**|**deepseek-coder**|`llmengine (v2)`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-405b-instruct-v1:0**|`llmengine (v2)`|2.4 (per 1000000 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-70b-instruct-v1:0**|`llmengine (v2)`|0.72 (per 1000000 token)|1 token<br/>
        /// |**meta**|**meta.llama3-1-8b-instruct-v1:0**|`llmengine (v2)`|0.22 (per 1000000 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2506**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-2506**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-latest**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-latest**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small-latest**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-latest**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-latest**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2405**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**codestral-2508**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-medium-2507**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2505**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-small-2507**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**labs-devstral-small-2512**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**devstral-2512**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-2509**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-medium-latest**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**magistral-small-latest**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2402**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2407**|`llmengine (v2)`|9e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-large-2411**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium**|`llmengine (v2)`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2312**|`llmengine (v2)`|8.1e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-medium-2505**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-small**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**mistral-tiny**|`llmengine (v2)`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-7b**|`llmengine (v2)`|2.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mistral-nemo-2407**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x22b**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**mistral**|**open-mixtral-8x7b**|`llmengine (v2)`|7e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-12b-2409**|`llmengine (v2)`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**mistral**|**pixtral-large-2411**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o4-mini**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini-2025-04-14**|`llmengine (v2)`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano-2025-04-14**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-chat-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-pro**|`llmengine (v2)`|100.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**o4-mini-2025-04-16**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-05-13**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1-2024-12-17**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o1**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-mini-2025-01-31**|`llmengine (v2)`|4.4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-08-06**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-2024-07-18**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-0125**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-1106**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo-16k**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0125-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0314**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-0613**|`llmengine (v2)`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-1106-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-2024-04-09**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo-preview**|`llmengine (v2)`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-2025-04-14**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-mini**|`llmengine (v2)`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4.1-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-2024-11-20**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini-search-preview-2025-03-11**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-search-preview-2025-03-11**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-2025-11-13**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.1-chat-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-2025-12-11**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5.2-chat-latest**|`llmengine (v2)`|1.4e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-2025-08-07**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-mini-2025-08-07**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-5-nano-2025-08-07**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**o3-2025-04-16**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`llmengine (v2)`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen2.5-72B-Instruct-Turbo**|`llmengine (v2)`|1.2 (per 1000000 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-fp8-tput**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-FP8**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1**|`llmengine (v2)`|7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-R1-0528-tput**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3**|`llmengine (v2)`|1.25e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**deepseek-ai/DeepSeek-V3.1**|`llmengine (v2)`|1.7e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`llmengine (v2)`|8.5e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`llmengine (v2)`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`llmengine (v2)`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`llmengine (v2)`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**openai/gpt-oss-20b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.5-Air-FP8**|`llmengine (v2)`|1.1e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**zai-org/GLM-4.6**|`llmengine (v2)`|2.2e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**moonshotai/Kimi-K2-Instruct-0905**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-Next-80B-A3B-Thinking**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**Qwen/Qwen3-235B-A22B-Instruct-2507-tput**|`llmengine (v2)`|6e-06 (per 1 token)|1 token<br/>
        /// |**together_ai**|**meta-llama/Meta-Llama-3.1-405B-Instruct-Turbo**|`llmengine (v2)`|3.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-0709**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-1212**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-2-vision-latest**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-beta**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-beta**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-fast-latest**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-beta**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-beta**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-fast-latest**|`llmengine (v2)`|4e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-3-mini-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-fast-non-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-latest**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-reasoning-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-4-1-fast-non-reasoning-latest**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**xai**|**grok-code-fast-1-0825**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-preview**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-image-preview**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3.1-pro-preview**|`llmengine (v2)`|1.2e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-3-pro-image-preview**|`llmengine (v2)`|12.0 (per 1000000 token)|1 token<br/>
        /// |**google**|**gemini-3-flash-preview**|`llmengine (v2)`|3e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-lite**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.0-flash-001**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-lite-preview-09-2025**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-flash-preview-09-2025**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-latest**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-flash-lite-latest**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-2.5-pro**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemma-3-27b-it**|`llmengine (v2)`|0.0 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-120b**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.3-70b-versatile**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**llama-3.1-8b-instant**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-guard-4-12b**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-maverick-17b-128e-instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**meta-llama/llama-4-scout-17b-16e-instruct**|`v1`|3.4e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**moonshotai/kimi-k2-instruct-0905**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**groq**|**openai/gpt-oss-20b**|`v1`|5e-07 (per 1 token)|1 token<br/>
        /// |**groq**|**qwen/qwen3-32b**|`v1`|5.9e-07 (per 1 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o**|`Azure AI Foundry`|5.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**o3-mini**|`Azure AI Foundry`|4.4 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**o1-mini**|`Azure AI Foundry`|12.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4o-mini**|`Azure AI Foundry`|0.66 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-4**|`Azure AI Foundry`|60.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-35-turbo-16k**|`Azure AI Foundry`|4.0 (per 1000000 token)|1 token<br/>
        /// |**microsoft**|**gpt-35-turbo**|`Azure AI Foundry`|1.5 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**minimax-m1**|`v1`|2.2 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**minimax-text-01**|`v1`|1.1 (per 1000000 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2.1**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2.1-lightning**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**minimax**|**MiniMax-M2**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**bytedance**|**seed-1-6-250915**|`llmengine (v2)`|2.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`llmengine (v2)`|1.0 (per 1000000 token)|1 token<br/>
        /// |**perplexityai**|**sonar**|`llmengine (v2)`|1e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-deep-research**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-pro**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**perplexityai**|**sonar-reasoning-pro**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Gryphe/MythoMax-L2-13b**|`v1`|9e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**NousResearch/Hermes-3-Llama-3.1-405B**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**NousResearch/Hermes-3-Llama-3.1-70B**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/QwQ-32B**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-72B-Instruct**|`v1`|3.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-7B-Instruct**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen2.5-VL-32B-Instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-14B**|`v1`|2.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B**|`v1`|5.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B-Instruct-2507**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-235B-A22B-Thinking-2507**|`v1`|2.9e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-30B-A3B**|`v1`|2.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-32B**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Coder-480B-A35B-Instruct**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Coder-480B-A35B-Instruct-Turbo**|`v1`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Qwen/Qwen3-Next-80B-A3B-Instruct**|`v1`|1.4e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3-8B-Lunaris-v1-Turbo**|`v1`|5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3.1-70B-Euryale-v2.2**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Sao10K/L3.3-70B-Euryale-v2.3**|`v1`|7.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-3-7-sonnet-latest**|`v1`|1.65e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-4-opus**|`v1`|8.25e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**anthropic/claude-4-sonnet**|`v1`|1.65e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1**|`v1`|2.4e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/Llama-3.3-Nemotron-Super-49B-v1.5**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-0528**|`v1`|2.15e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Distill-Llama-70B**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Distill-Qwen-32B**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-Turbo**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3**|`v1`|8.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3-0324**|`v1`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3.1**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-V3.1-Terminus**|`v1`|1e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.0-flash-001**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.5-flash**|`v1`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemini-2.5-pro**|`v1`|1e-05 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-12b-it**|`v1`|1e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-27b-it**|`v1`|1.6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**google/gemma-3-4b-it**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.2-11B-Vision-Instruct**|`v1`|4.9e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.2-3B-Instruct**|`v1`|2e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.3-70B-Instruct**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-3.3-70B-Instruct-Turbo**|`v1`|3.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-4-Maverick-17B-128E-Instruct-FP8**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-4-Scout-17B-16E-Instruct**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-Guard-3-8B**|`v1`|5.5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-Guard-4-12B**|`v1`|1.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-8B-Instruct**|`v1`|6e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-70B-Instruct**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-70B-Instruct-Turbo**|`v1`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-8B-Instruct**|`v1`|5e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo**|`v1`|3e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**microsoft/WizardLM-2-8x22B**|`v1`|4.8e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**microsoft/phi-4**|`v1`|1.4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Nemo-Instruct-2407**|`v1`|4e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Small-24B-Instruct-2501**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-Small-3.2-24B-Instruct-2506**|`v1`|2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|4e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**moonshotai/Kimi-K2-Instruct**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**moonshotai/Kimi-K2-Instruct-0905**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/Llama-3.1-Nemotron-70B-Instruct**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**nvidia/NVIDIA-Nemotron-Nano-9B-v2**|`v1`|1.6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openai/gpt-oss-120b**|`v1`|4.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openai/gpt-oss-20b**|`v1`|1.5e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**zai-org/GLM-4.5**|`v1`|1.6e-06 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**lizpreciatior/lzlv_70b_fp16_hf**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Gryphe/MythoMax-L2-13b**|`v1`|2.2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mistral-7B-Instruct-v0.1**|`v1`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-2-70b-chat-hf**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**cognitivecomputations/dolphin-2.6-mixtral-8x7b**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**Phind/Phind-CodeLlama-34B-v2**|`v1`|6e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**mistralai/Mixtral-8x7B-Instruct-v0.1**|`v1`|2.7e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Llama-2-13b-chat-hf**|`v1`|2.2e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-8B-Instruct**|`v1`|8e-08 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3-70B-Instruct**|`v1`|7.9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**meta-llama/Meta-Llama-3.1-405B-Instruct**|`v1`|9e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**openchat/openchat_3.5**|`v1`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**deepinfra**|**deepseek-ai/DeepSeek-R1-0528-Turbo**|`v1`|3e-06 (per 1 token)|1 token<br/>
        /// |**cerebras**|**llama3.1-8b**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**cerebras**|**gpt-oss-120b**|`llmengine (v2)`|6.9e-07 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/meta/llama-2-7b-chat-fp16**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/meta/llama-2-7b-chat-int8**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@cf/mistral/mistral-7b-instruct-v0.1**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**cloudflare**|**@hf/thebloke/codellama-7b-instruct-awq**|`llmengine (v2)`|1.923e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-3-7-sonnet**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-haiku-4-5**|`llmengine (v2)`|5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-opus-4-1**|`llmengine (v2)`|7.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-opus-4-5**|`llmengine (v2)`|2.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-sonnet-4**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-claude-sonnet-4-5**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemini-2-5-flash**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemini-2-5-pro**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gemma-3-12b**|`llmengine (v2)`|5e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-1**|`llmengine (v2)`|1e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-mini**|`llmengine (v2)`|2e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-5-nano**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-gpt-oss-20b**|`llmengine (v2)`|3e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-llama-4-maverick**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-1-405b-instruct**|`llmengine (v2)`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-1-8b-instruct**|`llmengine (v2)`|4.5e-07 (per 1 token)|1 token<br/>
        /// |**databricks**|**databricks-meta-llama-3-3-70b-instruct**|`llmengine (v2)`|1.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen2p5-vl-32b-instruct**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b-instruct-2507**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-235b-a22b-thinking-2507**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-8b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-235b-a22b-instruct**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-235b-a22b-thinking**|`llmengine (v2)`|8.8e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-30b-a3b-instruct**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-vl-30b-a3b-thinking**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-r1-0528**|`llmengine (v2)`|8e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3-0324**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p1**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p1-terminus**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/deepseek-v3p2**|`llmengine (v2)`|1.68e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/glm-4p6**|`llmengine (v2)`|2.19e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/gpt-oss-120b**|`llmengine (v2)`|6e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/gpt-oss-20b**|`llmengine (v2)`|2e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/kimi-k2-instruct-0905**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/kimi-k2-thinking**|`llmengine (v2)`|2.5e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/qwen3-coder-480b-a35b-instruct**|`llmengine (v2)`|1.8e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/llama-v3p3-70b-instruct**|`llmengine (v2)`|9e-07 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/minimax-m2**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**fireworks_ai**|**accounts/fireworks/models/mixtral-8x22b-instruct**|`llmengine (v2)`|1.2e-06 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**DeepSeek-R1-Distill-Llama-70B**|`llmengine (v2)`|6.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Llama-3.1-8B-Instruct**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Meta-Llama-3_3-70B-Instruct**|`llmengine (v2)`|6.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-7B-Instruct-v0.3**|`llmengine (v2)`|1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-Nemo-Instruct-2407**|`llmengine (v2)`|1.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mistral-Small-3.2-24B-Instruct-2506**|`llmengine (v2)`|2.8e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Mixtral-8x7B-Instruct-v0.1**|`llmengine (v2)`|6.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen2.5-Coder-32B-Instruct**|`llmengine (v2)`|8.7e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen2.5-VL-72B-Instruct**|`llmengine (v2)`|9.1e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**Qwen3-32B**|`llmengine (v2)`|2.3e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**gpt-oss-120b**|`llmengine (v2)`|4e-07 (per 1 token)|1 token<br/>
        /// |**ovhcloud**|**gpt-oss-20b**|`llmengine (v2)`|1.5e-07 (per 1 token)|1 token<br/>
        /// &lt;/details&gt;<br/>
        /// &lt;a href='https://old-app.edenai.run/v2/models?technology=llm-chat' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**amazon**|`amazon.nova-pro-v1:0`|<br/>
        /// |**anthropic**|`claude-3-7-sonnet-latest`|<br/>
        /// |**cohere**|`command-r`|<br/>
        /// |**deepseek**|`deepseek-chat`|<br/>
        /// |**meta**|`meta.llama3-1-70b-instruct-v1:0`|<br/>
        /// |**mistral**|`mistral-large-latest`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**together_ai**|`Qwen/Qwen2.5-72B-Instruct-Turbo`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// |**google**|`gemini-2.0-flash`|<br/>
        /// |**groq**|`llama-3.3-70b-versatile`|<br/>
        /// |**microsoft**|`gpt-4o`|<br/>
        /// |**minimax**|`MiniMax-M1`|<br/>
        /// |**bytedance**|`seed-1-6-250915`|<br/>
        /// |**perplexityai**|`sonar`|<br/>
        /// |**deepinfra**|`nvidia/Llama-3.3-Nemotron-Super-49B-v1.5`|<br/>
        /// |**cerebras**|`gpt-oss-120b`|<br/>
        /// &lt;/details&gt;
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.LlmchatResponseModel> LlmLlmChatCreateAsync(
            global::System.Collections.Generic.IList<object> messages,
            string model,
            global::EdenAI.ReasoningEffortEnum? reasoningEffort = default,
            global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>? metadata = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxCompletionTokens = default,
            int? n = default,
            global::System.Collections.Generic.IList<string>? modalities = default,
            object? prediction = default,
            object? audio = default,
            double? presencePenalty = default,
            object? responseFormat = default,
            int? seed = default,
            global::EdenAI.ServiceTierEnum? serviceTier = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            bool? stream = default,
            object? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            string? functionCall = default,
            global::System.Collections.Generic.IList<object>? functions = default,
            global::EdenAI.ThinkingRequest? thinking = default,
            object? webSearchOptions = default,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.LlmchatllmchatChatRequest
            {
                Messages = messages,
                Model = model,
                ReasoningEffort = reasoningEffort,
                Metadata = metadata,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                Modalities = modalities,
                Prediction = prediction,
                Audio = audio,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
                FunctionCall = functionCall,
                Functions = functions,
                Thinking = thinking,
                WebSearchOptions = webSearchOptions,
            };

            return await LlmLlmChatCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}