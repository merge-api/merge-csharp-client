using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RelationshipEnum>))]
public readonly record struct RelationshipEnum : IStringEnum
{
    public static readonly RelationshipEnum Child = new(Values.Child);

    public static readonly RelationshipEnum Spouse = new(Values.Spouse);

    public static readonly RelationshipEnum DomesticPartner = new(Values.DomesticPartner);

    public RelationshipEnum(string value)
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
    public static RelationshipEnum FromCustom(string value)
    {
        return new RelationshipEnum(value);
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

    public static bool operator ==(RelationshipEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RelationshipEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RelationshipEnum value) => value.Value;

    public static explicit operator RelationshipEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Child = "CHILD";

        public const string Spouse = "SPOUSE";

        public const string DomesticPartner = "DOMESTIC_PARTNER";
    }
}
