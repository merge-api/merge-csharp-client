using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffBalancesListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct TimeOffBalancesListRequestShowEnumOrigins : IStringEnum
{
    public static readonly TimeOffBalancesListRequestShowEnumOrigins PolicyType = new(
        Values.PolicyType
    );

    public TimeOffBalancesListRequestShowEnumOrigins(string value)
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
    public static TimeOffBalancesListRequestShowEnumOrigins FromCustom(string value)
    {
        return new TimeOffBalancesListRequestShowEnumOrigins(value);
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
        TimeOffBalancesListRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TimeOffBalancesListRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffBalancesListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator TimeOffBalancesListRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PolicyType = "policy_type";
    }
}
