using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmployeePayrollRunsRetrieveRequestExpandItem>))]
public readonly record struct EmployeePayrollRunsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly EmployeePayrollRunsRetrieveRequestExpandItem Employee = new(
        Values.Employee
    );

    public static readonly EmployeePayrollRunsRetrieveRequestExpandItem PayrollRun = new(
        Values.PayrollRun
    );

    public EmployeePayrollRunsRetrieveRequestExpandItem(string value)
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
    public static EmployeePayrollRunsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new EmployeePayrollRunsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(
        EmployeePayrollRunsRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EmployeePayrollRunsRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EmployeePayrollRunsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator EmployeePayrollRunsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Employee = "employee";

        public const string PayrollRun = "payroll_run";
    }
}
