using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<RolesEnum>))]
public readonly record struct RolesEnum : IStringEnum
{
    public static readonly RolesEnum Read = new(Values.Read);

    public static readonly RolesEnum Write = new(Values.Write);

    public static readonly RolesEnum Owner = new(Values.Owner);

    public RolesEnum(string value)
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
    public static RolesEnum FromCustom(string value)
    {
        return new RolesEnum(value);
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

    public static bool operator ==(RolesEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(RolesEnum value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(RolesEnum value) => value.Value;

    public static explicit operator RolesEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Read = "READ";

        public const string Write = "WRITE";

        public const string Owner = "OWNER";
    }
}
