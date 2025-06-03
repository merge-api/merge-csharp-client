using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<UnderlyingTransactionTypeEnum>))]
public readonly record struct UnderlyingTransactionTypeEnum : IStringEnum
{
    public static readonly UnderlyingTransactionTypeEnum Invoice = new(Values.Invoice);

    public static readonly UnderlyingTransactionTypeEnum Expense = new(Values.Expense);

    public static readonly UnderlyingTransactionTypeEnum Transaction = new(Values.Transaction);

    public static readonly UnderlyingTransactionTypeEnum JournalEntry = new(Values.JournalEntry);

    public static readonly UnderlyingTransactionTypeEnum Payment = new(Values.Payment);

    public static readonly UnderlyingTransactionTypeEnum VendorCredit = new(Values.VendorCredit);

    public static readonly UnderlyingTransactionTypeEnum CreditNote = new(Values.CreditNote);

    public UnderlyingTransactionTypeEnum(string value)
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
    public static UnderlyingTransactionTypeEnum FromCustom(string value)
    {
        return new UnderlyingTransactionTypeEnum(value);
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

    public static bool operator ==(UnderlyingTransactionTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UnderlyingTransactionTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UnderlyingTransactionTypeEnum value) => value.Value;

    public static explicit operator UnderlyingTransactionTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Invoice = "INVOICE";

        public const string Expense = "EXPENSE";

        public const string Transaction = "TRANSACTION";

        public const string JournalEntry = "JOURNAL_ENTRY";

        public const string Payment = "PAYMENT";

        public const string VendorCredit = "VENDOR_CREDIT";

        public const string CreditNote = "CREDIT_NOTE";
    }
}
