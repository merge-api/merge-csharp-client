using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsListRequestShowEnumOrigins>))]
public readonly record struct PayrollRunsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly PayrollRunsListRequestShowEnumOrigins RunState = new(Values.RunState);

    public static readonly PayrollRunsListRequestShowEnumOrigins RunStateRunType = new(
        Values.RunStateRunType
    );

    public static readonly PayrollRunsListRequestShowEnumOrigins RunType = new(Values.RunType);

    public PayrollRunsListRequestShowEnumOrigins(string value)
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
    public static PayrollRunsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new PayrollRunsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(PayrollRunsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayrollRunsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayrollRunsListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator PayrollRunsListRequestShowEnumOrigins(string value) =>
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
