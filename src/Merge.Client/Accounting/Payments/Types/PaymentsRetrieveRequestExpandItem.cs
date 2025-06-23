using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PaymentsRetrieveRequestExpandItem>))]
public readonly record struct PaymentsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly PaymentsRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly PaymentsRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly PaymentsRetrieveRequestExpandItem AppliedToLines = new(
        Values.AppliedToLines
    );

    public static readonly PaymentsRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly PaymentsRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly PaymentsRetrieveRequestExpandItem PaymentMethod = new(
        Values.PaymentMethod
    );

    public static readonly PaymentsRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public PaymentsRetrieveRequestExpandItem(string value)
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
    public static PaymentsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new PaymentsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(PaymentsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator PaymentsRetrieveRequestExpandItem(string value) => new(value);

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
