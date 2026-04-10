
#nullable enable

namespace EdenAI
{
    public partial class SentimentAnalysisClient
    {


        private static readonly global::EdenAI.EndPointSecurityRequirement s_TextTextSentimentAnalysisCreateSecurityRequirement0 =
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
        private static readonly global::EdenAI.EndPointSecurityRequirement[] s_TextTextSentimentAnalysisCreateSecurityRequirements =
            new global::EdenAI.EndPointSecurityRequirement[]
            {                s_TextTextSentimentAnalysisCreateSecurityRequirement0,
            };
        partial void PrepareTextTextSentimentAnalysisCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request);
        partial void PrepareTextTextSentimentAnalysisCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request);
        partial void ProcessTextTextSentimentAnalysisCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextTextSentimentAnalysisCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Sentiment Analysis<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
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
        /// |**microsoft**|-|`v3.1`|1.0 (per 1000000 char)|1000 char<br/>
        /// |**openai**|-|`v3.0.0`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
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
        /// |**tenstorrent**|-|`v1.1.0`|0.7 (per 1000000 char)|1000 char<br/>
        /// |**sapling**|-|`v1`|20.0 (per 1000000 char)|1000 char<br/>
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
        /// |**Arabic**|`ar`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-sentiment_analysis' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
        /// |**openai**|`gpt-4o`|<br/>
        /// |**xai**|`grok-2-latest`|<br/>
        /// &lt;/details&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EdenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextsentimentAnalysisResponseModel> TextTextSentimentAnalysisCreateAsync(

            global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest request,
            global::EdenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTextTextSentimentAnalysisCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::EdenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TextTextSentimentAnalysisCreateSecurityRequirements,
                operationName: "TextTextSentimentAnalysisCreateAsync");

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
                                path: "/text/sentiment_analysis/",
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
                PrepareTextTextSentimentAnalysisCreateRequest(
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
                                operationId: "TextTextSentimentAnalysisCreate",
                                methodName: "TextTextSentimentAnalysisCreateAsync",
                                pathTemplate: "\"/text/sentiment_analysis/\"",
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
                                operationId: "TextTextSentimentAnalysisCreate",
                                methodName: "TextTextSentimentAnalysisCreateAsync",
                                pathTemplate: "\"/text/sentiment_analysis/\"",
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
                                operationId: "TextTextSentimentAnalysisCreate",
                                methodName: "TextTextSentimentAnalysisCreateAsync",
                                pathTemplate: "\"/text/sentiment_analysis/\"",
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
                ProcessTextTextSentimentAnalysisCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::EdenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::EdenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextTextSentimentAnalysisCreate",
                                methodName: "TextTextSentimentAnalysisCreateAsync",
                                pathTemplate: "\"/text/sentiment_analysis/\"",
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
                                operationId: "TextTextSentimentAnalysisCreate",
                                methodName: "TextTextSentimentAnalysisCreateAsync",
                                pathTemplate: "\"/text/sentiment_analysis/\"",
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
                                ProcessTextTextSentimentAnalysisCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::EdenAI.TextsentimentAnalysisResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::EdenAI.TextsentimentAnalysisResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Sentiment Analysis<br/>
        /// &lt;details&gt;&lt;summary&gt;&lt;strong style='color: #0072a3; cursor: pointer'&gt;Available Providers&lt;/strong&gt;&lt;/summary&gt;<br/>
        /// |Provider|Model|Version|Price|Billing unit|<br/>
        /// |----|----|-------|-----|------------|<br/>
        /// |**amazon**|-|`boto3 (v1.15.18)`|1.0 (per 1000000 char)|300 char<br/>
        /// |**google**|**gemini-live-2.5-flash-preview-native-audio-09-2025**|`v1`|2e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-001**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-002**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-latest**|`v1`|3e-07 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro**|`v1`|1.05e-05 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-pro-latest**|`v1`|1.05e-06 (per 1 token)|1 token<br/>
        /// |**google**|**gemini-1.5-flash-8b**|`v1`|0.0 (per 1 token)|1 token<br/>
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
        /// |**microsoft**|-|`v3.1`|1.0 (per 1000000 char)|1000 char<br/>
        /// |**openai**|-|`v3.0.0`|20.0 (per 1000000 token)|1 token<br/>
        /// |**openai**|**chatgpt-4o-latest**|`v3.0.0`|1.5e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4**|`v3.0.0`|6e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o**|`v3.0.0`|1e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4o-mini**|`v3.0.0`|6e-07 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-4-turbo**|`v3.0.0`|3e-05 (per 1 token)|1 token<br/>
        /// |**openai**|**gpt-3.5-turbo**|`v3.0.0`|1.5e-06 (per 1 token)|1 token<br/>
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
        /// |**tenstorrent**|-|`v1.1.0`|0.7 (per 1000000 char)|1000 char<br/>
        /// |**sapling**|-|`v1`|20.0 (per 1000000 char)|1000 char<br/>
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
        /// |**Arabic**|`ar`|<br/>
        /// |**Chinese**|`zh`|<br/>
        /// |**Danish**|`da`|<br/>
        /// |**Dutch**|`nl`|<br/>
        /// |**English**|`en`|<br/>
        /// |**Finnish**|`fi`|<br/>
        /// |**French**|`fr`|<br/>
        /// |**German**|`de`|<br/>
        /// |**Hindi**|`hi`|<br/>
        /// |**Indonesian**|`id`|<br/>
        /// |**Italian**|`it`|<br/>
        /// |**Japanese**|`ja`|<br/>
        /// |**Korean**|`ko`|<br/>
        /// |**Modern Greek (1453-)**|`el`|<br/>
        /// |**Norwegian**|`no`|<br/>
        /// |**Polish**|`pl`|<br/>
        /// |**Portuguese**|`pt`|<br/>
        /// |**Russian**|`ru`|<br/>
        /// |**Spanish**|`es`|<br/>
        /// |**Swedish**|`sv`|<br/>
        /// |**Thai**|`th`|<br/>
        /// |**Turkish**|`tr`|<br/>
        /// |**Vietnamese**|`vi`|<br/>
        /// &lt;/details&gt;&lt;details&gt;&lt;summary&gt;Supported Detailed Languages&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**Auto detection**|`auto-detect`|<br/>
        /// |**Chinese (Simplified)**|`zh-Hans`|<br/>
        /// |**Chinese (Taiwan)**|`zh-TW`|<br/>
        /// |**Chinese (Traditional)**|`zh-Hant`|<br/>
        /// |**Portuguese (Brazil)**|`pt-BR`|<br/>
        /// |**Portuguese (Portugal)**|`pt-PT`|<br/>
        /// &lt;/details&gt;&lt;a href='https://old-app.edenai.run/v2/models?technology=text-sentiment_analysis' target='_blank' rel='noopener noreferrer' &gt;&lt;h4&gt;Supported Models&lt;/h4&gt;&lt;/a&gt;<br/>
        /// &lt;details&gt;&lt;summary&gt;Default Models&lt;/summary&gt;<br/>
        /// |Name|Value|<br/>
        /// |----|-----|<br/>
        /// |**google**|`gemini-2.5-flash`|<br/>
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
        public async global::System.Threading.Tasks.Task<global::EdenAI.TextsentimentAnalysisResponseModel> TextTextSentimentAnalysisCreateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest
            {
                Settings = settings,
                Providers = providers,
                FallbackProviders = fallbackProviders,
                ResponseAsDict = responseAsDict,
                AttributesAsList = attributesAsList,
                ShowBase64 = showBase64,
                ShowOriginalResponse = showOriginalResponse,
                Text = text,
                Language = language,
            };

            return await TextTextSentimentAnalysisCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}