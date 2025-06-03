using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoiceStatusEnum>))]
public readonly record struct InvoiceStatusEnum : IStringEnum
{
    public static readonly InvoiceStatusEnum Paid = new(Values.Paid);

    public static readonly InvoiceStatusEnum Draft = new(Values.Draft);

    public static readonly InvoiceStatusEnum Submitted = new(Values.Submitted);

    public static readonly InvoiceStatusEnum PartiallyPaid = new(Values.PartiallyPaid);

    public static readonly InvoiceStatusEnum Open = new(Values.Open);

    public static readonly InvoiceStatusEnum Void = new(Values.Void);

    public InvoiceStatusEnum(string value)
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
    public static InvoiceStatusEnum FromCustom(string value)
    {
        return new InvoiceStatusEnum(value);
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

    public static bool operator ==(InvoiceStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoiceStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceStatusEnum value) => value.Value;

    public static explicit operator InvoiceStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Paid = "PAID";

        public const string Draft = "DRAFT";

        public const string Submitted = "SUBMITTED";

        public const string PartiallyPaid = "PARTIALLY_PAID";

        public const string Open = "OPEN";

        public const string Void = "VOID";
    }
}
