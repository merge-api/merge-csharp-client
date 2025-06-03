using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.CreditNotes;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesListRequestRemoteFields>))]
public readonly record struct CreditNotesListRequestRemoteFields : IStringEnum
{
    public static readonly CreditNotesListRequestRemoteFields Status = new(Values.Status);

    public static readonly CreditNotesListRequestRemoteFields StatusType = new(Values.StatusType);

    public static readonly CreditNotesListRequestRemoteFields Type = new(Values.Type);

    public CreditNotesListRequestRemoteFields(string value)
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
    public static CreditNotesListRequestRemoteFields FromCustom(string value)
    {
        return new CreditNotesListRequestRemoteFields(value);
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

    public static bool operator ==(CreditNotesListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNotesListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesListRequestRemoteFields value) => value.Value;

    public static explicit operator CreditNotesListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Status = "status";

        public const string StatusType = "status,type";

        public const string Type = "type";
    }
}
