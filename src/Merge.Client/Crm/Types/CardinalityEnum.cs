using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<CardinalityEnum>))]
[Serializable]
public readonly record struct CardinalityEnum : IStringEnum
{
    public static readonly CardinalityEnum OneToOne = new(Values.OneToOne);

    public static readonly CardinalityEnum ManyToOne = new(Values.ManyToOne);

    public static readonly CardinalityEnum ManyToMany = new(Values.ManyToMany);

    public static readonly CardinalityEnum OneToMany = new(Values.OneToMany);

    public CardinalityEnum(string value)
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
    public static CardinalityEnum FromCustom(string value)
    {
        return new CardinalityEnum(value);
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

    public static bool operator ==(CardinalityEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CardinalityEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CardinalityEnum value) => value.Value;

    public static explicit operator CardinalityEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OneToOne = "ONE_TO_ONE";

        public const string ManyToOne = "MANY_TO_ONE";

        public const string ManyToMany = "MANY_TO_MANY";

        public const string OneToMany = "ONE_TO_MANY";
    }
}
