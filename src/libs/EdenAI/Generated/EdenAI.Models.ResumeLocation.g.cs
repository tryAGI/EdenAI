
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumeLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FormattedLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_input_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawInputLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("street")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Street { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("street_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreetNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appartment_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppartmentNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string City { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeLocation" /> class.
        /// </summary>
        /// <param name="formattedLocation"></param>
        /// <param name="postalCode"></param>
        /// <param name="region"></param>
        /// <param name="country"></param>
        /// <param name="countryCode"></param>
        /// <param name="rawInputLocation"></param>
        /// <param name="street"></param>
        /// <param name="streetNumber"></param>
        /// <param name="appartmentNumber"></param>
        /// <param name="city"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeLocation(
            string formattedLocation,
            string postalCode,
            string region,
            string country,
            string countryCode,
            string rawInputLocation,
            string street,
            string streetNumber,
            string appartmentNumber,
            string city)
        {
            this.FormattedLocation = formattedLocation ?? throw new global::System.ArgumentNullException(nameof(formattedLocation));
            this.PostalCode = postalCode ?? throw new global::System.ArgumentNullException(nameof(postalCode));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
            this.RawInputLocation = rawInputLocation ?? throw new global::System.ArgumentNullException(nameof(rawInputLocation));
            this.Street = street ?? throw new global::System.ArgumentNullException(nameof(street));
            this.StreetNumber = streetNumber ?? throw new global::System.ArgumentNullException(nameof(streetNumber));
            this.AppartmentNumber = appartmentNumber ?? throw new global::System.ArgumentNullException(nameof(appartmentNumber));
            this.City = city ?? throw new global::System.ArgumentNullException(nameof(city));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeLocation" /> class.
        /// </summary>
        public ResumeLocation()
        {
        }

    }
}