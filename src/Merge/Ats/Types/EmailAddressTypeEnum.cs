using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

[JsonConverter(typeof(StringEnumSerializer<EmailAddressTypeEnum>))]
public readonly record struct EmailAddressTypeEnum : IStringEnum
{
    public static readonly EmailAddressTypeEnum Personal = new(Values.Personal);

    public static readonly EmailAddressTypeEnum Work = new(Values.Work);

    public static readonly EmailAddressTypeEnum Other = new(Values.Other);

    public EmailAddressTypeEnum(string value)
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
    public static EmailAddressTypeEnum FromCustom(string value)
    {
        return new EmailAddressTypeEnum(value);
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

    public static bool operator ==(EmailAddressTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmailAddressTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmailAddressTypeEnum value) => value.Value;

    public static explicit operator EmailAddressTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Personal = "PERSONAL";

        public const string Work = "WORK";

        public const string Other = "OTHER";
    }
}
