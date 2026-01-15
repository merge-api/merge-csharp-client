using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<EmployeesListRequestExpandItem>))]
[Serializable]
public readonly record struct EmployeesListRequestExpandItem : IStringEnum
{
    public static readonly EmployeesListRequestExpandItem Company = new(Values.Company);

    public EmployeesListRequestExpandItem(string value)
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
    public static EmployeesListRequestExpandItem FromCustom(string value)
    {
        return new EmployeesListRequestExpandItem(value);
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

    public static bool operator ==(EmployeesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListRequestExpandItem value) => value.Value;

    public static explicit operator EmployeesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "company";
    }
}
