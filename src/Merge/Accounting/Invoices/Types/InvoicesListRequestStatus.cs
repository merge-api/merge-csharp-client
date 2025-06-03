using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Invoices;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestStatus>))]
public readonly record struct InvoicesListRequestStatus : IStringEnum
{
    public static readonly InvoicesListRequestStatus Draft = new(Values.Draft);

    public static readonly InvoicesListRequestStatus Open = new(Values.Open);

    public static readonly InvoicesListRequestStatus Paid = new(Values.Paid);

    public static readonly InvoicesListRequestStatus PartiallyPaid = new(Values.PartiallyPaid);

    public static readonly InvoicesListRequestStatus Submitted = new(Values.Submitted);

    public static readonly InvoicesListRequestStatus Void = new(Values.Void);

    public InvoicesListRequestStatus(string value)
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
    public static InvoicesListRequestStatus FromCustom(string value)
    {
        return new InvoicesListRequestStatus(value);
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

    public static bool operator ==(InvoicesListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListRequestStatus value) => value.Value;

    public static explicit operator InvoicesListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Draft = "DRAFT";

        public const string Open = "OPEN";

        public const string Paid = "PAID";

        public const string PartiallyPaid = "PARTIALLY_PAID";

        public const string Submitted = "SUBMITTED";

        public const string Void = "VOID";
    }
}
