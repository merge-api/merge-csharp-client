using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.GeneralLedgerTransactions;

[JsonConverter(typeof(StringEnumSerializer<GeneralLedgerTransactionsRetrieveRequestExpandItem>))]
public readonly record struct GeneralLedgerTransactionsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly GeneralLedgerTransactionsRetrieveRequestExpandItem AccountingPeriod =
        new(Values.AccountingPeriod);

    public static readonly GeneralLedgerTransactionsRetrieveRequestExpandItem Company = new(
        Values.Company
    );

    public static readonly GeneralLedgerTransactionsRetrieveRequestExpandItem GeneralLedgerTransactionLines =
        new(Values.GeneralLedgerTransactionLines);

    public static readonly GeneralLedgerTransactionsRetrieveRequestExpandItem TrackingCategories =
        new(Values.TrackingCategories);

    public GeneralLedgerTransactionsRetrieveRequestExpandItem(string value)
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
    public static GeneralLedgerTransactionsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new GeneralLedgerTransactionsRetrieveRequestExpandItem(value);
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
        GeneralLedgerTransactionsRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GeneralLedgerTransactionsRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GeneralLedgerTransactionsRetrieveRequestExpandItem value
    ) => value.Value;

    public static explicit operator GeneralLedgerTransactionsRetrieveRequestExpandItem(
        string value
    ) => new(value);

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
