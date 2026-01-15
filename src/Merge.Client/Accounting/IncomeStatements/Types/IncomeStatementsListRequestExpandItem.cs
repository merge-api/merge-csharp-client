using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<IncomeStatementsListRequestExpandItem>))]
[Serializable]
public readonly record struct IncomeStatementsListRequestExpandItem : IStringEnum
{
    public static readonly IncomeStatementsListRequestExpandItem Company = new(Values.Company);

    public IncomeStatementsListRequestExpandItem(string value)
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
    public static IncomeStatementsListRequestExpandItem FromCustom(string value)
    {
        return new IncomeStatementsListRequestExpandItem(value);
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

    public static bool operator ==(IncomeStatementsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IncomeStatementsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IncomeStatementsListRequestExpandItem value) =>
        value.Value;

    public static explicit operator IncomeStatementsListRequestExpandItem(string value) =>
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
