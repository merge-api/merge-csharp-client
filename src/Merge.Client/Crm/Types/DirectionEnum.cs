using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<DirectionEnum>))]
[Serializable]
public readonly record struct DirectionEnum : IStringEnum
{
    public static readonly DirectionEnum Inbound = new(Values.Inbound);

    public static readonly DirectionEnum Outbound = new(Values.Outbound);

    public DirectionEnum(string value)
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
    public static DirectionEnum FromCustom(string value)
    {
        return new DirectionEnum(value);
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

    public static bool operator ==(DirectionEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DirectionEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DirectionEnum value) => value.Value;

    public static explicit operator DirectionEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Inbound = "INBOUND";

        public const string Outbound = "OUTBOUND";
    }
}
