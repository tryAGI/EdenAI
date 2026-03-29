
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinancialCustomerInformation
    {
        /// <summary>
        /// The name of the invoiced customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique reference ID for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_reference")]
        public string? IdReference { get; set; }

        /// <summary>
        /// The mailing address of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mailling_address")]
        public string? MaillingAddress { get; set; }

        /// <summary>
        /// The explicit billing address for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_address")]
        public string? BillingAddress { get; set; }

        /// <summary>
        /// The shipping address for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shipping_address")]
        public string? ShippingAddress { get; set; }

        /// <summary>
        /// The service address associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_address")]
        public string? ServiceAddress { get; set; }

        /// <summary>
        /// The address to which payments should be remitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remittance_address")]
        public string? RemittanceAddress { get; set; }

        /// <summary>
        /// The email address of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The phone number associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// VAT (Value Added Tax) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vat_number")]
        public string? VatNumber { get; set; }

        /// <summary>
        /// ABN (Australian Business Number) of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abn_number")]
        public string? AbnNumber { get; set; }

        /// <summary>
        /// GST (Goods and Services Tax) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gst_number")]
        public string? GstNumber { get; set; }

        /// <summary>
        /// PAN (Permanent Account Number) of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pan_number")]
        public string? PanNumber { get; set; }

        /// <summary>
        /// Business registration number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_number")]
        public string? BusinessNumber { get; set; }

        /// <summary>
        /// SIRET (Système d'Identification du Répertoire des Entreprises et de leurs Établissements) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siret_number")]
        public string? SiretNumber { get; set; }

        /// <summary>
        /// SIREN (Système d'Identification du Répertoire des Entreprises) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siren_number")]
        public string? SirenNumber { get; set; }

        /// <summary>
        /// Customer identification number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_number")]
        public string? CustomerNumber { get; set; }

        /// <summary>
        /// Chamber of Commerce registration number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coc_number")]
        public string? CocNumber { get; set; }

        /// <summary>
        /// Fiscal identification number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiscal_number")]
        public string? FiscalNumber { get; set; }

        /// <summary>
        /// Official registration number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_number")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// Tax identification number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public string? TaxId { get; set; }

        /// <summary>
        /// The website associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// The name associated with the customer's remittance address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remit_to_name")]
        public string? RemitToName { get; set; }

        /// <summary>
        /// The city associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The country associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The house number associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("house_number")]
        public string? HouseNumber { get; set; }

        /// <summary>
        /// The province associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("province")]
        public string? Province { get; set; }

        /// <summary>
        /// The street name associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("street_name")]
        public string? StreetName { get; set; }

        /// <summary>
        /// The ZIP code associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip_code")]
        public string? ZipCode { get; set; }

        /// <summary>
        /// The municipality associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("municipality")]
        public string? Municipality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialCustomerInformation" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the invoiced customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="idReference">
        /// Unique reference ID for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maillingAddress">
        /// The mailing address of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="billingAddress">
        /// The explicit billing address for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shippingAddress">
        /// The shipping address for the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceAddress">
        /// The service address associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="remittanceAddress">
        /// The address to which payments should be remitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="email">
        /// The email address of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="phone">
        /// The phone number associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="vatNumber">
        /// VAT (Value Added Tax) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="abnNumber">
        /// ABN (Australian Business Number) of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gstNumber">
        /// GST (Goods and Services Tax) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="panNumber">
        /// PAN (Permanent Account Number) of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="businessNumber">
        /// Business registration number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="siretNumber">
        /// SIRET (Système d'Identification du Répertoire des Entreprises et de leurs Établissements) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sirenNumber">
        /// SIREN (Système d'Identification du Répertoire des Entreprises) number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="customerNumber">
        /// Customer identification number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cocNumber">
        /// Chamber of Commerce registration number.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fiscalNumber">
        /// Fiscal identification number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="registrationNumber">
        /// Official registration number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="taxId">
        /// Tax identification number of the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="website">
        /// The website associated with the customer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="remitToName">
        /// The name associated with the customer's remittance address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="city">
        /// The city associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="country">
        /// The country associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="houseNumber">
        /// The house number associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="province">
        /// The province associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="streetName">
        /// The street name associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="zipCode">
        /// The ZIP code associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="municipality">
        /// The municipality associated with the customer's address.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinancialCustomerInformation(
            string? name,
            string? idReference,
            string? maillingAddress,
            string? billingAddress,
            string? shippingAddress,
            string? serviceAddress,
            string? remittanceAddress,
            string? email,
            string? phone,
            string? vatNumber,
            string? abnNumber,
            string? gstNumber,
            string? panNumber,
            string? businessNumber,
            string? siretNumber,
            string? sirenNumber,
            string? customerNumber,
            string? cocNumber,
            string? fiscalNumber,
            string? registrationNumber,
            string? taxId,
            string? website,
            string? remitToName,
            string? city,
            string? country,
            string? houseNumber,
            string? province,
            string? streetName,
            string? zipCode,
            string? municipality)
        {
            this.Name = name;
            this.IdReference = idReference;
            this.MaillingAddress = maillingAddress;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.ServiceAddress = serviceAddress;
            this.RemittanceAddress = remittanceAddress;
            this.Email = email;
            this.Phone = phone;
            this.VatNumber = vatNumber;
            this.AbnNumber = abnNumber;
            this.GstNumber = gstNumber;
            this.PanNumber = panNumber;
            this.BusinessNumber = businessNumber;
            this.SiretNumber = siretNumber;
            this.SirenNumber = sirenNumber;
            this.CustomerNumber = customerNumber;
            this.CocNumber = cocNumber;
            this.FiscalNumber = fiscalNumber;
            this.RegistrationNumber = registrationNumber;
            this.TaxId = taxId;
            this.Website = website;
            this.RemitToName = remitToName;
            this.City = city;
            this.Country = country;
            this.HouseNumber = houseNumber;
            this.Province = province;
            this.StreetName = streetName;
            this.ZipCode = zipCode;
            this.Municipality = municipality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialCustomerInformation" /> class.
        /// </summary>
        public FinancialCustomerInformation()
        {
        }
    }
}