using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Expenses;

[JsonConverter(typeof(StringEnumSerializer<ExpensesRetrieveRequestExpandItem>))]
public readonly record struct ExpensesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ExpensesRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly ExpensesRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly ExpensesRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly ExpensesRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly ExpensesRetrieveRequestExpandItem Employee = new(Values.Employee);

    public static readonly ExpensesRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public ExpensesRetrieveRequestExpandItem(string value)
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
    public static ExpensesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ExpensesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(ExpensesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExpensesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExpensesRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator ExpensesRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string AccountingPeriod = "accounting_period";

        public const string Company = "company";

        public const string Contact = "contact";

        public const string Employee = "employee";

        public const string TrackingCategories = "tracking_categories";
    }
}
