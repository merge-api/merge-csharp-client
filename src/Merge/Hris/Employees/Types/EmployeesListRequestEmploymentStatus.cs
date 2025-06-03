using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.Employees;

[JsonConverter(typeof(StringEnumSerializer<EmployeesListRequestEmploymentStatus>))]
public readonly record struct EmployeesListRequestEmploymentStatus : IStringEnum
{
    public static readonly EmployeesListRequestEmploymentStatus Active = new(Values.Active);

    public static readonly EmployeesListRequestEmploymentStatus Inactive = new(Values.Inactive);

    public static readonly EmployeesListRequestEmploymentStatus Pending = new(Values.Pending);

    public EmployeesListRequestEmploymentStatus(string value)
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
    public static EmployeesListRequestEmploymentStatus FromCustom(string value)
    {
        return new EmployeesListRequestEmploymentStatus(value);
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

    public static bool operator ==(EmployeesListRequestEmploymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListRequestEmploymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListRequestEmploymentStatus value) =>
        value.Value;

    public static explicit operator EmployeesListRequestEmploymentStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Inactive = "INACTIVE";

        public const string Pending = "PENDING";
    }
}
