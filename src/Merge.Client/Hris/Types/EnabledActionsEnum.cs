using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EnabledActionsEnum>))]
public readonly record struct EnabledActionsEnum : IStringEnum
{
    public static readonly EnabledActionsEnum Read = new(Values.Read);

    public static readonly EnabledActionsEnum Write = new(Values.Write);

    public EnabledActionsEnum(string value)
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
    public static EnabledActionsEnum FromCustom(string value)
    {
        return new EnabledActionsEnum(value);
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

    public static bool operator ==(EnabledActionsEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EnabledActionsEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EnabledActionsEnum value) => value.Value;

    public static explicit operator EnabledActionsEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Read = "READ";

        public const string Write = "WRITE";
    }
}
