using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<BalanceSheetsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct BalanceSheetsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly BalanceSheetsRetrieveRequestExpandItem Company = new(Values.Company);

    public BalanceSheetsRetrieveRequestExpandItem(string value)
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
    public static BalanceSheetsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new BalanceSheetsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(BalanceSheetsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BalanceSheetsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BalanceSheetsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator BalanceSheetsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "company";
    }
}
