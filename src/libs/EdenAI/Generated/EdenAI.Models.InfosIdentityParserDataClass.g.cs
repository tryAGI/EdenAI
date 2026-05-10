
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfosIdentityParserDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("given_names")]
        public global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? GivenNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("birth_place")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass BirthPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("birth_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass BirthDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuance_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass IssuanceDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass ExpireDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuing_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass IssuingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.Country Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass DocumentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_signature")]
        public global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? ImageSignature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mrz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass Mrz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nationality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::EdenAI.ItemIdentityParserDataClass Nationality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosIdentityParserDataClass" /> class.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="birthPlace"></param>
        /// <param name="birthDate"></param>
        /// <param name="issuanceDate"></param>
        /// <param name="expireDate"></param>
        /// <param name="documentId"></param>
        /// <param name="issuingState"></param>
        /// <param name="address"></param>
        /// <param name="age"></param>
        /// <param name="country"></param>
        /// <param name="documentType"></param>
        /// <param name="gender"></param>
        /// <param name="mrz"></param>
        /// <param name="nationality"></param>
        /// <param name="givenNames"></param>
        /// <param name="imageId"></param>
        /// <param name="imageSignature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfosIdentityParserDataClass(
            global::EdenAI.ItemIdentityParserDataClass lastName,
            global::EdenAI.ItemIdentityParserDataClass birthPlace,
            global::EdenAI.ItemIdentityParserDataClass birthDate,
            global::EdenAI.ItemIdentityParserDataClass issuanceDate,
            global::EdenAI.ItemIdentityParserDataClass expireDate,
            global::EdenAI.ItemIdentityParserDataClass documentId,
            global::EdenAI.ItemIdentityParserDataClass issuingState,
            global::EdenAI.ItemIdentityParserDataClass address,
            global::EdenAI.ItemIdentityParserDataClass age,
            global::EdenAI.Country country,
            global::EdenAI.ItemIdentityParserDataClass documentType,
            global::EdenAI.ItemIdentityParserDataClass gender,
            global::EdenAI.ItemIdentityParserDataClass mrz,
            global::EdenAI.ItemIdentityParserDataClass nationality,
            global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? givenNames,
            global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? imageId,
            global::System.Collections.Generic.IList<global::EdenAI.ItemIdentityParserDataClass>? imageSignature)
        {
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.GivenNames = givenNames;
            this.BirthPlace = birthPlace ?? throw new global::System.ArgumentNullException(nameof(birthPlace));
            this.BirthDate = birthDate ?? throw new global::System.ArgumentNullException(nameof(birthDate));
            this.IssuanceDate = issuanceDate ?? throw new global::System.ArgumentNullException(nameof(issuanceDate));
            this.ExpireDate = expireDate ?? throw new global::System.ArgumentNullException(nameof(expireDate));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.IssuingState = issuingState ?? throw new global::System.ArgumentNullException(nameof(issuingState));
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Age = age ?? throw new global::System.ArgumentNullException(nameof(age));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.DocumentType = documentType ?? throw new global::System.ArgumentNullException(nameof(documentType));
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.ImageId = imageId;
            this.ImageSignature = imageSignature;
            this.Mrz = mrz ?? throw new global::System.ArgumentNullException(nameof(mrz));
            this.Nationality = nationality ?? throw new global::System.ArgumentNullException(nameof(nationality));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfosIdentityParserDataClass" /> class.
        /// </summary>
        public InfosIdentityParserDataClass()
        {
        }

    }
}