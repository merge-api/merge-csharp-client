using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<LanguageEnum>))]
[Serializable]
public readonly record struct LanguageEnum : IStringEnum
{
    public static readonly LanguageEnum En = new(Values.En);

    public static readonly LanguageEnum De = new(Values.De);

    public LanguageEnum(string value)
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
    public static LanguageEnum FromCustom(string value)
    {
        return new LanguageEnum(value);
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

    public static bool operator ==(LanguageEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LanguageEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LanguageEnum value) => value.Value;

    public static explicit operator LanguageEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string En = "en";

        public const string De = "de";
    }
}
