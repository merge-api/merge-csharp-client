using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsRetrieveRequestExpandItem>))]
public readonly record struct EmploymentsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly EmploymentsRetrieveRequestExpandItem Employee = new(Values.Employee);

    public static readonly EmploymentsRetrieveRequestExpandItem PayGroup = new(Values.PayGroup);

    public EmploymentsRetrieveRequestExpandItem(string value)
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
    public static EmploymentsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new EmploymentsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(EmploymentsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator EmploymentsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Employee = "employee";

        public const string PayGroup = "pay_group";
    }
}
