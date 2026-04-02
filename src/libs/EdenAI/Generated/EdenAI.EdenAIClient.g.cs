
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// Your project description<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class EdenAIClient : global::EdenAI.IEdenAIClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.edenai.run/v2";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::EdenAI.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::EdenAI.JsonConverters.BlankEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.BlankEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.CategoryTypeJsonConverter(),
                    new global::EdenAI.JsonConverters.CategoryTypeNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ChatRoleJsonConverter(),
                    new global::EdenAI.JsonConverters.ChatRoleNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.DataTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.DataTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.DbProviderEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.DbProviderEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.DetailTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.DetailTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.DocumentTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.DocumentTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.EmbeddingsProviderEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.EmbeddingsProviderEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.EntitySentimentEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.EntitySentimentEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ExecutionContentCreateStatusEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ExecutionContentCreateStatusEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.FallbackTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.FallbackTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.FinalStatusEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.FinalStatusEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.GeneralSentimentEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.GeneralSentimentEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ImageaiDetectionAiDetectionDataClassPredictionEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ImageaiDetectionAiDetectionDataClassPredictionEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.OptionEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.OptionEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.PredictionB20EnumJsonConverter(),
                    new global::EdenAI.JsonConverters.PredictionB20EnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.PriceUnitTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.PriceUnitTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ProjectTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ProjectTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ReasoningEffortEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.RepresentationEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.RepresentationEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.SentimentEbfEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.SentimentEbfEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ServiceTierEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ServiceTierEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.StateEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.StateEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.Status549EnumJsonConverter(),
                    new global::EdenAI.JsonConverters.Status549EnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.Status889EnumJsonConverter(),
                    new global::EdenAI.JsonConverters.Status889EnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.SubCategoryTypeJsonConverter(),
                    new global::EdenAI.JsonConverters.SubCategoryTypeNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ThinkingTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ThinkingTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.TokenTypeEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.TokenTypeEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.ToolChoiceEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.ToolChoiceEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.TypeDe8EnumJsonConverter(),
                    new global::EdenAI.JsonConverters.TypeDe8EnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.TypeOfDataEnumJsonConverter(),
                    new global::EdenAI.JsonConverters.TypeOfDataEnumNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.FeatureBatchRetrieveStatusJsonConverter(),
                    new global::EdenAI.JsonConverters.FeatureBatchRetrieveStatusNullableJsonConverter(),
                    new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum>(),
                    new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum>(),
                    new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>(),
                    new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>(),
                    new global::EdenAI.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AiDetectionClient AiDetection => new AiDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnonymizationClient Anonymization => new AnonymizationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnonymizationAsyncClient AnonymizationAsync => new AnonymizationAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AutomaticTranslationClient AutomaticTranslation => new AutomaticTranslationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AutomlClassificationClient AutomlClassification => new AutomlClassificationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BackgroundRemovalClient BackgroundRemoval => new BackgroundRemovalClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BankCheckParsingClient BankCheckParsing => new BankCheckParsingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CodeGenerationClient CodeGeneration => new CodeGenerationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CostMonitoringClient CostMonitoring => new CostMonitoringClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotCreateOperationsClient CustomChatbotCreateOperations => new CustomChatbotCreateOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotDeleteOperationsClient CustomChatbotDeleteOperations => new CustomChatbotDeleteOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotInfoOperationsClient CustomChatbotInfoOperations => new CustomChatbotInfoOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotQueryOperationsClient CustomChatbotQueryOperations => new CustomChatbotQueryOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotUpdateOperationsClient CustomChatbotUpdateOperations => new CustomChatbotUpdateOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomChatbotUploadOperationsClient CustomChatbotUploadOperations => new CustomChatbotUploadOperationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomDocumentParsingAsyncClient CustomDocumentParsingAsync => new CustomDocumentParsingAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataExtractionClient DataExtraction => new DataExtractionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeepfakeDetectionClient DeepfakeDetection => new DeepfakeDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeepfakeDetectionAsyncClient DeepfakeDetectionAsync => new DeepfakeDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DocumentTranslationClient DocumentTranslation => new DocumentTranslationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmotionDetectionClient EmotionDetection => new EmotionDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnabledFeaturesClient EnabledFeatures => new EnabledFeaturesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EntitySentimentClient EntitySentiment => new EntitySentimentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExecutionsClient Executions => new ExecutionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExplicitContentClient ExplicitContent => new ExplicitContentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExplicitContentDetectionAsyncClient ExplicitContentDetectionAsync => new ExplicitContentDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FaceCompareClient FaceCompare => new FaceCompareClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FaceDetectionClient FaceDetection => new FaceDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FaceDetectionAsyncClient FaceDetectionAsync => new FaceDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FaceRecognitionClient FaceRecognition => new FaceRecognitionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FinancialParserClient FinancialParser => new FinancialParserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationClient Generation => new GenerationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationAsyncClient GenerationAsync => new GenerationAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IdentityParserClient IdentityParser => new IdentityParserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfosClient Infos => new InfosClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public KeywordExtractionClient KeywordExtraction => new KeywordExtractionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LabelDetectionAsyncClient LabelDetectionAsync => new LabelDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LandmarkDetectionClient LandmarkDetection => new LandmarkDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LanguageDetectionClient LanguageDetection => new LanguageDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogoDetectionClient LogoDetection => new LogoDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogoDetectionAsyncClient LogoDetectionAsync => new LogoDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation => new ModerationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public NamedEntityRecognitionClient NamedEntityRecognition => new NamedEntityRecognitionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ObjectDetectionClient ObjectDetection => new ObjectDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ObjectTrackingAsyncClient ObjectTrackingAsync => new ObjectTrackingAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OcrClient Ocr => new OcrClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OcrAsyncClient OcrAsync => new OcrAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OcrTablesAsyncClient OcrTablesAsync => new OcrTablesAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PersonTrackingAsyncClient PersonTrackingAsync => new PersonTrackingAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlagiaDetectionClient PlagiaDetection => new PlagiaDetectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptOptimizationClient PromptOptimization => new PromptOptimizationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswerClient QuestionAnswer => new QuestionAnswerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswerAsyncClient QuestionAnswerAsync => new QuestionAnswerAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources => new ResourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResumeParserClient ResumeParser => new ResumeParserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SentimentAnalysisClient SentimentAnalysis => new SentimentAnalysisClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ShotChangeDetectionAsyncClient ShotChangeDetectionAsync => new ShotChangeDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextAsyncClient SpeechToTextAsync => new SpeechToTextAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpellCheckClient SpellCheck => new SpellCheckClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize => new SummarizeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextDetectionAsyncClient TextDetectionAsync => new TextDetectionAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech => new TextToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechAsyncClient TextToSpeechAsync => new TextToSpeechAsyncClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TopicExtractionClient TopicExtraction => new TopicExtractionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserManagementClient UserManagement => new UserManagementClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhookClient Webhook => new WebhookClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkflowsClient Workflows => new WorkflowsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the EdenAIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public EdenAIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::EdenAI.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::EdenAI.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}