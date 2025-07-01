using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestExpandItem>))]
[Serializable]
public readonly record struct TimeOffListRequestExpandItem : IStringEnum
{
    public static readonly TimeOffListRequestExpandItem Approver = new(Values.Approver);

    public static readonly TimeOffListRequestExpandItem Employee = new(Values.Employee);

    public TimeOffListRequestExpandItem(string value)
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
    public static TimeOffListRequestExpandItem FromCustom(string value)
    {
        return new TimeOffListRequestExpandItem(value);
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

    public static bool operator ==(TimeOffListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffListRequestExpandItem value) => value.Value;

    public static explicit operator TimeOffListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Approver = "approver";

        public const string Employee = "employee";
    }
}
