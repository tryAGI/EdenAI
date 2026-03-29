
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landmarks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceLandmarks Landmarks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceEmotions Emotions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FacePoses Poses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hair")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceHair Hair { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facial_hair")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceFacialHair FacialHair { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("makeup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceMakeup Makeup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceAccessories Accessories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occlusions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceOcclusions Occlusions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.FaceFeatures Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceItem" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="landmarks"></param>
        /// <param name="emotions"></param>
        /// <param name="poses"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="boundingBox"></param>
        /// <param name="hair"></param>
        /// <param name="facialHair"></param>
        /// <param name="quality"></param>
        /// <param name="makeup"></param>
        /// <param name="accessories"></param>
        /// <param name="occlusions"></param>
        /// <param name="features"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceItem(
            int confidence,
            global::EdenAI.FaceLandmarks landmarks,
            global::EdenAI.FaceEmotions emotions,
            global::EdenAI.FacePoses poses,
            int age,
            string gender,
            global::EdenAI.FaceBoundingBox boundingBox,
            global::EdenAI.FaceHair hair,
            global::EdenAI.FaceFacialHair facialHair,
            global::EdenAI.FaceQuality quality,
            global::EdenAI.FaceMakeup makeup,
            global::EdenAI.FaceAccessories accessories,
            global::EdenAI.FaceOcclusions occlusions,
            global::EdenAI.FaceFeatures features)
        {
            this.Confidence = confidence;
            this.Landmarks = landmarks ?? throw new global::System.ArgumentNullException(nameof(landmarks));
            this.Emotions = emotions ?? throw new global::System.ArgumentNullException(nameof(emotions));
            this.Poses = poses ?? throw new global::System.ArgumentNullException(nameof(poses));
            this.Age = age;
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.Hair = hair ?? throw new global::System.ArgumentNullException(nameof(hair));
            this.FacialHair = facialHair ?? throw new global::System.ArgumentNullException(nameof(facialHair));
            this.Quality = quality ?? throw new global::System.ArgumentNullException(nameof(quality));
            this.Makeup = makeup ?? throw new global::System.ArgumentNullException(nameof(makeup));
            this.Accessories = accessories ?? throw new global::System.ArgumentNullException(nameof(accessories));
            this.Occlusions = occlusions ?? throw new global::System.ArgumentNullException(nameof(occlusions));
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceItem" /> class.
        /// </summary>
        public FaceItem()
        {
        }
    }
}