using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RunTypeEnum>))]
[Serializable]
public readonly record struct RunTypeEnum : IStringEnum
{
    public static readonly RunTypeEnum Regular = new(Values.Regular);

    public static readonly RunTypeEnum OffCycle = new(Values.OffCycle);

    public static readonly RunTypeEnum Correction = new(Values.Correction);

    public static readonly RunTypeEnum Termination = new(Values.Termination);

    public static readonly RunTypeEnum SignOnBonus = new(Values.SignOnBonus);

    public RunTypeEnum(string value)
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
    public static RunTypeEnum FromCustom(string value)
    {
        return new RunTypeEnum(value);
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

    public static bool operator ==(RunTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunTypeEnum value) => value.Value;

    public static explicit operator RunTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Regular = "REGULAR";

        public const string OffCycle = "OFF_CYCLE";

        public const string Correction = "CORRECTION";

        public const string Termination = "TERMINATION";

        public const string SignOnBonus = "SIGN_ON_BONUS";
    }
}
