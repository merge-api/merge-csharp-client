using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffBalancesListRequestExpandItem>))]
[Serializable]
public readonly record struct TimeOffBalancesListRequestExpandItem : IStringEnum
{
    public static readonly TimeOffBalancesListRequestExpandItem Employee = new(Values.Employee);

    public TimeOffBalancesListRequestExpandItem(string value)
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
    public static TimeOffBalancesListRequestExpandItem FromCustom(string value)
    {
        return new TimeOffBalancesListRequestExpandItem(value);
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

    public static bool operator ==(TimeOffBalancesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffBalancesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffBalancesListRequestExpandItem value) =>
        value.Value;

    public static explicit operator TimeOffBalancesListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Employee = "employee";
    }
}
