using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffBalancesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct TimeOffBalancesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TimeOffBalancesRetrieveRequestExpandItem Employee = new(Values.Employee);

    public TimeOffBalancesRetrieveRequestExpandItem(string value)
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
    public static TimeOffBalancesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TimeOffBalancesRetrieveRequestExpandItem(value);
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
        TimeOffBalancesRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TimeOffBalancesRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffBalancesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator TimeOffBalancesRetrieveRequestExpandItem(string value) =>
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
