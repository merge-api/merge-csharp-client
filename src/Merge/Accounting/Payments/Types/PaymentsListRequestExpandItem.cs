using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Payments;

[JsonConverter(typeof(StringEnumSerializer<PaymentsListRequestExpandItem>))]
public readonly record struct PaymentsListRequestExpandItem : IStringEnum
{
    public static readonly PaymentsListRequestExpandItem Account = new(Values.Account);

    public static readonly PaymentsListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly PaymentsListRequestExpandItem AppliedToLines = new(
        Values.AppliedToLines
    );

    public static readonly PaymentsListRequestExpandItem Company = new(Values.Company);

    public static readonly PaymentsListRequestExpandItem Contact = new(Values.Contact);

    public static readonly PaymentsListRequestExpandItem PaymentMethod = new(Values.PaymentMethod);

    public static readonly PaymentsListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public PaymentsListRequestExpandItem(string value)
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
    public static PaymentsListRequestExpandItem FromCustom(string value)
    {
        return new PaymentsListRequestExpandItem(value);
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

    public static bool operator ==(PaymentsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsListRequestExpandItem value) => value.Value;

    public static explicit operator PaymentsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string AccountingPeriod = "accounting_period";

        public const string AppliedToLines = "applied_to_lines";

        public const string Company = "company";

        public const string Contact = "contact";

        public const string PaymentMethod = "payment_method";

        public const string TrackingCategories = "tracking_categories";
    }
}
