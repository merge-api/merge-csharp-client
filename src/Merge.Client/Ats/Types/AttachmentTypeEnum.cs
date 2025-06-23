using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<AttachmentTypeEnum>))]
public readonly record struct AttachmentTypeEnum : IStringEnum
{
    public static readonly AttachmentTypeEnum Resume = new(Values.Resume);

    public static readonly AttachmentTypeEnum CoverLetter = new(Values.CoverLetter);

    public static readonly AttachmentTypeEnum OfferLetter = new(Values.OfferLetter);

    public static readonly AttachmentTypeEnum Other = new(Values.Other);

    public AttachmentTypeEnum(string value)
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
    public static AttachmentTypeEnum FromCustom(string value)
    {
        return new AttachmentTypeEnum(value);
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

    public static bool operator ==(AttachmentTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttachmentTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttachmentTypeEnum value) => value.Value;

    public static explicit operator AttachmentTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Resume = "RESUME";

        public const string CoverLetter = "COVER_LETTER";

        public const string OfferLetter = "OFFER_LETTER";

        public const string Other = "OTHER";
    }
}
