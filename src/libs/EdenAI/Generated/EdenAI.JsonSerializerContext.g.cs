
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace EdenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest), TypeInfoPropertyName = "TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsy_2d9618c64ac15db3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AIProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProjectTypeEnum), TypeInfoPropertyName = "ProjectTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AddFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DataTypeEnum), TypeInfoPropertyName = "DataTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AddImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AddTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AddUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AddVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AiDetectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AiProductFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum?>), TypeInfoPropertyName = "OneOfStatus889EnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status889Enum), TypeInfoPropertyName = "Status889Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AnonymizationAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AnonymizationBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AnonymizationEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CategoryType), TypeInfoPropertyName = "CategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SubCategoryType), TypeInfoPropertyName = "SubCategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AnonymizationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AskLLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AskYodaProjectUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AskYourDataProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DbProviderEnum), TypeInfoPropertyName = "DbProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EmbeddingsProviderEnum), TypeInfoPropertyName = "EmbeddingsProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AssetUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncJobList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.StateEnum), TypeInfoPropertyName = "StateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncOcrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncVideoAnalysisRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AutomlClassificationListProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AutomlClassificationProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AutomlClassificationProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AutomlClassificationPredictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AutomlClassificationTrainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AutomlClassificationUploadDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TypeOfDataEnum), TypeInfoPropertyName = "TypeOfDataEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BalanceResetPeriodEnum), TypeInfoPropertyName = "BalanceResetPeriodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BatchLaunchFailedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BatchLaunchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.BatchLaunchFailedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BatchList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BatchResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BlankEnum), TypeInfoPropertyName = "BlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BoundingBox2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BoundixBoxOCRTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Cell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatAvailableToolsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.UsageTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatRole), TypeInfoPropertyName = "ChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessageDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatAvailableToolsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatToolCallsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatToolCallsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatToolResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ContentNSFW))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ConversationDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ConversationDetailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CostMonitoringResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.TokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TokenData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Country))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomDocumentParsingAsyncBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomDocumentParsingAsyncItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomDocumentParsingAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomTokenUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TokenTypeEnum), TypeInfoPropertyName = "TokenTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomTokensCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomTokensCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CustomTokensList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DetailPerFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PredictionB20Enum), TypeInfoPropertyName = "PredictionB20Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DetailTypeEnum), TypeInfoPropertyName = "DetailTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DocumentTypeEnum), TypeInfoPropertyName = "DocumentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EmbeddingDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EmotionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Entity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EntitySentimentEnum), TypeInfoPropertyName = "EntitySentimentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NestedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExecutionContentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExecutionContentCreateStatusEnum), TypeInfoPropertyName = "ExecutionContentCreateStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExecutionExampleSuccessCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExecutionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExplicitItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExtractedTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceAccessories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoFacePoses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceCompareBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceEmotions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceFacialHair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceHair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FaceHairColor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceHairColor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceLandmarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FacePoses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceMakeup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceOcclusions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FaceMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FallbackTypeEnum), TypeInfoPropertyName = "FallbackTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Feature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FieldError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinalStatusEnum), TypeInfoPropertyName = "FinalStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialBankInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialBarcode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialCustomerInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialDocumentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialBarcode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialDocumentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialLocalInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialMerchantInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialParserObjectDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinancialPaymentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.GeneralSentimentEnum), TypeInfoPropertyName = "GeneralSentimentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.MetadataRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ServiceTierEnum), TypeInfoPropertyName = "ServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.GeneratedImageDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.GenerationAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum), TypeInfoPropertyName = "ImageaiDetectionAiDetectionDataClassPredictionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.InfosIdentityParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ItemIdentityParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.InfosKeywordExtractionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.InfosLanguageDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.InfosNamedEntityRecognitionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ItemBankCheckParsingDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MicrModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ItemDataExtraction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LandmarkItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LandmarkVertice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LandmarkVertice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LandmarkLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LandmarkLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LandmarkLatLng))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LandmarksVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LaunchAsyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Line))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ListAsyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AsyncJobList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ListChunkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LogoBoundingPoly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LogoVertice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LogoVertice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LogoItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LogoTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoLogo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoLogo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LowerCloth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ObjectFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoObjectBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ObjectItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ObjectTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ObjectFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrTablesAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OptionEnum), TypeInfoPropertyName = "OptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Page))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Line>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PaginatedBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.BatchResponseRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PaginatedExecutionListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ExecutionList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PaginatedPromptCreateList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PromptCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PaginatedPromptHistoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PromptHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedAskYodaProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedAssetUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedConversationDetailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedCustomTokenUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedPromptHistoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedPromptUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedResourceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TypeDe8Enum), TypeInfoPropertyName = "TypeDe8Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PatchedWebhookParametersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PersonAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.UpperCloth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.UpperCloth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LowerCloth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PersonLandmarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PersonTracking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoPersonPoses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoPersonQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoTrackingBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PlagiaDetectionCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PlagiaDetectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PriceUnitTypeEnum), TypeInfoPropertyName = "PriceUnitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PricingSerialzier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>), TypeInfoPropertyName = "OneOfDetailTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptHistoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PromptUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProviderSubfeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PricingSerialzier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Subfeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeatureLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProviderSubfeatureLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.QuestionAnswerAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.RepresentationEnum), TypeInfoPropertyName = "RepresentationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResourceCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResourceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AssetList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResourceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeEducation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ResumeEducationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeEducationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeExtractedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumePersonalInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeWorkExp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ResumeLang>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeLang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ResumeSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumePersonalName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ResumeWorkExpEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ResumeWorkExpEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Row))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SegmentSentimentAnalysisDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SentimentEbfEnum), TypeInfoPropertyName = "SentimentEbfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ShotFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SpeechDiarization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.SpeechDiarizationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SpeechDiarizationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SpeechToTextAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SpellCheckItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.SuggestionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SuggestionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum), TypeInfoPropertyName = "Status549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Table))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextModerationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextToSpeechAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>), TypeInfoPropertyName = "OneOfOptionEnumBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingTypeEnum), TypeInfoPropertyName = "ThinkingTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::EdenAI.Details>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::EdenAI.Details>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoLabelTimeStamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoLabelTimeStamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoLabelBoundingBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoLabelBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoLogoBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoTextFrames>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoTextFrames))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoTextBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoTrackingPerson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PersonTracking>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.WebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.WebhookParametersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Workflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaAskLlmResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaCreateProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaListChunksIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.YodaQueryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaQueryResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.YodaQueryResponsePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncaudiospeechToTextAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiospeechToTextAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncaudiotextToSpeechAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiotextToSpeechAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncocranonymizationAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcranonymizationAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncocrcustomDocumentParsingAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrcustomDocumentParsingAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncocrocrAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncocrocrTablesAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrTablesAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideodeepfakeDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideodeepfakeDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideoexplicitContentDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoexplicitContentDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideofaceDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideofaceDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideogenerationAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideogenerationAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideolabelDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideolabelDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideologoDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideologoDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideoobjectTrackingAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoobjectTrackingAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideopersonTrackingAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideopersonTrackingAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideoquestionAnswerAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoquestionAnswerAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideoshotChangeDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoshotChangeDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AsyncvideotextDetectionAsyncResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideotextDetectionAsyncModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiospeechToTextAsyncSpeechToTextAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiotextToSpeechResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiotextToSpeechTextToSpeechDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiotextToSpeechTextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.AudiotextToSpeechAsyncTextToSpeechAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CreditsSerializer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageaiDetectionAiDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageaiDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageanonymizationAnonymizationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AnonymizationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageanonymizationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageanonymizationimagelandmarkDetectionimageexplicitContentimagedeepfakeDetectionImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageautomlClassificationAutomlClassificationCreateProjectDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageautomlClassificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageautomlClassificationcreateProjectAutomlClassificationCreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageautomlClassificationdeleteProjectAutomlClassificationDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagebackgroundRemovalBackgroundRemovalDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagebackgroundRemovalBackgroundRemovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagebackgroundRemovalResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagedeepfakeDetectionDeepfakeDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagedeepfakeDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageembeddingsEmbeddingsDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.EmbeddingDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageembeddingsEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageembeddingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageexplicitContentExplicitContentDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ExplicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageexplicitContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceCompareFaceCompareDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FaceMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceCompareFaceCompareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceCompareResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceDetectionFaceDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FaceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceDetectionFaceDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceRecognitionFaceRecognitionAddFaceDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceRecognitionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceRecognitionaddFaceFaceRecognitionAddFaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceRecognitiondeleteFaceFaceRecognitionDeleteFaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagefaceRecognitionrecognizeFaceRecognitionDetectFaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagegenerationGenerationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.GeneratedImageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagegenerationGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagegenerationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagelandmarkDetectionLandmarkDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LandmarkItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagelandmarkDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagelogoDetectionLogoDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LogoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagelogoDetectionLogoDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagelogoDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageobjectDetectionObjectDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ObjectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageobjectDetectionObjectDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageobjectDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagequestionAnswerQuestionAnswerDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagequestionAnswerQuestionAnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagequestionAnswerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagesearchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagesearchSearchDeleteImageDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagesearchdeleteImageDeleteImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagesearchlaunchSimilaritySearchImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImagesearchuploadImageUploadImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.LlmchatllmchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.MultimodalchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcranonymizationAsyncAnonymizationAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrbankCheckParsingBankCheckParsingDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ItemBankCheckParsingDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrbankCheckParsingBankCheckParsingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrbankCheckParsingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrcustomDocumentParsingAsyncCustomDocumentParsingAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.CustomDocumentParsingAsyncItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrdataExtractionDataExtractionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ItemDataExtraction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrdataExtractionDataExtractionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrdataExtractionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserFinancialParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.FinancialParserObjectDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserFinancialParserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrfinancialParserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcridentityParserIdentityParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.InfosIdentityParserDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcridentityParserIdentityParserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcridentityParserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrOcrDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.BoundingBox2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrOcrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrAsyncOcrAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrocrTablesAsyncOcrTablesAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrresumeParserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrresumeParserResumeParserDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OcrresumeParserResumeParserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextaiDetectionAiDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AiDetectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextaiDetectionAiDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextaiDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextanonymizationAnonymizationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AnonymizationEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextanonymizationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ChatToolResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatChatStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextchatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextcodeGenerationCodeGenerationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextcodeGenerationCodeGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextcodeGenerationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextembeddingsEmbeddingsDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextembeddingsEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextembeddingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextemotionDetectionEmotionDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.EmotionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextemotionDetectionEmotionDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextemotionDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextentitySentimentEntitySentimentDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextentitySentimentEntitySentimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextentitySentimentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextkeywordExtractionKeywordExtractionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.InfosKeywordExtractionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextkeywordExtractionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextmoderationModerationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.TextModerationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextmoderationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextnamedEntityRecognitionNamedEntityRecognitionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.InfosNamedEntityRecognitionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextnamedEntityRecognitionResponseModel))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsyntaxAnalysistextsentimentAnalysisTextAnalysisRequest), TypeInfoPropertyName = "TexttopicExtractiontextanonymizationtextmoderationtextnamedEntityRecognitiontextkeywordExtractiontextsy_2d9618c64ac15db3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextplagiaDetectionPlagiaDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PlagiaDetectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextplagiaDetectionPlagiaDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextplagiaDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextpromptOptimizationPromptOptimizationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.PromptDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextpromptOptimizationPromptOptimizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextpromptOptimizationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextsentimentAnalysisResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextsentimentAnalysisSentimentAnalysisDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.SegmentSentimentAnalysisDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextspellCheckResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextspellCheckSpellCheckDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.SpellCheckItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextspellCheckSpellCheckRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextsummarizeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextsummarizeSummarizeDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TextsummarizeSummarizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TexttopicExtractionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TexttopicExtractionTopicExtractionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ExtractedTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationautomaticTranslationAutomaticTranslationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationautomaticTranslationAutomaticTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationautomaticTranslationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationdocumentTranslationDocumentTranslationDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationdocumentTranslationDocumentTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationdocumentTranslationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationlanguageDetectionLanguageDetectionDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.InfosLanguageDetectionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationlanguageDetectionLanguageDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TranslationlanguageDetectionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideodeepfakeDetectionAsyncDeepfakeDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.DetailPerFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoexplicitContentDetectionAsyncExplicitContentDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ContentNSFW>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideofaceDetectionAsyncFaceDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideogenerationAsyncGenerationAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideolabelDetectionAsyncLabelDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideologoDetectionAsyncLogoDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.LogoTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoobjectTrackingAsyncObjectTrackingAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ObjectTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideopersonTrackingAsyncPersonTrackingAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoTrackingPerson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoquestionAnswerQuestionAnswerDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoquestionAnswerQuestionAnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoquestionAnswerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoquestionAnswerAsyncQuestionAnswerAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideoshotChangeDetectionAsyncShotChangeDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ShotFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.VideotextDetectionAsyncTextDetectionAsyncDataClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.VideoText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FeatureBatchRetrieveStatus), TypeInfoPropertyName = "FeatureBatchRetrieveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy), TypeInfoPropertyName = "CostManagementCostManagementRetrieveGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AIProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.AiProductFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.BatchList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ProviderSubfeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.ResourceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.CustomTokensList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::EdenAI.Workflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ProjectTypeEnum?), TypeInfoPropertyName = "NullableProjectTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DataTypeEnum?), TypeInfoPropertyName = "NullableDataTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfStatus889EnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status889Enum?), TypeInfoPropertyName = "NullableStatus889Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CategoryType?), TypeInfoPropertyName = "NullableCategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SubCategoryType?), TypeInfoPropertyName = "NullableSubCategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DbProviderEnum?), TypeInfoPropertyName = "NullableDbProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EmbeddingsProviderEnum?), TypeInfoPropertyName = "NullableEmbeddingsProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.StateEnum?), TypeInfoPropertyName = "NullableStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TypeOfDataEnum?), TypeInfoPropertyName = "NullableTypeOfDataEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BalanceResetPeriodEnum?), TypeInfoPropertyName = "NullableBalanceResetPeriodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.BlankEnum?), TypeInfoPropertyName = "NullableBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ChatRole?), TypeInfoPropertyName = "NullableChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TokenTypeEnum?), TypeInfoPropertyName = "NullableTokenTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PredictionB20Enum?), TypeInfoPropertyName = "NullablePredictionB20Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DetailTypeEnum?), TypeInfoPropertyName = "NullableDetailTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.DocumentTypeEnum?), TypeInfoPropertyName = "NullableDocumentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.EntitySentimentEnum?), TypeInfoPropertyName = "NullableEntitySentimentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ExecutionContentCreateStatusEnum?), TypeInfoPropertyName = "NullableExecutionContentCreateStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FallbackTypeEnum?), TypeInfoPropertyName = "NullableFallbackTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FinalStatusEnum?), TypeInfoPropertyName = "NullableFinalStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.GeneralSentimentEnum?), TypeInfoPropertyName = "NullableGeneralSentimentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ServiceTierEnum?), TypeInfoPropertyName = "NullableServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum?), TypeInfoPropertyName = "NullableImageaiDetectionAiDetectionDataClassPredictionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OptionEnum?), TypeInfoPropertyName = "NullableOptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.TypeDe8Enum?), TypeInfoPropertyName = "NullableTypeDe8Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.PriceUnitTypeEnum?), TypeInfoPropertyName = "NullablePriceUnitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfDetailTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.RepresentationEnum?), TypeInfoPropertyName = "NullableRepresentationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.SentimentEbfEnum?), TypeInfoPropertyName = "NullableSentimentEbfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.Status549Enum?), TypeInfoPropertyName = "NullableStatus549Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.OneOf<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>?), TypeInfoPropertyName = "NullableOneOfOptionEnumBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ThinkingTypeEnum?), TypeInfoPropertyName = "NullableThinkingTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.FeatureBatchRetrieveStatus?), TypeInfoPropertyName = "NullableFeatureBatchRetrieveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy?), TypeInfoPropertyName = "NullableCostManagementCostManagementRetrieveGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AutomlClassificationProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.BatchLaunchFailedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatAvailableToolsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatToolCallsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.TokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FaceHairColor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialBarcode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.MetadataRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ItemIdentityParserDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LandmarkVertice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LandmarkLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AsyncJobList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LogoVertice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoLogo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ObjectFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Line>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.BatchResponseRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ExecutionList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PromptCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PromptHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.UpperCloth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LowerCloth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PlagiaDetectionCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PricingSerialzier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ProviderSubfeatureLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AssetList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ResumeEducationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ResumeLang>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ResumeSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ResumeWorkExpEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.SpeechDiarizationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.SuggestionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoLabelTimeStamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoLabelBoundingBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoTextFrames>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PersonTracking>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.YodaQueryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AnonymizationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.EmbeddingDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ExplicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FaceMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FaceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.GeneratedImageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LandmarkItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LogoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ObjectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessageDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ItemBankCheckParsingDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.CustomDocumentParsingAsyncItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ItemDataExtraction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.FinancialParserObjectDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.InfosIdentityParserDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.BoundingBox2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AiDetectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AnonymizationEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ChatToolResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.EmotionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.InfosKeywordExtractionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.TextModerationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.InfosNamedEntityRecognitionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PlagiaDetectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.PromptDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.SegmentSentimentAnalysisDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.SpellCheckItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ExtractedTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.InfosLanguageDetectionDataClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.DetailPerFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ContentNSFW>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.LogoTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ObjectTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoTrackingPerson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ShotFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.VideoText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AIProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.AiProductFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.BatchList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ProviderSubfeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.ResourceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.CustomTokensList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::EdenAI.Workflow>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.Status889Enum?, global::EdenAI.NullEnum?>());
            options.Converters.Add(new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.DetailTypeEnum?, global::EdenAI.BlankEnum?, global::EdenAI.NullEnum?>());
            options.Converters.Add(new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>());
            options.Converters.Add(new global::EdenAI.JsonConverters.OneOfJsonConverter<global::EdenAI.OptionEnum?, global::EdenAI.BlankEnum?>());
            options.Converters.Add(new global::EdenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::EdenAI.BalanceResetPeriodEnum)

                    || typeToConvert == typeof(global::EdenAI.BalanceResetPeriodEnum?)

                    || typeToConvert == typeof(global::EdenAI.BlankEnum)

                    || typeToConvert == typeof(global::EdenAI.BlankEnum?)

                    || typeToConvert == typeof(global::EdenAI.CategoryType)

                    || typeToConvert == typeof(global::EdenAI.CategoryType?)

                    || typeToConvert == typeof(global::EdenAI.ChatRole)

                    || typeToConvert == typeof(global::EdenAI.ChatRole?)

                    || typeToConvert == typeof(global::EdenAI.DataTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.DataTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.DbProviderEnum)

                    || typeToConvert == typeof(global::EdenAI.DbProviderEnum?)

                    || typeToConvert == typeof(global::EdenAI.DetailTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.DetailTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.DocumentTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.DocumentTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.EmbeddingsProviderEnum)

                    || typeToConvert == typeof(global::EdenAI.EmbeddingsProviderEnum?)

                    || typeToConvert == typeof(global::EdenAI.EntitySentimentEnum)

                    || typeToConvert == typeof(global::EdenAI.EntitySentimentEnum?)

                    || typeToConvert == typeof(global::EdenAI.ExecutionContentCreateStatusEnum)

                    || typeToConvert == typeof(global::EdenAI.ExecutionContentCreateStatusEnum?)

                    || typeToConvert == typeof(global::EdenAI.FallbackTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.FallbackTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.FinalStatusEnum)

                    || typeToConvert == typeof(global::EdenAI.FinalStatusEnum?)

                    || typeToConvert == typeof(global::EdenAI.GeneralSentimentEnum)

                    || typeToConvert == typeof(global::EdenAI.GeneralSentimentEnum?)

                    || typeToConvert == typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum)

                    || typeToConvert == typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum?)

                    || typeToConvert == typeof(global::EdenAI.NullEnum)

                    || typeToConvert == typeof(global::EdenAI.NullEnum?)

                    || typeToConvert == typeof(global::EdenAI.OptionEnum)

                    || typeToConvert == typeof(global::EdenAI.OptionEnum?)

                    || typeToConvert == typeof(global::EdenAI.PredictionB20Enum)

                    || typeToConvert == typeof(global::EdenAI.PredictionB20Enum?)

                    || typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.ProjectTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.ProjectTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::EdenAI.RepresentationEnum)

                    || typeToConvert == typeof(global::EdenAI.RepresentationEnum?)

                    || typeToConvert == typeof(global::EdenAI.SentimentEbfEnum)

                    || typeToConvert == typeof(global::EdenAI.SentimentEbfEnum?)

                    || typeToConvert == typeof(global::EdenAI.ServiceTierEnum)

                    || typeToConvert == typeof(global::EdenAI.ServiceTierEnum?)

                    || typeToConvert == typeof(global::EdenAI.StateEnum)

                    || typeToConvert == typeof(global::EdenAI.StateEnum?)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum)

                    || typeToConvert == typeof(global::EdenAI.Status549Enum?)

                    || typeToConvert == typeof(global::EdenAI.Status889Enum)

                    || typeToConvert == typeof(global::EdenAI.Status889Enum?)

                    || typeToConvert == typeof(global::EdenAI.SubCategoryType)

                    || typeToConvert == typeof(global::EdenAI.SubCategoryType?)

                    || typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.TokenTypeEnum)

                    || typeToConvert == typeof(global::EdenAI.TokenTypeEnum?)

                    || typeToConvert == typeof(global::EdenAI.ToolChoiceEnum)

                    || typeToConvert == typeof(global::EdenAI.ToolChoiceEnum?)

                    || typeToConvert == typeof(global::EdenAI.TypeDe8Enum)

                    || typeToConvert == typeof(global::EdenAI.TypeDe8Enum?)

                    || typeToConvert == typeof(global::EdenAI.TypeOfDataEnum)

                    || typeToConvert == typeof(global::EdenAI.TypeOfDataEnum?)

                    || typeToConvert == typeof(global::EdenAI.FeatureBatchRetrieveStatus)

                    || typeToConvert == typeof(global::EdenAI.FeatureBatchRetrieveStatus?)

                    || typeToConvert == typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy)

                    || typeToConvert == typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::EdenAI.BalanceResetPeriodEnum))
                {
                    return new global::EdenAI.JsonConverters.BalanceResetPeriodEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.BalanceResetPeriodEnum?))
                {
                    return new global::EdenAI.JsonConverters.BalanceResetPeriodEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.BlankEnum))
                {
                    return new global::EdenAI.JsonConverters.BlankEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.BlankEnum?))
                {
                    return new global::EdenAI.JsonConverters.BlankEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.CategoryType))
                {
                    return new global::EdenAI.JsonConverters.CategoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.CategoryType?))
                {
                    return new global::EdenAI.JsonConverters.CategoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ChatRole))
                {
                    return new global::EdenAI.JsonConverters.ChatRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ChatRole?))
                {
                    return new global::EdenAI.JsonConverters.ChatRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DataTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.DataTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DataTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.DataTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DbProviderEnum))
                {
                    return new global::EdenAI.JsonConverters.DbProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DbProviderEnum?))
                {
                    return new global::EdenAI.JsonConverters.DbProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DetailTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.DetailTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DetailTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.DetailTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DocumentTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.DocumentTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.DocumentTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.DocumentTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.EmbeddingsProviderEnum))
                {
                    return new global::EdenAI.JsonConverters.EmbeddingsProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.EmbeddingsProviderEnum?))
                {
                    return new global::EdenAI.JsonConverters.EmbeddingsProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.EntitySentimentEnum))
                {
                    return new global::EdenAI.JsonConverters.EntitySentimentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.EntitySentimentEnum?))
                {
                    return new global::EdenAI.JsonConverters.EntitySentimentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ExecutionContentCreateStatusEnum))
                {
                    return new global::EdenAI.JsonConverters.ExecutionContentCreateStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ExecutionContentCreateStatusEnum?))
                {
                    return new global::EdenAI.JsonConverters.ExecutionContentCreateStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FallbackTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.FallbackTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FallbackTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.FallbackTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FinalStatusEnum))
                {
                    return new global::EdenAI.JsonConverters.FinalStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FinalStatusEnum?))
                {
                    return new global::EdenAI.JsonConverters.FinalStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.GeneralSentimentEnum))
                {
                    return new global::EdenAI.JsonConverters.GeneralSentimentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.GeneralSentimentEnum?))
                {
                    return new global::EdenAI.JsonConverters.GeneralSentimentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum))
                {
                    return new global::EdenAI.JsonConverters.ImageaiDetectionAiDetectionDataClassPredictionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ImageaiDetectionAiDetectionDataClassPredictionEnum?))
                {
                    return new global::EdenAI.JsonConverters.ImageaiDetectionAiDetectionDataClassPredictionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.NullEnum))
                {
                    return new global::EdenAI.JsonConverters.NullEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.NullEnum?))
                {
                    return new global::EdenAI.JsonConverters.NullEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.OptionEnum))
                {
                    return new global::EdenAI.JsonConverters.OptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.OptionEnum?))
                {
                    return new global::EdenAI.JsonConverters.OptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PredictionB20Enum))
                {
                    return new global::EdenAI.JsonConverters.PredictionB20EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PredictionB20Enum?))
                {
                    return new global::EdenAI.JsonConverters.PredictionB20EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.PriceUnitTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.PriceUnitTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.PriceUnitTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ProjectTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.ProjectTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ProjectTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.ProjectTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum))
                {
                    return new global::EdenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ReasoningEffortEnum?))
                {
                    return new global::EdenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.RepresentationEnum))
                {
                    return new global::EdenAI.JsonConverters.RepresentationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.RepresentationEnum?))
                {
                    return new global::EdenAI.JsonConverters.RepresentationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.SentimentEbfEnum))
                {
                    return new global::EdenAI.JsonConverters.SentimentEbfEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.SentimentEbfEnum?))
                {
                    return new global::EdenAI.JsonConverters.SentimentEbfEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ServiceTierEnum))
                {
                    return new global::EdenAI.JsonConverters.ServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ServiceTierEnum?))
                {
                    return new global::EdenAI.JsonConverters.ServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.StateEnum))
                {
                    return new global::EdenAI.JsonConverters.StateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.StateEnum?))
                {
                    return new global::EdenAI.JsonConverters.StateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status549Enum?))
                {
                    return new global::EdenAI.JsonConverters.Status549EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status889Enum))
                {
                    return new global::EdenAI.JsonConverters.Status889EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.Status889Enum?))
                {
                    return new global::EdenAI.JsonConverters.Status889EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.SubCategoryType))
                {
                    return new global::EdenAI.JsonConverters.SubCategoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.SubCategoryType?))
                {
                    return new global::EdenAI.JsonConverters.SubCategoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.ThinkingTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ThinkingTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.ThinkingTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TokenTypeEnum))
                {
                    return new global::EdenAI.JsonConverters.TokenTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TokenTypeEnum?))
                {
                    return new global::EdenAI.JsonConverters.TokenTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ToolChoiceEnum))
                {
                    return new global::EdenAI.JsonConverters.ToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.ToolChoiceEnum?))
                {
                    return new global::EdenAI.JsonConverters.ToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TypeDe8Enum))
                {
                    return new global::EdenAI.JsonConverters.TypeDe8EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TypeDe8Enum?))
                {
                    return new global::EdenAI.JsonConverters.TypeDe8EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TypeOfDataEnum))
                {
                    return new global::EdenAI.JsonConverters.TypeOfDataEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.TypeOfDataEnum?))
                {
                    return new global::EdenAI.JsonConverters.TypeOfDataEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FeatureBatchRetrieveStatus))
                {
                    return new global::EdenAI.JsonConverters.FeatureBatchRetrieveStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.FeatureBatchRetrieveStatus?))
                {
                    return new global::EdenAI.JsonConverters.FeatureBatchRetrieveStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy))
                {
                    return new global::EdenAI.JsonConverters.CostManagementCostManagementRetrieveGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::EdenAI.CostManagementCostManagementRetrieveGroupBy?))
                {
                    return new global::EdenAI.JsonConverters.CostManagementCostManagementRetrieveGroupByNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}