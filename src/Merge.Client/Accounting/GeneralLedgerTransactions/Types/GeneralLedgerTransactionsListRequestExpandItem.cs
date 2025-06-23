using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<GeneralLedgerTransactionsListRequestExpandItem>))]
public readonly record struct GeneralLedgerTransactionsListRequestExpandItem : IStringEnum
{
    public static readonly GeneralLedgerTransactionsListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly GeneralLedgerTransactionsListRequestExpandItem Company = new(
        Values.Company
    );

    public static readonly GeneralLedgerTransactionsListRequestExpandItem GeneralLedgerTransactionLines =
        new(Values.GeneralLedgerTransactionLines);

    public static readonly GeneralLedgerTransactionsListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public GeneralLedgerTransactionsListRequestExpandItem(string value)
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
    public static GeneralLedgerTransactionsListRequestExpandItem FromCustom(string value)
    {
        return new GeneralLedgerTransactionsListRequestExpandItem(value);
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

    public static bool operator ==(
        GeneralLedgerTransactionsListRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GeneralLedgerTransactionsListRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GeneralLedgerTransactionsListRequestExpandItem value) =>
        value.Value;

    public static explicit operator GeneralLedgerTransactionsListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string Company = "company";

        public const string GeneralLedgerTransactionLines = "general_ledger_transaction_lines";

        public const string TrackingCategories = "tracking_categories";
    }
}
