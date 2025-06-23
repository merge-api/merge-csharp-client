using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsListRequestRemoteFields>))]
public readonly record struct PayrollRunsListRequestRemoteFields : IStringEnum
{
    public static readonly PayrollRunsListRequestRemoteFields RunState = new(Values.RunState);

    public static readonly PayrollRunsListRequestRemoteFields RunStateRunType = new(
        Values.RunStateRunType
    );

    public static readonly PayrollRunsListRequestRemoteFields RunType = new(Values.RunType);

    public PayrollRunsListRequestRemoteFields(string value)
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
    public static PayrollRunsListRequestRemoteFields FromCustom(string value)
    {
        return new PayrollRunsListRequestRemoteFields(value);
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

    public static bool operator ==(PayrollRunsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayrollRunsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayrollRunsListRequestRemoteFields value) => value.Value;

    public static explicit operator PayrollRunsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string RunState = "run_state";

        public const string RunStateRunType = "run_state,run_type";

        public const string RunType = "run_type";
    }
}
