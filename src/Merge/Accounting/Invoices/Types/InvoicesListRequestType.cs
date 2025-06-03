using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Invoices;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestType>))]
public readonly record struct InvoicesListRequestType : IStringEnum
{
    public static readonly InvoicesListRequestType AccountsPayable = new(Values.AccountsPayable);

    public static readonly InvoicesListRequestType AccountsReceivable = new(
        Values.AccountsReceivable
    );

    public InvoicesListRequestType(string value)
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
    public static InvoicesListRequestType FromCustom(string value)
    {
        return new InvoicesListRequestType(value);
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

    public static bool operator ==(InvoicesListRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListRequestType value) => value.Value;

    public static explicit operator InvoicesListRequestType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountsPayable = "ACCOUNTS_PAYABLE";

        public const string AccountsReceivable = "ACCOUNTS_RECEIVABLE";
    }
}
