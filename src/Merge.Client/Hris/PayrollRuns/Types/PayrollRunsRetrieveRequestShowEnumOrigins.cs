using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsRetrieveRequestShowEnumOrigins>))]
public readonly record struct PayrollRunsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly PayrollRunsRetrieveRequestShowEnumOrigins RunState = new(
        Values.RunState
    );

    public static readonly PayrollRunsRetrieveRequestShowEnumOrigins RunStateRunType = new(
        Values.RunStateRunType
    );

    public static readonly PayrollRunsRetrieveRequestShowEnumOrigins RunType = new(Values.RunType);

    public PayrollRunsRetrieveRequestShowEnumOrigins(string value)
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
    public static PayrollRunsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new PayrollRunsRetrieveRequestShowEnumOrigins(value);
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
        PayrollRunsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PayrollRunsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PayrollRunsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator PayrollRunsRetrieveRequestShowEnumOrigins(string value) =>
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
