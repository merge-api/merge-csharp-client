using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsListRequestRunType>))]
[Serializable]
public readonly record struct PayrollRunsListRequestRunType : IStringEnum
{
    public static readonly PayrollRunsListRequestRunType Correction = new(Values.Correction);

    public static readonly PayrollRunsListRequestRunType OffCycle = new(Values.OffCycle);

    public static readonly PayrollRunsListRequestRunType Regular = new(Values.Regular);

    public static readonly PayrollRunsListRequestRunType SignOnBonus = new(Values.SignOnBonus);

    public static readonly PayrollRunsListRequestRunType Termination = new(Values.Termination);

    public PayrollRunsListRequestRunType(string value)
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
    public static PayrollRunsListRequestRunType FromCustom(string value)
    {
        return new PayrollRunsListRequestRunType(value);
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

    public static bool operator ==(PayrollRunsListRequestRunType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayrollRunsListRequestRunType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayrollRunsListRequestRunType value) => value.Value;

    public static explicit operator PayrollRunsListRequestRunType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Correction = "CORRECTION";

        public const string OffCycle = "OFF_CYCLE";

        public const string Regular = "REGULAR";

        public const string SignOnBonus = "SIGN_ON_BONUS";

        public const string Termination = "TERMINATION";
    }
}
