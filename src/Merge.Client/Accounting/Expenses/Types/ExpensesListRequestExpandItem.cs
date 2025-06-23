using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ExpensesListRequestExpandItem>))]
public readonly record struct ExpensesListRequestExpandItem : IStringEnum
{
    public static readonly ExpensesListRequestExpandItem Account = new(Values.Account);

    public static readonly ExpensesListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly ExpensesListRequestExpandItem Company = new(Values.Company);

    public static readonly ExpensesListRequestExpandItem Contact = new(Values.Contact);

    public static readonly ExpensesListRequestExpandItem Employee = new(Values.Employee);

    public static readonly ExpensesListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public ExpensesListRequestExpandItem(string value)
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
    public static ExpensesListRequestExpandItem FromCustom(string value)
    {
        return new ExpensesListRequestExpandItem(value);
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

    public static bool operator ==(ExpensesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExpensesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExpensesListRequestExpandItem value) => value.Value;

    public static explicit operator ExpensesListRequestExpandItem(string value) => new(value);

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
