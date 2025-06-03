using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<TypeEnum>))]
public readonly record struct TypeEnum : IStringEnum
{
    public static readonly TypeEnum User = new(Values.User);

    public static readonly TypeEnum Group = new(Values.Group);

    public static readonly TypeEnum Company = new(Values.Company);

    public static readonly TypeEnum Anyone = new(Values.Anyone);

    public TypeEnum(string value)
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
    public static TypeEnum FromCustom(string value)
    {
        return new TypeEnum(value);
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

    public static bool operator ==(TypeEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(TypeEnum value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(TypeEnum value) => value.Value;

    public static explicit operator TypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string User = "USER";

        public const string Group = "GROUP";

        public const string Company = "COMPANY";

        public const string Anyone = "ANYONE";
    }
}
