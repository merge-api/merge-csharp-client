using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmployeesListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct EmployeesListRequestShowEnumOrigins : IStringEnum
{
    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatus = new(
        Values.EmploymentStatus
    );

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusEthnicity = new(
        Values.EmploymentStatusEthnicity
    );

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusEthnicityGender =
        new(Values.EmploymentStatusEthnicityGender);

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusEthnicityGenderMaritalStatus =
        new(Values.EmploymentStatusEthnicityGenderMaritalStatus);

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusEthnicityMaritalStatus =
        new(Values.EmploymentStatusEthnicityMaritalStatus);

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusGender = new(
        Values.EmploymentStatusGender
    );

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusGenderMaritalStatus =
        new(Values.EmploymentStatusGenderMaritalStatus);

    public static readonly EmployeesListRequestShowEnumOrigins EmploymentStatusMaritalStatus = new(
        Values.EmploymentStatusMaritalStatus
    );

    public static readonly EmployeesListRequestShowEnumOrigins Ethnicity = new(Values.Ethnicity);

    public static readonly EmployeesListRequestShowEnumOrigins EthnicityGender = new(
        Values.EthnicityGender
    );

    public static readonly EmployeesListRequestShowEnumOrigins EthnicityGenderMaritalStatus = new(
        Values.EthnicityGenderMaritalStatus
    );

    public static readonly EmployeesListRequestShowEnumOrigins EthnicityMaritalStatus = new(
        Values.EthnicityMaritalStatus
    );

    public static readonly EmployeesListRequestShowEnumOrigins Gender = new(Values.Gender);

    public static readonly EmployeesListRequestShowEnumOrigins GenderMaritalStatus = new(
        Values.GenderMaritalStatus
    );

    public static readonly EmployeesListRequestShowEnumOrigins MaritalStatus = new(
        Values.MaritalStatus
    );

    public EmployeesListRequestShowEnumOrigins(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static EmployeesListRequestShowEnumOrigins FromCustom(string value)
    {
        return new EmployeesListRequestShowEnumOrigins(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(EmployeesListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator EmployeesListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EmploymentStatus = "employment_status";

        public const string EmploymentStatusEthnicity = "employment_status,ethnicity";

        public const string EmploymentStatusEthnicityGender = "employment_status,ethnicity,gender";

        public const string EmploymentStatusEthnicityGenderMaritalStatus =
            "employment_status,ethnicity,gender,marital_status";

        public const string EmploymentStatusEthnicityMaritalStatus =
            "employment_status,ethnicity,marital_status";

        public const string EmploymentStatusGender = "employment_status,gender";

        public const string EmploymentStatusGenderMaritalStatus =
            "employment_status,gender,marital_status";

        public const string EmploymentStatusMaritalStatus = "employment_status,marital_status";

        public const string Ethnicity = "ethnicity";

        public const string EthnicityGender = "ethnicity,gender";

        public const string EthnicityGenderMaritalStatus = "ethnicity,gender,marital_status";

        public const string EthnicityMaritalStatus = "ethnicity,marital_status";

        public const string Gender = "gender";

        public const string GenderMaritalStatus = "gender,marital_status";

        public const string MaritalStatus = "marital_status";
    }
}
