using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<OfferStatusEnum>))]
public readonly record struct OfferStatusEnum : IStringEnum
{
    public static readonly OfferStatusEnum Draft = new(Values.Draft);

    public static readonly OfferStatusEnum ApprovalSent = new(Values.ApprovalSent);

    public static readonly OfferStatusEnum Approved = new(Values.Approved);

    public static readonly OfferStatusEnum Sent = new(Values.Sent);

    public static readonly OfferStatusEnum SentManually = new(Values.SentManually);

    public static readonly OfferStatusEnum Opened = new(Values.Opened);

    public static readonly OfferStatusEnum Denied = new(Values.Denied);

    public static readonly OfferStatusEnum Signed = new(Values.Signed);

    public static readonly OfferStatusEnum Deprecated = new(Values.Deprecated);

    public OfferStatusEnum(string value)
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
    public static OfferStatusEnum FromCustom(string value)
    {
        return new OfferStatusEnum(value);
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

    public static bool operator ==(OfferStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OfferStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OfferStatusEnum value) => value.Value;

    public static explicit operator OfferStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Draft = "DRAFT";

        public const string ApprovalSent = "APPROVAL-SENT";

        public const string Approved = "APPROVED";

        public const string Sent = "SENT";

        public const string SentManually = "SENT-MANUALLY";

        public const string Opened = "OPENED";

        public const string Denied = "DENIED";

        public const string Signed = "SIGNED";

        public const string Deprecated = "DEPRECATED";
    }
}
