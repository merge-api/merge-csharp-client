using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ClassificationEnum>))]
[Serializable]
public readonly record struct ClassificationEnum : IStringEnum
{
    public static readonly ClassificationEnum Asset = new(Values.Asset);

    public static readonly ClassificationEnum Equity = new(Values.Equity);

    public static readonly ClassificationEnum Expense = new(Values.Expense);

    public static readonly ClassificationEnum Liability = new(Values.Liability);

    public static readonly ClassificationEnum Revenue = new(Values.Revenue);

    public ClassificationEnum(string value)
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
    public static ClassificationEnum FromCustom(string value)
    {
        return new ClassificationEnum(value);
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

    public static bool operator ==(ClassificationEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClassificationEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClassificationEnum value) => value.Value;

    public static explicit operator ClassificationEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Asset = "ASSET";

        public const string Equity = "EQUITY";

        public const string Expense = "EXPENSE";

        public const string Liability = "LIABILITY";

        public const string Revenue = "REVENUE";
    }
}
