
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubCategoryType
    {
        /// <summary>
        /// 
        /// </summary>
        AWSKeys,
        /// <summary>
        /// 
        /// </summary>
        Address,
        /// <summary>
        /// 
        /// </summary>
        Age,
        /// <summary>
        /// 
        /// </summary>
        Anonymized,
        /// <summary>
        /// 
        /// </summary>
        AzureKeys,
        /// <summary>
        /// 
        /// </summary>
        BankAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        BankRoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        BuisnessNumber,
        /// <summary>
        /// 
        /// </summary>
        CardExpiry,
        /// <summary>
        /// 
        /// </summary>
        CompanyName,
        /// <summary>
        /// 
        /// </summary>
        CompanyNumber,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateTime,
        /// <summary>
        /// 
        /// </summary>
        DriverLicenseNumber,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gender,
        /// <summary>
        /// 
        /// </summary>
        Ip,
        /// <summary>
        /// 
        /// </summary>
        LicensePlate,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        NationalHealthService,
        /// <summary>
        /// 
        /// </summary>
        NationalIdentificationNumber,
        /// <summary>
        /// 
        /// </summary>
        Nerd,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        PersonType,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        ResidentRegistrationNumber,
        /// <summary>
        /// 
        /// </summary>
        SocialSecurityNumber,
        /// <summary>
        /// 
        /// </summary>
        SwiftCode,
        /// <summary>
        /// 
        /// </summary>
        TaxIdentificationNumber,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        VehicleIdentificationNumber,
        /// <summary>
        /// 
        /// </summary>
        VoterNumber,
        /// <summary>
        /// 
        /// </summary>
        Wsd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubCategoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubCategoryType value)
        {
            return value switch
            {
                SubCategoryType.AWSKeys => "AWSKeys",
                SubCategoryType.Address => "Address",
                SubCategoryType.Age => "Age",
                SubCategoryType.Anonymized => "Anonymized",
                SubCategoryType.AzureKeys => "AzureKeys",
                SubCategoryType.BankAccountNumber => "BankAccountNumber",
                SubCategoryType.BankRoutingNumber => "BankRoutingNumber",
                SubCategoryType.BuisnessNumber => "BuisnessNumber",
                SubCategoryType.CardExpiry => "CardExpiry",
                SubCategoryType.CompanyName => "CompanyName",
                SubCategoryType.CompanyNumber => "CompanyNumber",
                SubCategoryType.CreditCard => "CreditCard",
                SubCategoryType.Date => "Date",
                SubCategoryType.DateTime => "DateTime",
                SubCategoryType.DriverLicenseNumber => "DriverLicenseNumber",
                SubCategoryType.Duration => "Duration",
                SubCategoryType.Email => "Email",
                SubCategoryType.Gender => "Gender",
                SubCategoryType.Ip => "IP",
                SubCategoryType.LicensePlate => "LicensePlate",
                SubCategoryType.Location => "Location",
                SubCategoryType.Mac => "MAC",
                SubCategoryType.Name => "Name",
                SubCategoryType.NationalHealthService => "NationalHealthService",
                SubCategoryType.NationalIdentificationNumber => "NationalIdentificationNumber",
                SubCategoryType.Nerd => "Nerd",
                SubCategoryType.Other => "Other",
                SubCategoryType.PassportNumber => "PassportNumber",
                SubCategoryType.Password => "Password",
                SubCategoryType.PersonType => "PersonType",
                SubCategoryType.Phone => "Phone",
                SubCategoryType.ResidentRegistrationNumber => "ResidentRegistrationNumber",
                SubCategoryType.SocialSecurityNumber => "SocialSecurityNumber",
                SubCategoryType.SwiftCode => "SwiftCode",
                SubCategoryType.TaxIdentificationNumber => "TaxIdentificationNumber",
                SubCategoryType.Time => "Time",
                SubCategoryType.Url => "URL",
                SubCategoryType.Unknown => "Unknown",
                SubCategoryType.VehicleIdentificationNumber => "VehicleIdentificationNumber",
                SubCategoryType.VoterNumber => "VoterNumber",
                SubCategoryType.Wsd => "Wsd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubCategoryType? ToEnum(string value)
        {
            return value switch
            {
                "AWSKeys" => SubCategoryType.AWSKeys,
                "Address" => SubCategoryType.Address,
                "Age" => SubCategoryType.Age,
                "Anonymized" => SubCategoryType.Anonymized,
                "AzureKeys" => SubCategoryType.AzureKeys,
                "BankAccountNumber" => SubCategoryType.BankAccountNumber,
                "BankRoutingNumber" => SubCategoryType.BankRoutingNumber,
                "BuisnessNumber" => SubCategoryType.BuisnessNumber,
                "CardExpiry" => SubCategoryType.CardExpiry,
                "CompanyName" => SubCategoryType.CompanyName,
                "CompanyNumber" => SubCategoryType.CompanyNumber,
                "CreditCard" => SubCategoryType.CreditCard,
                "Date" => SubCategoryType.Date,
                "DateTime" => SubCategoryType.DateTime,
                "DriverLicenseNumber" => SubCategoryType.DriverLicenseNumber,
                "Duration" => SubCategoryType.Duration,
                "Email" => SubCategoryType.Email,
                "Gender" => SubCategoryType.Gender,
                "IP" => SubCategoryType.Ip,
                "LicensePlate" => SubCategoryType.LicensePlate,
                "Location" => SubCategoryType.Location,
                "MAC" => SubCategoryType.Mac,
                "Name" => SubCategoryType.Name,
                "NationalHealthService" => SubCategoryType.NationalHealthService,
                "NationalIdentificationNumber" => SubCategoryType.NationalIdentificationNumber,
                "Nerd" => SubCategoryType.Nerd,
                "Other" => SubCategoryType.Other,
                "PassportNumber" => SubCategoryType.PassportNumber,
                "Password" => SubCategoryType.Password,
                "PersonType" => SubCategoryType.PersonType,
                "Phone" => SubCategoryType.Phone,
                "ResidentRegistrationNumber" => SubCategoryType.ResidentRegistrationNumber,
                "SocialSecurityNumber" => SubCategoryType.SocialSecurityNumber,
                "SwiftCode" => SubCategoryType.SwiftCode,
                "TaxIdentificationNumber" => SubCategoryType.TaxIdentificationNumber,
                "Time" => SubCategoryType.Time,
                "URL" => SubCategoryType.Url,
                "Unknown" => SubCategoryType.Unknown,
                "VehicleIdentificationNumber" => SubCategoryType.VehicleIdentificationNumber,
                "VoterNumber" => SubCategoryType.VoterNumber,
                "Wsd" => SubCategoryType.Wsd,
                _ => null,
            };
        }
    }
}