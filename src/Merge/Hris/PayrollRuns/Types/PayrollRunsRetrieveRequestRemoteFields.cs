using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.PayrollRuns;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsRetrieveRequestRemoteFields>))]
public readonly record struct PayrollRunsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly PayrollRunsRetrieveRequestRemoteFields RunState = new(Values.RunState);

    public static readonly PayrollRunsRetrieveRequestRemoteFields RunStateRunType = new(
        Values.RunStateRunType
    );

    public static readonly PayrollRunsRetrieveRequestRemoteFields RunType = new(Values.RunType);

    public PayrollRunsRetrieveRequestRemoteFields(string value)
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
    public static PayrollRunsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new PayrollRunsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(PayrollRunsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayrollRunsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayrollRunsRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator PayrollRunsRetrieveRequestRemoteFields(string value) =>
        new(value);

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
