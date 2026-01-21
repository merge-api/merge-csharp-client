using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct BankInfoRetrieveRequestExpandItem : IStringEnum
{
    public static readonly BankInfoRetrieveRequestExpandItem Employee = new(Values.Employee);

    public BankInfoRetrieveRequestExpandItem(string value)
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
    public static BankInfoRetrieveRequestExpandItem FromCustom(string value)
    {
        return new BankInfoRetrieveRequestExpandItem(value);
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

    public static bool operator ==(BankInfoRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator BankInfoRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Employee = "employee";
    }
}
