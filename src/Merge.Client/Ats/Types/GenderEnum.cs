using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<GenderEnum>))]
public readonly record struct GenderEnum : IStringEnum
{
    public static readonly GenderEnum Male = new(Values.Male);

    public static readonly GenderEnum Female = new(Values.Female);

    public static readonly GenderEnum NonBinary = new(Values.NonBinary);

    public static readonly GenderEnum Other = new(Values.Other);

    public static readonly GenderEnum DeclineToSelfIdentify = new(Values.DeclineToSelfIdentify);

    public GenderEnum(string value)
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
    public static GenderEnum FromCustom(string value)
    {
        return new GenderEnum(value);
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

    public static bool operator ==(GenderEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(GenderEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GenderEnum value) => value.Value;

    public static explicit operator GenderEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Male = "MALE";

        public const string Female = "FEMALE";

        public const string NonBinary = "NON-BINARY";

        public const string Other = "OTHER";

        public const string DeclineToSelfIdentify = "DECLINE_TO_SELF_IDENTIFY";
    }
}
