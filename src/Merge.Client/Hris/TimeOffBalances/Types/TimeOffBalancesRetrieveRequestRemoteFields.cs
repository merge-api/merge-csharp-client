using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffBalancesRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct TimeOffBalancesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly TimeOffBalancesRetrieveRequestRemoteFields PolicyType = new(
        Values.PolicyType
    );

    public TimeOffBalancesRetrieveRequestRemoteFields(string value)
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
    public static TimeOffBalancesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new TimeOffBalancesRetrieveRequestRemoteFields(value);
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
        TimeOffBalancesRetrieveRequestRemoteFields value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TimeOffBalancesRetrieveRequestRemoteFields value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffBalancesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator TimeOffBalancesRetrieveRequestRemoteFields(string value) =>
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
