using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestExpandItem>))]
[Serializable]
public readonly record struct BankInfoListRequestExpandItem : IStringEnum
{
    public static readonly BankInfoListRequestExpandItem Employee = new(Values.Employee);

    public BankInfoListRequestExpandItem(string value)
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
    public static BankInfoListRequestExpandItem FromCustom(string value)
    {
        return new BankInfoListRequestExpandItem(value);
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

    public static bool operator ==(BankInfoListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoListRequestExpandItem value) => value.Value;

    public static explicit operator BankInfoListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Employee = "employee";
    }
}
