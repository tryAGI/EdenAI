
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Your project description<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEdenAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::EdenAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::EdenAI.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AiDetectionClient AiDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnonymizationClient Anonymization { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnonymizationAsyncClient AnonymizationAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public AutomaticTranslationClient AutomaticTranslation { get; }

        /// <summary>
        /// 
        /// </summary>
        public AutomlClassificationClient AutomlClassification { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundRemovalClient BackgroundRemoval { get; }

        /// <summary>
        /// 
        /// </summary>
        public BankCheckParsingClient BankCheckParsing { get; }

        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public CodeGenerationClient CodeGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public CostMonitoringClient CostMonitoring { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotCreateOperationsClient CustomChatbotCreateOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotDeleteOperationsClient CustomChatbotDeleteOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotInfoOperationsClient CustomChatbotInfoOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotQueryOperationsClient CustomChatbotQueryOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotUpdateOperationsClient CustomChatbotUpdateOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotUploadOperationsClient CustomChatbotUploadOperations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomDocumentParsingAsyncClient CustomDocumentParsingAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataExtractionClient DataExtraction { get; }

        /// <summary>
        /// 
        /// </summary>
        public DeepfakeDetectionClient DeepfakeDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public DeepfakeDetectionAsyncClient DeepfakeDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentTranslationClient DocumentTranslation { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmotionDetectionClient EmotionDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnabledFeaturesClient EnabledFeatures { get; }

        /// <summary>
        /// 
        /// </summary>
        public EntitySentimentClient EntitySentiment { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExecutionsClient Executions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExplicitContentClient ExplicitContent { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExplicitContentDetectionAsyncClient ExplicitContentDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public FaceCompareClient FaceCompare { get; }

        /// <summary>
        /// 
        /// </summary>
        public FaceDetectionClient FaceDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public FaceDetectionAsyncClient FaceDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public FaceRecognitionClient FaceRecognition { get; }

        /// <summary>
        /// 
        /// </summary>
        public FinancialParserClient FinancialParser { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationClient Generation { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationAsyncClient GenerationAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public IdentityParserClient IdentityParser { get; }

        /// <summary>
        /// 
        /// </summary>
        public InfosClient Infos { get; }

        /// <summary>
        /// 
        /// </summary>
        public KeywordExtractionClient KeywordExtraction { get; }

        /// <summary>
        /// 
        /// </summary>
        public LabelDetectionAsyncClient LabelDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public LandmarkDetectionClient LandmarkDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public LanguageDetectionClient LanguageDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogoDetectionClient LogoDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogoDetectionAsyncClient LogoDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation { get; }

        /// <summary>
        /// 
        /// </summary>
        public NamedEntityRecognitionClient NamedEntityRecognition { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObjectDetectionClient ObjectDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObjectTrackingAsyncClient ObjectTrackingAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public OcrClient Ocr { get; }

        /// <summary>
        /// 
        /// </summary>
        public OcrAsyncClient OcrAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public OcrTablesAsyncClient OcrTablesAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public PersonTrackingAsyncClient PersonTrackingAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlagiaDetectionClient PlagiaDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptOptimizationClient PromptOptimization { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswerClient QuestionAnswer { get; }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswerAsyncClient QuestionAnswerAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResumeParserClient ResumeParser { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public SentimentAnalysisClient SentimentAnalysis { get; }

        /// <summary>
        /// 
        /// </summary>
        public ShotChangeDetectionAsyncClient ShotChangeDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextAsyncClient SpeechToTextAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpellCheckClient SpellCheck { get; }

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextDetectionAsyncClient TextDetectionAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechAsyncClient TextToSpeechAsync { get; }

        /// <summary>
        /// 
        /// </summary>
        public TopicExtractionClient TopicExtraction { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserManagementClient UserManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookClient Webhook { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowsClient Workflows { get; }

    }
}