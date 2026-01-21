using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CashFlowStatementsListRequestExpandItem>))]
[Serializable]
public readonly record struct CashFlowStatementsListRequestExpandItem : IStringEnum
{
    public static readonly CashFlowStatementsListRequestExpandItem Company = new(Values.Company);

    public CashFlowStatementsListRequestExpandItem(string value)
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
    public static CashFlowStatementsListRequestExpandItem FromCustom(string value)
    {
        return new CashFlowStatementsListRequestExpandItem(value);
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

    public static bool operator ==(CashFlowStatementsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CashFlowStatementsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CashFlowStatementsListRequestExpandItem value) =>
        value.Value;

    public static explicit operator CashFlowStatementsListRequestExpandItem(string value) =>
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
