using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CashFlowStatementsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct CashFlowStatementsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CashFlowStatementsRetrieveRequestExpandItem Company = new(
        Values.Company
    );

    public CashFlowStatementsRetrieveRequestExpandItem(string value)
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
    public static CashFlowStatementsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CashFlowStatementsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(
        CashFlowStatementsRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CashFlowStatementsRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CashFlowStatementsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CashFlowStatementsRetrieveRequestExpandItem(string value) =>
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
