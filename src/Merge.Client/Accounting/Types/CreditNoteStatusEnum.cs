using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNoteStatusEnum>))]
[Serializable]
public readonly record struct CreditNoteStatusEnum : IStringEnum
{
    public static readonly CreditNoteStatusEnum Submitted = new(Values.Submitted);

    public static readonly CreditNoteStatusEnum Authorized = new(Values.Authorized);

    public static readonly CreditNoteStatusEnum Paid = new(Values.Paid);

    public CreditNoteStatusEnum(string value)
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
    public static CreditNoteStatusEnum FromCustom(string value)
    {
        return new CreditNoteStatusEnum(value);
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

    public static bool operator ==(CreditNoteStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNoteStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNoteStatusEnum value) => value.Value;

    public static explicit operator CreditNoteStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Submitted = "SUBMITTED";

        public const string Authorized = "AUTHORIZED";

        public const string Paid = "PAID";
    }
}
