using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<PhoneNumberTypeEnum>))]
[Serializable]
public readonly record struct PhoneNumberTypeEnum : IStringEnum
{
    public static readonly PhoneNumberTypeEnum Home = new(Values.Home);

    public static readonly PhoneNumberTypeEnum Work = new(Values.Work);

    public static readonly PhoneNumberTypeEnum Mobile = new(Values.Mobile);

    public static readonly PhoneNumberTypeEnum Skype = new(Values.Skype);

    public static readonly PhoneNumberTypeEnum Other = new(Values.Other);

    public PhoneNumberTypeEnum(string value)
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
    public static PhoneNumberTypeEnum FromCustom(string value)
    {
        return new PhoneNumberTypeEnum(value);
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

    public static bool operator ==(PhoneNumberTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PhoneNumberTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PhoneNumberTypeEnum value) => value.Value;

    public static explicit operator PhoneNumberTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Home = "HOME";

        public const string Work = "WORK";

        public const string Mobile = "MOBILE";

        public const string Skype = "SKYPE";

        public const string Other = "OTHER";
    }
}
