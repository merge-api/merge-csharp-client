using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsListRequestExpandItem>))]
public readonly record struct EmploymentsListRequestExpandItem : IStringEnum
{
    public static readonly EmploymentsListRequestExpandItem Employee = new(Values.Employee);

    public static readonly EmploymentsListRequestExpandItem PayGroup = new(Values.PayGroup);

    public EmploymentsListRequestExpandItem(string value)
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
    public static EmploymentsListRequestExpandItem FromCustom(string value)
    {
        return new EmploymentsListRequestExpandItem(value);
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

    public static bool operator ==(EmploymentsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsListRequestExpandItem value) => value.Value;

    public static explicit operator EmploymentsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Employee = "employee";

        public const string PayGroup = "pay_group";
    }
}
