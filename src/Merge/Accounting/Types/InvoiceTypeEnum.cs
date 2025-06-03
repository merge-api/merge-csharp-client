using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoiceTypeEnum>))]
public readonly record struct InvoiceTypeEnum : IStringEnum
{
    public static readonly InvoiceTypeEnum AccountsReceivable = new(Values.AccountsReceivable);

    public static readonly InvoiceTypeEnum AccountsPayable = new(Values.AccountsPayable);

    public InvoiceTypeEnum(string value)
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
    public static InvoiceTypeEnum FromCustom(string value)
    {
        return new InvoiceTypeEnum(value);
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

    public static bool operator ==(InvoiceTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoiceTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTypeEnum value) => value.Value;

    public static explicit operator InvoiceTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountsReceivable = "ACCOUNTS_RECEIVABLE";

        public const string AccountsPayable = "ACCOUNTS_PAYABLE";
    }
}
