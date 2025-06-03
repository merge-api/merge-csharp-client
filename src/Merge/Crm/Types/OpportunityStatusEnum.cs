using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunityStatusEnum>))]
public readonly record struct OpportunityStatusEnum : IStringEnum
{
    public static readonly OpportunityStatusEnum Open = new(Values.Open);

    public static readonly OpportunityStatusEnum Won = new(Values.Won);

    public static readonly OpportunityStatusEnum Lost = new(Values.Lost);

    public OpportunityStatusEnum(string value)
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
    public static OpportunityStatusEnum FromCustom(string value)
    {
        return new OpportunityStatusEnum(value);
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

    public static bool operator ==(OpportunityStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OpportunityStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OpportunityStatusEnum value) => value.Value;

    public static explicit operator OpportunityStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Open = "OPEN";

        public const string Won = "WON";

        public const string Lost = "LOST";
    }
}
