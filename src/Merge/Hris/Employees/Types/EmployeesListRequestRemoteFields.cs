using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.Employees;

[JsonConverter(typeof(StringEnumSerializer<EmployeesListRequestRemoteFields>))]
public readonly record struct EmployeesListRequestRemoteFields : IStringEnum
{
    public static readonly EmployeesListRequestRemoteFields EmploymentStatus = new(
        Values.EmploymentStatus
    );

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusEthnicity = new(
        Values.EmploymentStatusEthnicity
    );

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusEthnicityGender = new(
        Values.EmploymentStatusEthnicityGender
    );

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusEthnicityGenderMaritalStatus =
        new(Values.EmploymentStatusEthnicityGenderMaritalStatus);

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusEthnicityMaritalStatus =
        new(Values.EmploymentStatusEthnicityMaritalStatus);

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusGender = new(
        Values.EmploymentStatusGender
    );

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusGenderMaritalStatus =
        new(Values.EmploymentStatusGenderMaritalStatus);

    public static readonly EmployeesListRequestRemoteFields EmploymentStatusMaritalStatus = new(
        Values.EmploymentStatusMaritalStatus
    );

    public static readonly EmployeesListRequestRemoteFields Ethnicity = new(Values.Ethnicity);

    public static readonly EmployeesListRequestRemoteFields EthnicityGender = new(
        Values.EthnicityGender
    );

    public static readonly EmployeesListRequestRemoteFields EthnicityGenderMaritalStatus = new(
        Values.EthnicityGenderMaritalStatus
    );

    public static readonly EmployeesListRequestRemoteFields EthnicityMaritalStatus = new(
        Values.EthnicityMaritalStatus
    );

    public static readonly EmployeesListRequestRemoteFields Gender = new(Values.Gender);

    public static readonly EmployeesListRequestRemoteFields GenderMaritalStatus = new(
        Values.GenderMaritalStatus
    );

    public static readonly EmployeesListRequestRemoteFields MaritalStatus = new(
        Values.MaritalStatus
    );

    public EmployeesListRequestRemoteFields(string value)
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
    public static EmployeesListRequestRemoteFields FromCustom(string value)
    {
        return new EmployeesListRequestRemoteFields(value);
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

    public static bool operator ==(EmployeesListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListRequestRemoteFields value) => value.Value;

    public static explicit operator EmployeesListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
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
